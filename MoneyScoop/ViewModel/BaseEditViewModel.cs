using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class BaseEditViewModel<TEntity> : BaseDocumentViewModel, IBaseEditViewModel<TEntity>, IDataChanged<TEntity> where TEntity : class, IBaseObject, new()
    {
        protected bool closeOnSave = false;
        public virtual bool IsSaving { get; protected set; }
        public virtual bool IsUpdating { get; protected set; }
        public virtual bool IsLoadingIcon { get; protected set; }
        public virtual bool CheckExists { get; protected set; }

        public virtual TEntity Original { get; protected set; }
        public virtual TEntity Editable { get; protected set; }
        
        // Helper variables
        protected bool propertiesEqual;

        protected BaseEditViewModel(IModuleType moduleType, TEntity original) : base(moduleType)
        {
            Original = original;
            CheckExists = true;
        }

        public override Task Load()
        {
            IsLoading = true;
            if (closeOnSave)
            {
                closeOnSave = false;
                IsSaving = false;
                IsUpdating = false;
                Editable.CopyFrom(Original);
                OnClose(new CancelEventArgs());
                IsLoading = false;
                return null;
            }
            else
            {
                OnLoading();
                OnLoaded();
                return null;
            }
        }

        public override void OnLoading()
        {
            if (Editable == null)
            {
                // Create new
                try
                {
                    Editable = (TEntity)Original.CreateCopy();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("BaseEditViewModel - OnLoading(): " + e);
                }
            }
            else
            {
                // Keep object reference
                Editable.CopyFrom(Original);
            }
            // Icon
            DataChangedService.AddListener(this);
        }

        public override void OnLoaded()
        {
            IsLoading = false;
            IsSaving = false;
            IsUpdating = false;
            UpdateCommands();
        }
        
        public override Guid Guid
        {
            get
            {
                return Module.GetGuid(Original.Id);
            }
        }

        public override string ViewTitle
        {
            get
            {
                if (Original == null || Original.Id < 1)
                {
                    return "Add " + Module.ViewTitle;
                }
                else
                {
                    return "Edit " + Original.Code;
                }
            }
        }

        public virtual void UpdateCommands()
        {
            propertiesEqual = Editable != null && Original.PropertiesEqual(Editable);

            this.RaiseCanExecuteChanged(x => x.Save());
            this.RaiseCanExecuteChanged(x => x.SaveAndDone());
            this.RaiseCanExecuteChanged(x => x.Reset());
            this.RaiseCanExecuteChanged(x => x.Delete());
            this.RaiseCanExecuteChanged(x => x.Copy());
        }

        public virtual string Code
        {
            get { return Editable?.Code; }
            set { Editable.Code = value; }
        }
        public virtual string Description
        {
            get { return Editable?.Description; }
            set { Editable.Description = value; }
        }
        public virtual bool ViewEditable
        {
            get { return Editable != null; }
            set { }
        }

        public bool CanEditCode()
        {
            return Editable != null && Editable.IsValid();
        }

        public virtual bool CanClose()
        {
            return Editable == null || Original.PropertiesEqual(Editable) || Editable.Code.Length < Context.Ctx.MaxObjectCodeLength;
        }
        
        #region DOCUMENT

        public override void OnClose(CancelEventArgs e)
        {
            if (!CanClose())
            {
                string msg = Editable.ToString() + " has unsaved changes, do you want to save first?";
                MessageResult result = MessageBoxService.ShowMessage(msg,
                    "Close",
                    MessageButton.YesNoCancel,
                    MessageIcon.Warning,
                    MessageResult.No);

                if (result == MessageResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == MessageResult.Yes)
                {
                    e.Cancel = true;
                    closeOnSave = true;
                    Save();
                }
            }
            if ((Editable == null) || (Editable.Id < 0) || (!e.Cancel && DocumentOwner != null))
            {
                RemoveDataChangedListeners();
                DocumentOwner.Close(this);
            }
        }

        protected virtual void RemoveDataChangedListeners()
        {
            DataChangedService.RemoveListener(this);
        }

        #endregion

        #region COMMANDS
        public virtual bool CanSave()
        {
            if (IsSaving || IsLoading || IsUpdating) return false;

            if (!propertiesEqual && Editable != null && Editable.Code.Length >= Context.Ctx.MinObjectCodeLength)
            {
                if (Editable.Id > BaseObject.UNKNOWN_ID)
                {
                    return Editable.CanBeEdited;
                }
                else
                {
                    return Editable.CanBeAdded;
                }
            }
            return false;
        }

        public virtual void Save()
        {
            if (Editable.Id <= BaseObject.UNKNOWN_ID && CheckExists && DataSource.Ds.CodeExists<TEntity>(Editable.Code))
            {
                MessageBoxService.ShowMessage("Code " + Editable.Code + " should be unique.", "Already exists", MessageButton.OK);
            }
            else
            {
                IsSaving = true;
                Task.Factory.StartNew((dispatcher) =>
                {
                    try
                    {
                        BeforeSave(Editable);
                        DoSave(Editable);

                    }
                    catch (Exception e)
                    {
                        ((IDispatcherService)dispatcher).BeginInvoke(() =>
                        {
                            MessageBoxService.ShowMessage(e.Message, "Error", MessageButton.OK, MessageIcon.Error);
                            IsSaving = false;
                        });
                    }
                }, DispatcherService);

            }
        }

        protected virtual void DoSave(TEntity entity)
        {
            TEntity toSave = (TEntity)entity.CreateCopy();
            toSave.Save();
        }

        public virtual bool CanSaveAndDone()
        {
            return CanSave();
        }

        public virtual void SaveAndDone()
        {
            closeOnSave = true;
            Save();
        }

        protected virtual void BeforeSave(TEntity entity)
        {

        }

        public virtual bool CanReset()
        {
            if (IsSaving || IsLoading || IsUpdating) return false;
            return !propertiesEqual;
        }

        public virtual void Reset()
        {
            string msg = "Do you want to reset " + Editable.ToString() + "?";
            if (MessageBoxService.ShowMessage(msg,
                "Reset",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                Editable.CopyFrom(Original);
                OnReset();
            }
        }

        public virtual void OnReset()
        {
            Load();
        }


        public virtual bool CanDelete()
        {
            if (IsSaving || IsLoading || IsUpdating) return false;
            return Editable != null && Editable.Id > BaseObject.UNKNOWN_ID && Editable.CanBeDeleted;
        }

        public void Delete()
        {
            string msg = "Are you sure you want to delete " + Editable.ToString() + "?";
            if (MessageBoxService.ShowMessage(msg,
                "Delete",
                MessageButton.YesNo,
                MessageIcon.Question,
                MessageResult.No) == MessageResult.Yes)
            {
                // Is used for other?
                DoDelete();
            }
        }

        protected virtual void DoDelete()
        {
            // Do delete
            IsLoading = true;
            try
            {
                Editable.Delete();
            }
            catch (Exception e)
            {
                MessageBoxService.ShowMessage(e.Message, "Error", MessageButton.OK, MessageIcon.Error);
            }
            finally
            {
                IsLoading = false;
            }
        }

        public virtual bool CanCopy()
        {
            if (IsSaving || IsLoading || IsUpdating) return false;
            return (Editable != null) && Editable.IsValid();
        }

        public virtual void Copy()
        {
            try
            {
                ((IBaseListViewModel<TEntity>)ParentViewModel).Copy(Editable);
            }
            catch (Exception e)
            {
                MessageBoxService.ShowMessage("Failed to create copy" + e, "Error", MessageButton.OK, MessageIcon.Error);
            }
        }

        public virtual void KeyPressed(KeyEventArgs keyEvent)
        {
            if (keyEvent == null) return;

            // Close
            if (keyEvent.KeyCode == Keys.Escape)
            {
                OnClose(new CancelEventArgs());
                keyEvent.Handled = true;
                return;
            }

            // Save
            if (keyEvent.Control && keyEvent.KeyCode == Keys.S)
            {
                Save();
                keyEvent.Handled = true;
                return;
            }

            // Save
            if (keyEvent.KeyCode == Keys.Delete)
            {
                Delete();
                keyEvent.Handled = true;
                return;
            }
        }
        

        #endregion

        #region DATA CHANGED

        protected virtual bool Inserted(TEntity inserted)
        {
            Original = inserted;
            Load();
            return true;
        }

        protected virtual bool Updated(TEntity updated)
        {
            Original = updated;
            Load();
            return true;
        }

        protected virtual bool Deleted(TEntity deleted)
        {
            Editable = null;
            OnClose(new CancelEventArgs());
            return true;
        }

        void IDataChanged<TEntity>.OnInserted(TEntity inserted)
        {
            if (inserted != null && inserted.Code == Editable.Code)
            {
                DispatcherService.BeginInvoke(() => Inserted(inserted));
            }
        }

        void IDataChanged<TEntity>.OnUpdated(TEntity updated)
        {
            if (updated != null && updated.Id == Editable.Id)
            {
                DispatcherService.BeginInvoke(() => Updated(updated));
            }
        }

        void IDataChanged<TEntity>.OnDeleted(TEntity deleted)
        {
            if (deleted != null && deleted.Id == Editable.Id)
            {
                DispatcherService.BeginInvoke(() => Deleted(deleted));
            }
        }

        #endregion
    }
}
