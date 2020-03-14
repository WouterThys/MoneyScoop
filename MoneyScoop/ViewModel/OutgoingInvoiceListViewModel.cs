using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraReports.UI;
using MoneyScoop.Model;
using MoneyScoop.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class OutgoingInvoiceListViewModel : BaseListViewModel<Invoice>
    {
        public static OutgoingInvoiceListViewModel Create()
        {
            return ViewModelSource.Create(() => new OutgoingInvoiceListViewModel());
        }

        public OutgoingInvoiceListViewModel() : base(ModuleTypes.OutgoingInvoiceListModule, ModuleTypes.OutgoingInvoiceEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Invoice baseObject)
        {
            return IncomingInvoiceEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Invoice> Source()
        {
            return DataSource.Ds.Invoices.Where(i => i.OutGoing);
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
        }

        
    }
}
