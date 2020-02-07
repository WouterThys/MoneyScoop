using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class InvoiceEditViewModel : BaseEditViewModel<Invoice>
    {
        public static InvoiceEditViewModel Create(Invoice original)
        {
            return ViewModelSource.Create(() => new InvoiceEditViewModel(original));
        }

        protected InvoiceEditViewModel(Invoice original) : base(ModuleTypes.InvoiceEditModule, original)
        {
            Load();
        }
    }
}
