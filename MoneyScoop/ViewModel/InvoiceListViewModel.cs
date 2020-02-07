using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class InvoiceListViewModel : BaseListViewModel<Invoice>
    {
        public static InvoiceListViewModel Create()
        {
            return ViewModelSource.Create(() => new InvoiceListViewModel());
        }

        public InvoiceListViewModel() : base(ModuleTypes.InvoiceListModule, ModuleTypes.InvoiceEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Invoice baseObject)
        {
            return InvoiceEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Invoice> Source()
        {
            return DataSource.Ds.Invoices;
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
            this.RaiseCanExecuteChanged(x => x.ShowCustomers());
        }

        public virtual bool CanShowCustomers()
        {
            return !IsLoading;
        }

        public virtual void ShowCustomers()
        {
            CustomerListViewModel model = CustomerListViewModel.Create();
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

    }
}
