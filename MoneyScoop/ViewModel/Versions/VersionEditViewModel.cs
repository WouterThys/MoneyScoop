using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;

namespace MoneyScoop.ViewModel.Versions
{
    [POCOViewModel]
    public class VersionEditViewModel : BaseEditViewModel<Version>
    {
        public static VersionEditViewModel Create(Version original)
        {
            return ViewModelSource.Create(() => new VersionEditViewModel(original));
        }

        protected VersionEditViewModel(Version original) : base(ModuleTypes.VersionEditModule, original)
        {
            Load();
        }
    }
}
