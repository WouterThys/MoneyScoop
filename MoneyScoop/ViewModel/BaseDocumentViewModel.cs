﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public abstract class BaseDocumentViewModel : BaseViewModel, IDocumentViewModel
    {
        protected BaseDocumentViewModel(IModuleType module) : base(module)
        {
        }

        public virtual IDocumentManagerService DocumentManagerService { get { throw new NotImplementedException(); } }

        protected IDocument CreateDocument(IBaseViewModel viewModel, IDocumentManagerService service)
        {
            IDocument document = service.CreateDocument(viewModel.Module.ViewName, viewModel);
            string title = viewModel.Module.ViewTitle;
            if (!string.IsNullOrEmpty(viewModel.ViewTitle))
            {
                title = " " + viewModel.ViewTitle;
            }
            if (!string.IsNullOrEmpty(title))
            {
                document.Title = title;
            }
            document.DestroyOnClose = true;
            return document;
        }

        protected virtual IDocument CreateDocument(IModuleType module, IDocumentManagerService service)
        {
            IDocument document = service.CreateDocument(
                module.ViewName,
                module.GetGuid(-1),
                this);
            document.Title = module.ViewTitle;
            document.DestroyOnClose = true;
            return document;
        }

        #region DOCUMENTS
        public IDocument ShowDocument(IBaseViewModel viewModel)
        {
            IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(viewModel.Guid, x => CreateDocument(viewModel, DocumentManagerService));
            document.Show();
            return document;
        }

        public virtual IDocument ShowDocument(IModuleType moduleType)
        {
            IDocument document = DocumentManagerService.FindDocumentByIdOrCreate(moduleType.GetGuid(-1), x => CreateDocument(moduleType, DocumentManagerService));
            document.Show();
            return document;
        }

        public void CloseDocument(IDocument document)
        {
            if (document != null)
            {
                document.Close(true);
            }
        }

        public void CloseAllDocumnets()
        {
            List<IDocument> openDocs = new List<IDocument>(DocumentManagerService.Documents);
            foreach (IDocument doc in openDocs)
            {
                CloseDocument(doc);
            }
        }

        #endregion

        #region DIALOGS
        public void ShowDialog(IBaseViewModel viewModel)
        {
            DialogService.ShowDialog(MessageButton.OKCancel, viewModel.ViewTitle, viewModel.Module.ViewName, viewModel);
        }
        #endregion

        #region DOCUMENT INTERFACE
        public virtual void OnClose(CancelEventArgs e)
        {

        }

        public virtual void OnDestroy()
        {
        }

        public virtual IDocumentOwner DocumentOwner { get; set; }
        public virtual object Title { get { return Module.ViewTitle; } }

        #endregion
    }
}
