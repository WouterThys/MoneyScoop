using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class CustomerListViewModel : BaseListViewModel<Customer>
    {
        public static CustomerListViewModel Create()
        {
            return ViewModelSource.Create(() => new CustomerListViewModel());
        }

        public virtual CustomerDetialsViewModel DetailModel { get; protected set; }

        public CustomerListViewModel() : base(ModuleTypes.CustomerListModule)
        {
            DetailModel = CustomerDetialsViewModel.Create();
            DetailModel.SetParentViewModel(this);
        }

        public override IBaseViewModel GetEditViewModel(Customer baseObject)
        {
            return CustomerEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Customer> Source()
        {
            return DataSource.Ds.Customers;
        }

        public override void OnSelectionChanged()
        {
            base.OnSelectionChanged();
            DetailModel.Entity = Selected;
        }
    }
}
