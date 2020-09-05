using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel.Tickets
{
    [POCOViewModel]
    public class TicketEditViewModel : BaseEditViewModel<Ticket>
    {
        public static TicketEditViewModel Create(Ticket original)
        {
            return ViewModelSource.Create(() => new TicketEditViewModel(original));
        }

        protected TicketEditViewModel(Ticket original) : base(ModuleTypes.TicketEditModule, original)
        {
            Load();
        }
    }
}
