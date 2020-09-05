using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel.Projects
{
    [POCOViewModel]
    public class ProjectDetailsViewModel : BaseDetailsViewModel<Project>
    {
        public static ProjectDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new ProjectDetailsViewModel());
        }

        protected ProjectDetailsViewModel() : base(ModuleTypes.ProjectDetailsModule)
        {

        }
    }
}
