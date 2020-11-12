using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.ViewModel.Tickets;
using System.Collections.Generic;

namespace MoneyScoop.ViewModel.Projects
{
    [POCOViewModel]
    public class ProjectListViewModel : BaseListViewModel<Project>
    {
        public static ProjectListViewModel Create()
        {
            return ViewModelSource.Create(() => new ProjectListViewModel());
        }

        public TicketListViewModel TicketListViewModel { get; set; }

        public virtual ProjectDetailsViewModel DetailModel { get; protected set; }

        public ProjectListViewModel() : base(ModuleTypes.ProjectListModule)
        {
            DetailModel = ProjectDetailsViewModel.Create();
            DetailModel.SetParentViewModel(this);

            TicketListViewModel = TicketListViewModel.Create();
            TicketListViewModel.SetParentViewModel(this);
        }

        public override IBaseViewModel GetEditViewModel(Project baseObject)
        {
            return ProjectEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Project> Source()
        {
            return DataSource.Ds.Projects;
        }

        public override void OnSelectionChanged()
        {
            base.OnSelectionChanged();
            DetailModel.Entity = Selected;
            TicketListViewModel.Project = Selected;
        }
    }
}
