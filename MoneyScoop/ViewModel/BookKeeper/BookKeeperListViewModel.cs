using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel.BookKeeper
{
    [POCOViewModel]
    public class BookKeeperListViewModel : BaseDocumentViewModel, IDataChanged<Invoice>
    {
        public static BookKeeperListViewModel Create()
        {
            return ViewModelSource.Create(() => new BookKeeperListViewModel());
        }

        public virtual Model.BookKeeper BookKeeper { get; protected set; }
        public virtual BindingList<Invoice> Invoices { get; set; }
        public virtual List<Invoice> Selection { get; set; }

        public BookKeeperListViewModel() : base(ModuleTypes.BookKeeperListModule)
        {

        }

        #region Loading
        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((disp) => 
            {
                List<Invoice> invoices = new List<Invoice>(DataSource.Ds.Invoices.Where(i => i.IsSaved));
                
                ((IDispatcherService)disp).BeginInvoke(() => 
                {
                    Invoices = new BindingList<Invoice>(invoices);
                    BookKeeper = Context.Ctx.BookKeeper;
                    IsLoading = false;
                });
            }, DispatcherService);
        }

        public override void OnLoading() { }
        public override void OnLoaded() { }

        public virtual void OnSelectionChanged()
        {
            if (IsLoading) return;
            UpdateCommands();
        }

        public virtual Invoice Selected
        {
            get
            {
                if (Selection != null && Selection.Count > 0)
                {
                    return Selection[0];
                }
                return null;
            }
        }

        #endregion

        #region Commands

        public virtual void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.ShowOverview());
            this.RaiseCanExecuteChanged(x => x.ShowInvoice(Selected));
        }


        public virtual bool CanShowInvoice(Invoice invoice)
        {
            return !IsLoading && invoice != null;
        }

        public virtual void ShowInvoice(Invoice invoice)
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


        public virtual bool CanShowOverview()
        {
            return !IsLoading;
        }

        public virtual void ShowOverview()
        {
            BookKeeperOverviewModel model = BookKeeperOverviewModel.Create();
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

        #endregion

        #region Invoice Changed
        protected virtual void Inserted(Invoice inserted)
        {
            Invoices.Add(inserted);
        }

        protected virtual void Updated(Invoice updated)
        {
            int ndx = Invoices.IndexOf(updated);
            if (ndx >= 0)
            {
                Invoices[ndx].CopyFrom(updated);
            }
        }

        protected virtual void Deleted(Invoice deleted)
        {
            Invoices.Remove(deleted);
        }

        void IDataChanged<Invoice>.OnInserted(Invoice inserted)
        {
            DispatcherService.BeginInvoke(() => Inserted(inserted));
        }

        void IDataChanged<Invoice>.OnUpdated(Invoice updated)
        {
            DispatcherService.BeginInvoke(() => Updated(updated));
        }

        void IDataChanged<Invoice>.OnDeleted(Invoice deleted)
        {
            DispatcherService.BeginInvoke(() => Deleted(deleted));
        }
        #endregion
    }
}
