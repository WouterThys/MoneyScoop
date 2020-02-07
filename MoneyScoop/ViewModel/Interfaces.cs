using DevExpress.Mvvm;
using MoneyScoop.Model;
using MoneyScoop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    public interface IModuleType
    {
        string ViewName { get; }
        string ViewTitle { get; }
        ObjectDefinition ObjectDefinition { get; }
        long Id { get; }
        Guid GetGuid(long id);
        int ImageId { get; }
    }

    public interface IBaseViewModel
    {
        IModuleType Module { get; }
        Guid Guid { get; }
        string ViewTitle { get; }

        bool IsLoading { get; set; }
        Task Load();
        void OnLoading();   // Happens on Task Thread
        void OnLoaded();    // Happens on UI Thread

        IMessageBoxService MessageBoxService { get; }
        IDialogService DialogService { get; }
        IDispatcherService DispatcherService { get; }
        IDataChangedService DataChangedService { get; }
    }

    public interface IDocumentViewModel : IDocumentContent
    {
        IDocument ShowDocument(IModuleType moduleType);
        IDocument ShowDocument(IBaseViewModel viewModel);
    }

    public interface IBaseListViewModel<TEntity> : IBaseViewModel
        where TEntity : IBaseObject, new()
    {
        IModuleType EditModule { get; }
        BindingList<TEntity> Entities { get; set; }
        List<TEntity> Selection { get; set; }

        void OnSelectionChanged();
        void UpdateCommands();
        IBaseViewModel GetEditViewModel(TEntity baseObject);
        IEnumerable<TEntity> Source();

        bool CanAdd();
        void Add();

        bool CanEdit(TEntity entity);
        void Edit(TEntity entity);

        bool CanDelete(IList<TEntity> entity);
        void Delete(IList<TEntity> entities);

        bool CanCopy(TEntity entity);
        void Copy(TEntity entity);
        
    }

    public interface IBaseEditViewModel<TEntity> : IBaseViewModel
        where TEntity : class, IBaseObject
    {
        TEntity Original { get; }
        TEntity Editable { get; }
        bool IsSaving { get; } // You have saved, waiting for server to call back
        bool IsUpdating { get; } // External service is updating this object

        void UpdateCommands();

        bool CanEditCode();
        bool CanClose();

        bool CanSave();
        void Save();

        bool CanSaveAndDone();
        void SaveAndDone();

        bool CanReset();
        void Reset();

        bool CanDelete();
        void Delete();

        bool CanCopy();
        void Copy();
    }
}
