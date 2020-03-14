using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class InvoiceLineEditViewModel : BaseEditViewModel<InvoiceLine>
    {
        public static InvoiceLineEditViewModel Create(InvoiceLine original)
        {
            return ViewModelSource.Create(() => new InvoiceLineEditViewModel(original));
        }

        protected InvoiceLineEditViewModel(InvoiceLine original) : base(ModuleTypes.InvoiceLineEditModule, original)
        {
            Load();
            CheckExists = false;
        }
    }
}
