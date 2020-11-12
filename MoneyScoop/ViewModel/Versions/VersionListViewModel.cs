using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.Linq;

namespace MoneyScoop.ViewModel.Tickets
{
    [POCOViewModel]
    public class TicketListViewModel : BaseListViewModel<Ticket>
    {
        public static TicketListViewModel Create()
        {
            return ViewModelSource.Create(() => new TicketListViewModel());
        }

        public virtual Project Project { get; set; }

        public virtual TicketDetailsViewModel DetailModel { get; protected set; }

        public TicketListViewModel() : base(ModuleTypes.TicketListModule)
        {
            DetailModel = TicketDetailsViewModel.Create();
            DetailModel.SetParentViewModel(this);
        }

        public override IBaseViewModel GetEditViewModel(Ticket baseObject)
        {
            baseObject.ProjectId = Project.Id;
            return TicketEditViewModel.Create(baseObject);
        }

        public virtual void OnProjectChanged()
        {
            Load();
        }

        public override IEnumerable<Ticket> Source()
        {
            if (Project == null)
            {
                return new List<Ticket>();
            } 
            else
            {
                return DataSource.Ds.Tickets.Where(t => t.ProjectId == Project.Id);
            }   
        }

        public override void OnSelectionChanged()
        {
            base.OnSelectionChanged();
            DetailModel.Entity = Selected;
        }

        
    }
}
