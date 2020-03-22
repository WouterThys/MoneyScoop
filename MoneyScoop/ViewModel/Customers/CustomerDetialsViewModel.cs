using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class CustomerDetialsViewModel : BaseDetailsViewModel<Customer>
    {
        public static CustomerDetialsViewModel Create()
        {
            return ViewModelSource.Create(() => new CustomerDetialsViewModel());
        }

        public virtual BindingList<Invoice> Invoices { get; set; }
        public virtual List<Invoice> InvoiceSelection { get; set; }

        protected CustomerDetialsViewModel() : base(ModuleTypes.CustomerDetailsModule)
        {
            
        }

        private List<Invoice> tempInvoices;
        public override void OnLoading()
        {
            base.OnLoading();
            tempInvoices = Entity != null ? 
                new List<Invoice>(DataSource.Ds.Invoices.Where(i => i.CustomerId == Entity.Id))
                : 
                new List<Invoice>();
        }

        public override void OnLoaded()
        {
            Invoices = new BindingList<Invoice>(tempInvoices);
            base.OnLoaded();
        }

        public virtual Invoice SelectedInvoice
        {
            get
            {
                if (InvoiceSelection != null && InvoiceSelection.Count > 0)
                {
                    return InvoiceSelection[0];
                }
                return null;
            }
        }

        public virtual void OnSelectedInvoiceChanged()
        {
            this.RaiseCanExecuteChanged(x => x.CanShowInvoice(SelectedInvoice));
        }

        public virtual bool CanShowInvoice(Invoice invoice)
        {
            return !IsLoading && SelectedInvoice != null;
        }

        public virtual void ShowInvoice(Invoice invoice)
        {
            if (invoice != null)
            {
                BaseViewModel model;
                if (invoice.OutGoing)
                {
                    model = OutgoingInvoiceEditViewModel.Create(invoice);
                }
                else
                {
                    model = IncomingInvoiceEditViewModel.Create(invoice);
                }
                model.SetParentViewModel(this);
                ShowDocument(model);
            }
        }
    }
}
