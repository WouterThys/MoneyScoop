using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel.Invoices
{
    [POCOViewModel]
    public class OutgoingInvoiceDetailsViewModel : BaseDetailsViewModel<Invoice>
    {
        public static OutgoingInvoiceDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new OutgoingInvoiceDetailsViewModel());
        }

        protected OutgoingInvoiceDetailsViewModel() : base(ModuleTypes.OutgoingInvoiceDetailModule)
        {
            
        }
    }
}
