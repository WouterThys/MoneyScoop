using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class BaseDetailsViewModel<TEntity> : BaseDocumentViewModel, IDataChanged<TEntity> where TEntity : IBaseObject
    {
        public virtual TEntity Entity { get; set; }
        public virtual bool ShouldShowDetails { get; set; }

        protected BaseDetailsViewModel(IModuleType moduleType) : base(moduleType)
        {
            
        }

        #region Base

        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((disp) =>
            {
                OnLoading();
                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    OnLoaded();
                });
            }, DispatcherService);
        }

        public override void OnLoading()
        {
            DataChangedService.RemoveListener(this);
            DataChangedService.AddListener(this);
        }

        public override void OnLoaded()
        {
            IsLoading = false;
        }
        
        public virtual void OnEntityChanged()
        {
            Load();
        }

        #endregion

        #region Document

        public override void OnClose(CancelEventArgs e)
        {
            DataChangedService.RemoveListener(this);
            base.OnClose(e);
        }

        #endregion

        #region Data Changed

        void IDataChanged<TEntity>.OnInserted(TEntity inserted)
        {
            
        }

        void IDataChanged<TEntity>.OnUpdated(TEntity updated)
        {

        }

        void IDataChanged<TEntity>.OnDeleted(TEntity deleted)
        {
            
        }

        #endregion
    }
}
