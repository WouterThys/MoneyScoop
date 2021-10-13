using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel.LogItems
{
    [POCOViewModel]
    public class LogItemDetailsViewModel : BaseDetailsViewModel<LogItem>
    {
        public static LogItemDetailsViewModel Create()
        {
            return ViewModelSource.Create(() => new LogItemDetailsViewModel());
        }
        protected LogItemDetailsViewModel() : base(ModuleTypes.LogItemDetailsModule)
        {

        }

        public virtual bool CanShowInvoice()
        {
            return !IsLoading && Entity != null && Entity.Invoice != null;
        }

        public virtual void ShowInvoice()
        {
            Invoice invoice = Entity.Invoice;
            if (invoice != null)
            {
                BaseViewModel model;
                if (invoice.OutGoing)
                {
                    model = OutgoingInvoiceEditViewModel.Create(invoice);
                }
                else
                {
                    model = IncomingInvoiceEditViewModel.Create(invoice);
                }
                model.SetParentViewModel(this);
                ShowDocument(model);
            }
        }

    }
}
