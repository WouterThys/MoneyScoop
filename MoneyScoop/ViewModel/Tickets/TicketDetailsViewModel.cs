using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel.Tickets
{
    [POCOViewModel]
    public class TicketDetailsViewModel : BaseDetailsViewModel<Ticket>
    {
        public static TicketDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new TicketDetailsViewModel());
        }

        protected TicketDetailsViewModel() : base(ModuleTypes.TicketDetailsModule)
        {

        }
    }
}
