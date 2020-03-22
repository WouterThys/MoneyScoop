using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;

namespace MoneyScoop.ViewModel.Invoices
{
    [POCOViewModel]
    public class IncomingInvoiceDetailsViewModel : BaseDetailsViewModel<Invoice>
    {
        public static IncomingInvoiceDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new IncomingInvoiceDetailsViewModel());
        }

        public virtual BindingList<InvoiceLine> InvoiceLines { get; set; }

        protected IncomingInvoiceDetailsViewModel() : base(ModuleTypes.IncomingInvoiceDetailsModule)
        {
        }

        private List<InvoiceLine> tempLines;
        public override void OnLoading()
        {
            base.OnLoading();
            tempLines = Entity != null ? new List<InvoiceLine>(Entity.InvoiceLines) : new List<InvoiceLine>();
        }

        public override void OnLoaded()
        {
            InvoiceLines = new BindingList<InvoiceLine>(tempLines);
            base.OnLoaded();
        }
    }
}
