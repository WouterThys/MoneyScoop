using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel.Projects
{
    [POCOViewModel]
    public class ProjectEditViewModel : BaseEditViewModel<Project>
    {
        public static ProjectEditViewModel Create(Project original)
        {
            return ViewModelSource.Create(() => new ProjectEditViewModel(original));
        }

        protected ProjectEditViewModel(Project original) : base(ModuleTypes.ProjectEditModule, original)
        {
            Load();
        }
    }
}
