using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel.Versions
{
    [POCOViewModel]
    public class VersionDetailsViewModel : BaseDetailsViewModel<Version>
    {
        public static VersionDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new VersionDetailsViewModel());
        }

        protected VersionDetailsViewModel() : base(ModuleTypes.VersionDetailsModule)
        {

        }
    }
}
