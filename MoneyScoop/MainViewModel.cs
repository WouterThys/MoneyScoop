﻿using Database;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using MoneyScoop.ViewModel;
using System;
using System.Threading.Tasks;


namespace MoneyScoop
{
    [POCOViewModel()]
    public class MainViewModel : BaseDocumentViewModel, IDataInvoker, IDatabaseAccess
    {
        public virtual IModuleType ActiveModule { get; set; }

        protected MainViewModel() : base(ModuleTypes.MainViewModule)
        {
            
        }

        public override Task Load()
        {
            IsLoading = true;
            Context.Ctx.Initialize(this);
            DataSource.Ds.AttachInvoker(this);
            DataSource.Ds.AttachListener(DataChangedService);
            Start();
            IsLoading = false;

            return Task.Factory.StartNew((dispatcher) =>
            {
                
            }, DispatcherService);
        }

        public override void OnLoading() { }
        public override void OnLoaded() { }
        
        public void Start()
        {
            IsLoading = true;
            DocumentManagerService.ActiveDocumentChanged += DocumentManagerService_ActiveDocumentChanged;
            //if (InvoiceListViewModel == null)
            //{
            //    InvoiceListViewModel = InvoiceListViewModel.Create();
            //    InvoiceListViewModel.SetParentViewModel(this);
            //}
            //InvoiceListViewModel.Load();
            //ShowDocument(InvoiceListViewModel);
            ShowDocument(ModuleTypes.IncomingInvoiceListModule);
            IsLoading = false;
        }

        private void DocumentManagerService_ActiveDocumentChanged(object sender, ActiveDocumentChangedEventArgs e)
        {
            if (e.NewDocument == null)
            {
                ActiveModule = null;
            }
            else if (e.NewDocument.Content is IBaseViewModel viewModel)
            {
                ActiveModule = viewModel.Module;
            }
        }

        public void OnActiveModuleChanged()
        {
            if (ActiveModule != null)
            {
                ShowDocument(ActiveModule);
            }
        }


        #region Data Invoker

        public void InvokeOnMain(Action action)
        {
            DispatcherService.BeginInvoke(action);
        }

        #endregion

        #region Database Access
        public void DbLogBackState(DbState dbState)
        {
            
        }

        public void DbQueryFailed(DbException dbException)
        {
            MessageBoxService.ShowMessage("Database error. \r\n" + dbException, "Error", MessageButton.OK, MessageIcon.Error);
        }

        public void DbLogInfo(string message)
        {
            
        }
        #endregion
    }
}
