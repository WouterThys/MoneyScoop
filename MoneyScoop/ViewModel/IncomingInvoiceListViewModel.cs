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

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class IncomingInvoiceListViewModel : BaseListViewModel<Invoice>
    {
        public static IncomingInvoiceListViewModel Create()
        {
            return ViewModelSource.Create(() => new IncomingInvoiceListViewModel());
        }

        public IncomingInvoiceListViewModel() : base(ModuleTypes.IncomingInvoiceListModule, ModuleTypes.IncomingInvoiceEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Invoice baseObject)
        {
            return IncomingInvoiceEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Invoice> Source()
        {
            return DataSource.Ds.Invoices.Where(i => !i.OutGoing);
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
            this.RaiseCanExecuteChanged(x => x.ShowInvoicePreviews());
            this.RaiseCanExecuteChanged(x => x.SavePdfReports());
            this.RaiseCanExecuteChanged(x => x.SendMailToCustomer());
        }
        

        public virtual bool CanShowInvoicePreviews()
        {
            return !IsLoading && Selection != null;
        }

        public virtual void ShowInvoicePreviews()
        {
            foreach (Invoice invoice in Selection)
            {
                try
                {
                    InvoiceActionHelper.ShowPreview(invoice);
                }
                catch (Exception e)
                {
                    MessageBoxService.Show("Preview error: \n" + e.Message, "Error", MessageButton.OK, MessageIcon.Error, MessageResult.OK);
                }
            }
        }

        


        public virtual bool CanSavePdfReports()
        {
            return !IsLoading && Selection != null;
        }

        public virtual void SavePdfReports()
        {
            foreach (Invoice invoice in Selection)
            {
                try
                {
                    InvoiceActionHelper.SaveToPdf(invoice);
                }
                catch (Exception e)
                {
                    MessageBoxService.Show("Error while saving: \n" + e.Message, "Error", MessageButton.OK, MessageIcon.Error, MessageResult.OK);
                }
            }
        }


        public virtual bool CanSendMailToCustomer()
        {
            return !IsLoading && Selected != null && Selected.Customer != null && !string.IsNullOrEmpty(Selected.Customer.Email);
        }

        public virtual void SendMailToCustomer()
        {

        }
    }
}
