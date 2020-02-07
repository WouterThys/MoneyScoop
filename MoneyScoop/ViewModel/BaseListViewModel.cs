using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public abstract class BaseListViewModel<TEntity> : BaseDocumentViewModel, IBaseListViewModel<TEntity>, IDataChanged<TEntity> where TEntity : IBaseObject, new()
    {
        // Variables for entity
        public virtual IModuleType EditModule { get; }
        public virtual BindingList<TEntity> Entities { get; set; }
        public virtual List<TEntity> Selection { get; set; }

        protected BaseListViewModel(IModuleType module, IModuleType editModule) : base(module)
        {
            EditModule = editModule;
        }

        public abstract IBaseViewModel GetEditViewModel(TEntity baseObject);
        public abstract IEnumerable<TEntity> Source();

        #region LIST MODEL
        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((dispatcher) =>
            {
                List<TEntity> results = null;
                try
                {
                    results = new List<TEntity>(Source());
                    OnLoading();
                }
                catch (Exception e)
                {
                    MessageBoxService.ShowMessage("Failed to load: " + e, "Error", MessageButton.OK, MessageIcon.Error);
                    results = null;
                    IsLoading = false;
                }

                if (results != null)
                {
                    // Update on UI thread
                    ((IDispatcherService)dispatcher).BeginInvoke(() =>
                    {
                        DataChangedService.AddListener(this);
                        Entities = new BindingList<TEntity>(results);
                        OnLoaded();
                    });
                }

            }, DispatcherService);
        }

        public override void OnLoading()
        {

        }

        public override void OnLoaded()
        {
            IsLoading = false;
            UpdateCommands();
        }

        public virtual void OnSelectionChanged()
        {
            if (IsLoading) return;
            UpdateCommands();
        }

        public virtual TEntity Selected
        {
            get
            {
                if (Selection != null && Selection.Count > 0)
                {
                    return Selection[0];
                }
                return default(TEntity);
            }
        }

        public virtual void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.Edit(Selected));
            this.RaiseCanExecuteChanged(x => x.Delete(Selection));
            this.RaiseCanExecuteChanged(x => x.Copy(Selected));
        }

        #endregion

        protected virtual TEntity CreateNewObject()
        {
            TEntity t = new TEntity(); // Default

            return t;
        }
        
        #region COMMANDS
        public virtual bool CanAdd()
        {
            return !IsLoading;
        }

        public virtual void Add()
        {
            TEntity newEntity = CreateNewObject();
            IBaseViewModel model = GetEditViewModel(newEntity);
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

        public virtual bool CanEdit(TEntity entity)
        {
            return !IsLoading && entity != null && !entity.IsUnknown();
        }

        public virtual void Edit(TEntity entity)
        {
            IBaseViewModel model = GetEditViewModel(entity);
            if (model != null)
            {
                model.SetParentViewModel(this);
                ShowDocument(model);
            }
        }

        public virtual bool CanCopy(TEntity entity)
        {
            return !IsLoading && entity != null && !entity.IsUnknown();
        }

        public virtual void Copy(TEntity obj)
        {
            TEntity newObj = (TEntity)obj.CreateCopy();
            newObj.Code = "";
            newObj.Id = -1;
            Edit(newObj);
        }


        public virtual bool CanDelete(IList<TEntity> objs)
        {
            if (!IsLoading && objs != null && objs.Count > 0)
            {
                    if (objs.Count == 1)
                    {
                        return !objs[0].IsUnknown() && objs[0].CanBeDeleted;
                    }
                    return true;
            }
            return false;
        }

        public virtual void Delete(IList<TEntity> objs)
        {
            if (objs != null)
            {
                if (objs.Count == 1)
                {
                    DoDelete(objs.OfType<TEntity>().FirstOrDefault());
                }
                else
                {
                    DoDelete(objs);
                }
            }
        }

        protected virtual void DoDelete(TEntity obj)
        {
            string msg = "Are you sure you want to delete " + obj.ToString() + "?";
            if (MessageBoxService.ShowMessage(msg,
                "Delete",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                if (obj.CanBeDeleted)
                {
                    obj.Delete();
                }
            }
        }

        protected virtual void DoDelete(ICollection<TEntity> objs)
        {
            string msg = "Are you sure you want to delete " + objs.Count + "?";
            if (MessageBoxService.ShowMessage(msg,
                "Delete",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                foreach (TEntity obj in objs)
                {
                    if (obj.CanBeDeleted)
                    {
                        obj.Delete();
                    }
                }
            }
        }
        

        public virtual void KeyPressed(KeyEventArgs keyEvent)
        {
            if (keyEvent == null) return;

            // Delete
            if (keyEvent.KeyCode == Keys.Delete)
            {
                Delete(Selection);
                keyEvent.Handled = true;
                return;
            }

            // Copy
            if (keyEvent.Control && keyEvent.KeyCode == Keys.C)
            {
                Copy(Selected);
                keyEvent.Handled = true;
                return;
            }
        }

        #endregion

        #region DOCUMENT
        public override void OnClose(CancelEventArgs e)
        {
            if (!e.Cancel && DocumentOwner != null)
            {
                DataChangedService.RemoveListener(this);
                DocumentOwner.Close(this, true);
            }
        }
        #endregion

        #region DATA CHANGED
        protected virtual void Inserted(TEntity inserted)
        {
            Entities.Add(inserted);
        }

        protected virtual void Updated(TEntity updated)
        {
            int ndx = Entities.IndexOf(updated);
            if (ndx >= 0)
            {
                Entities[ndx].CopyFrom(updated);
            }
        }

        protected virtual void Deleted(TEntity deleted)
        {
            Entities.Remove(deleted);
        }

        void IDataChanged<TEntity>.OnInserted(TEntity inserted)
        {
            DispatcherService.BeginInvoke(() => Inserted(inserted));
        }

        void IDataChanged<TEntity>.OnUpdated(TEntity updated)
        {
            DispatcherService.BeginInvoke(() => Updated(updated));
        }

        void IDataChanged<TEntity>.OnDeleted(TEntity deleted)
        {
            DispatcherService.BeginInvoke(() => Deleted(deleted));
        }


        #endregion

    }
}
