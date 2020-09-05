using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;

namespace MoneyScoop.ViewModel. Versions
{
    [POCOViewModel]
    public class  VersionListViewModel : BaseListViewModel< Version>
    {
        public static  VersionListViewModel Create()
        {
            return ViewModelSource.Create(() => new  VersionListViewModel());
        }

        public virtual  VersionDetailsViewModel DetailModel { get; protected set; }

        public  VersionListViewModel() : base(ModuleTypes. VersionListModule)
        {
            DetailModel =  VersionDetailsViewModel.Create();
            DetailModel.SetParentViewModel(this);
        }

        public override IBaseViewModel GetEditViewModel( Version baseObject)
        {
            return  VersionEditViewModel.Create(baseObject);
        }

        public override IEnumerable< Version> Source()
        {
            return DataSource.Ds. Versions;
        }

        public override void OnSelectionChanged()
        {
            base.OnSelectionChanged();
            DetailModel.Entity = Selected;
        }
    }
}
