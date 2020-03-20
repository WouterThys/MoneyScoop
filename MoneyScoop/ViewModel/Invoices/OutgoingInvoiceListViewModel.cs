using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using MoneyScoop.Model;
using MoneyScoop.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class OutgoingInvoiceListViewModel : BaseListViewModel<Invoice>
    {
        public static OutgoingInvoiceListViewModel Create()
        {
            return ViewModelSource.Create(() => new OutgoingInvoiceListViewModel());
        }

        public OutgoingInvoiceListViewModel() : base(ModuleTypes.OutgoingInvoiceListModule, ModuleTypes.OutgoingInvoiceEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Invoice baseObject)
        {
            return OutgoingInvoiceEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Invoice> Source()
        {
            return DataSource.Ds.Invoices.Where(i => i.OutGoing);
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
        }

        
        public virtual bool CanRefresh()
        {
            return !IsLoading;
        }

        public virtual void Refresh()
        {
            IEnumerable<string> allFiles = InvoiceActionHelper.GetAllOutgoingInvoices();
            if (allFiles != null)
            {
                List<string> toCreate = new List<string>();
                foreach (string filePath in allFiles)
                {
                    Invoice invoice = FindOutgoingInvoiceForFile(filePath);
                    if (invoice == null)
                    {
                        toCreate.Add(filePath);
                    }
                }
                foreach (string filePath in toCreate)
                {
                    CreateNewInvoice(filePath);
                }
            }
        }

        private Invoice FindOutgoingInvoiceForFile(string file)
        {
            return DataSource.Ds.Invoices.FirstOrDefault(i => i.OutGoing && i.SavePath == file);
        }

        private Customer FindCustomerForFile(string file)
        {
            return DataSource.Ds.Customers.FirstOrDefault(c => c.Id > BaseObject.UNKNOWN_ID && file.ToUpper().Contains(c.Code));
        }

        private void CreateNewInvoice(string filePath)
        {
            Task.Factory.StartNew((disp) =>
            {
                Invoice newInvoice = new Invoice
                {
                    SavePath = filePath,
                    OutGoing = true,
                    VAT = 21,
                    VATShifted = false
                };

                // Try to resolve customer
                Customer foundCustomer = FindCustomerForFile(filePath);
                if (foundCustomer != null)
                {
                    newInvoice.CustomerId = foundCustomer.Id;
                }

                // Resolve dates
                DateTime date = File.GetLastWriteTime(filePath);
                newInvoice.DateCreated = date;
                newInvoice.DatePayed = date;
                newInvoice.DateSend = date;
                newInvoice.Code = Path.GetFileNameWithoutExtension(filePath);

                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    AddEntity(newInvoice);
                });
            }, DispatcherService);
        }
    }
}
