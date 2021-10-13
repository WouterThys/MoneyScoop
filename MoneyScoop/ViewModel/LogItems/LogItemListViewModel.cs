using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyScoop.ViewModel.LogItems
{
    [POCOViewModel]
    public class LogItemListViewModel : BaseListViewModel<LogItem>
    {
        public static LogItemListViewModel Create()
        {
            return ViewModelSource.Create(() => new LogItemListViewModel());
        }

        public virtual LogItemDetailsViewModel DetailModel { get; protected set; }

        public LogItemListViewModel() : base(ModuleTypes.LogItemListModule)
        {
            DetailModel = LogItemDetailsViewModel.Create();
            DetailModel.SetParentViewModel(this);
        }

        public override IBaseViewModel GetEditViewModel(LogItem baseObject)
        {
            return LogItemEditViewModel.Create(baseObject);
        }

        public override IEnumerable<LogItem> Source()
        {
            return DataSource.Ds.LogItems;
        }

        public override void OnSelectionChanged()
        {
            base.OnSelectionChanged();
            DetailModel.Entity = Selected;
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
            this.RaiseCanExecuteChanged(x => x.CreateInvoices());
        }

        public bool CanCreateInvoices()
        {
            return true;
        }

        private class LogItemToInvoice
        {
            public long CustomerId { get; set; }
            public int Month { get; set; }
            public List<LogItem> LogItems { get; set; }
        }

        public void CreateInvoices()
        {
            // Get log items
            IEnumerable<LogItem> logItems = Entities.Where(i => i.InvoiceLineId <= BaseObject.UNKNOWN_ID);

            List<LogItemToInvoice> logItemToInvoices = new List<LogItemToInvoice>();
            foreach (LogItem li in logItems)
            {
                if (li.CustomerId <= BaseObject.UNKNOWN_ID) continue;
                if (li.TimeStamp.Year < 2000) continue;

                var found = logItemToInvoices.FirstOrDefault(liti => liti.CustomerId == li.CustomerId && liti.Month == li.TimeStamp.Month);

                if (found == null)
                {
                    found = new LogItemToInvoice()
                    {
                        CustomerId = li.CustomerId,
                        Month = li.TimeStamp.Month,
                        LogItems = new List<LogItem>()
                    };
                    logItemToInvoices.Add(found);
                }

                found.LogItems.Add(li);
            }

            CreateInvoices(logItemToInvoices);

        }

        private void CreateInvoices(List<LogItemToInvoice> logItemToInvoices)
        {
            foreach (LogItemToInvoice liti in logItemToInvoices)
            {
                Customer customer = DataSource.Ds.Customers.ById(liti.CustomerId);

                // TODO: find invoice!
                Invoice invoice =  DataSource.Ds.Invoices.FirstOrDefault(i => 
                        !i.IsSend && 
                        i.CustomerId == liti.CustomerId && 
                        i.DateCreated.Month == liti.Month);

                if (invoice == null)
                {
                    invoice = new Invoice
                    {
                        Code = Invoice.CreateCode(DateTime.Now),
                        DateCreated = DateTime.Now,
                        CustomerId = liti.CustomerId,
                        VATShifted = customer.VatShifted,
                        OutGoing = false,
                        Description = customer.InvoiceCode + " " + new DateTime(2000, liti.Month, 1).ToString("MMMM")
                    };
                }

                invoice.Save().Wait();
                DataSource.Ds.Invoices.Add(invoice);

                foreach (LogItem li in new List<LogItem>(liti.LogItems))
                {
                    bool addToInvoice = false;
                    InvoiceLine line = invoice.InvoiceLines.FirstOrDefault(il => il.Code == li.GroupTag);
                    if (line == null)
                    {
                        addToInvoice = true;
                        line = new InvoiceLine(invoice)
                        {
                            Multiplier = li.WorkTime.TotalHours,
                            UnitPrice = customer.DefaultUnitPrice,
                            Code = li.GroupTag,
                            Description = li.Description
                        };
                    }
                    else
                    {
                        line.Multiplier += li.WorkTime.TotalHours;
                        line.Description += $", {li.Description}";
                    }

                    
                    liti.LogItems.Remove(li);

                    line.Save().Wait();
                    li.InvoiceLineId = line.Id;
                    li.Save().Wait();

                    if (addToInvoice)
                        invoice.AddInvoiceLine(line);
                }
                invoice.Save().Wait();

                IncomingInvoiceEditViewModel model = IncomingInvoiceEditViewModel.Create(invoice);
                ShowDocument(model);
                
            }
        }
    }
}
