using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class IncomingInvoiceLineEditViewModel : BaseEditViewModel<InvoiceLine>
    {
        public static IncomingInvoiceLineEditViewModel Create(InvoiceLine original)
        {
            return ViewModelSource.Create(() => new IncomingInvoiceLineEditViewModel(original));
        }

        protected IncomingInvoiceLineEditViewModel(InvoiceLine original) : base(ModuleTypes.InvoiceLineEditModule, original)
        {
            Load();
            CheckExists = false;
        }
    }
}
