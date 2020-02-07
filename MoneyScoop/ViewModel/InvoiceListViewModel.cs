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

    }
}
