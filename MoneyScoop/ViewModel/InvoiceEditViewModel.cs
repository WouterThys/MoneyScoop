using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class InvoiceEditViewModel : BaseEditViewModel<Invoice>, IDataChanged<Customer>, IDataChanged<InvoiceLine>
    {
        public static InvoiceEditViewModel Create(Invoice original)
        {
            return ViewModelSource.Create(() => new InvoiceEditViewModel(original));
        }

        public virtual BindingList<Customer> Customers { get; set; }
        public virtual BindingList<InvoiceLine> InvoiceLines { get; set; }

        public virtual List<InvoiceLine> SelectedLines { get; set; }

        protected InvoiceEditViewModel(Invoice original) : base(ModuleTypes.InvoiceEditModule, original)
        {
            Load();
        }

        protected List<Customer> tmpCustomers;
        protected List<InvoiceLine> tmpInvoiceLines;
        public override void OnLoading()
        {
            base.OnLoading();
            tmpCustomers = new List<Customer>(DataSource.Ds.Customers);
            tmpInvoiceLines = new List<InvoiceLine>(Editable.InvoiceLines ?? new List<InvoiceLine>());
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers ?? new List<Customer>());
            InvoiceLines = new BindingList<InvoiceLine>(tmpInvoiceLines ?? new List<InvoiceLine>());

            DataChangedService.AddListener((IDataChanged<Customer>)this);
            DataChangedService.AddListener((IDataChanged<InvoiceLine>)this);

            base.OnLoaded();
        }

        protected override void RemoveDataChangedListeners()
        {
            base.RemoveDataChangedListeners();
            DataChangedService.RemoveListener((IDataChanged<Customer>)this);
            DataChangedService.RemoveListener((IDataChanged<InvoiceLine>)this);
        }
        


        public override void UpdateCommands()
        {
            base.UpdateCommands();

            OnSelectedLinesChanged();

            this.RaiseCanExecuteChanged(x => x.ShowInvoicePreview());
            this.RaiseCanExecuteChanged(x => x.SavePdfReport());
            this.RaiseCanExecuteChanged(x => x.SendMailToCustomer());
        }

        public virtual bool CanShowInvoicePreview()
        {
            return !IsLoading && Editable != null && Editable.Id > 0;
        }

        public virtual void ShowInvoicePreview()
        {
            try
            {
                InvoiceActionHelper.ShowPreview(Editable);
            }
            catch (Exception e)
            {
                MessageBoxService.Show("Preview error: \n" + e.Message, "Error", MessageButton.OK, MessageIcon.Error, MessageResult.OK);
            }
        }




        public virtual bool CanSavePdfReport()
        {
            return !IsLoading && Editable != null && Editable.Id > 0;
        }

        public virtual void SavePdfReport()
        {
                try
                {
                    InvoiceActionHelper.SaveToPdf(Editable);
                }
                catch (Exception e)
                {
                    MessageBoxService.Show("Error while saving: \n" + e.Message, "Error", MessageButton.OK, MessageIcon.Error, MessageResult.OK);
                }
        }


        public virtual bool CanSendMailToCustomer()
        {
            return !IsLoading && Editable != null && Editable.Id > 0 && Editable.Customer != null && !string.IsNullOrEmpty(Editable.Customer.Email);
        }

        public virtual void SendMailToCustomer()
        {

        }

        #region Invoice Lines

        public virtual void OnSelectedLinesChanged()
        {
            this.RaiseCanExecuteChanged(x => x.AddLine());
            this.RaiseCanExecuteChanged(x => x.EditLine());
            this.RaiseCanExecuteChanged(x => x.DeleteLines());
        }

        public virtual bool CanAddLine()
        {
            return !IsLoading && Editable != null && Editable.Id > BaseObject.UNKNOWN_ID;
        }

        public virtual bool CanEditLine()
        {
            return !IsLoading && Editable != null && Editable.Id > BaseObject.UNKNOWN_ID && SelectedLines != null && SelectedLines.Count > 0;
        }

        public virtual bool CanDeleteLine()
        {
            return !IsLoading && Editable != null && Editable.Id > BaseObject.UNKNOWN_ID && SelectedLines != null && SelectedLines.Count > 0;
        }

        public virtual void AddLine()
        {
            InvoiceLine line = new InvoiceLine(Editable);
            InvoiceLineEditViewModel model = InvoiceLineEditViewModel.Create(line);
            model.SetParentViewModel(this);
            ShowDocument(model);
        }

        public virtual void EditLine()
        {
            InvoiceLine line = SelectedLines?.First();
            if (line != null)
            {
                InvoiceLineEditViewModel model = InvoiceLineEditViewModel.Create(line);
                model.SetParentViewModel(this);
                ShowDocument(model);
            }
        }

        public virtual void DeleteLines()
        {
            List<InvoiceLine> lines = new List<InvoiceLine>(SelectedLines);
            foreach (InvoiceLine line in lines)
            {
                line.Delete();
            }
        }


        #endregion

        #region Customers changed

        void IDataChanged<Customer>.OnInserted(Customer inserted)
        {
            if (Customers != null)
            {
                Customers.Add(inserted);
            }
        }

        void IDataChanged<Customer>.OnUpdated(Customer updated)
        {
            if (Customers != null)
            {
                int ndx = Customers.IndexOf(updated);
                if (ndx >= 0)
                {
                    Customers[ndx].CopyFrom(updated);
                }
            }
        }

        void IDataChanged<Customer>.OnDeleted(Customer deleted)
        {
            if (Customers != null)
            {
                Customers.Remove(deleted);
            }
        }

        #endregion

        #region InvoiceLines changed

        void IDataChanged<InvoiceLine>.OnInserted(InvoiceLine inserted)
        {
            if (InvoiceLines != null)
            {
                InvoiceLines.Add(inserted);
            }
        }

        void IDataChanged<InvoiceLine>.OnUpdated(InvoiceLine updated)
        {
            if (InvoiceLines != null)
            {
                int ndx = InvoiceLines.IndexOf(updated);
                if (ndx >= 0)
                {
                    InvoiceLines[ndx].CopyFrom(updated);
                }
            }
        }

        void IDataChanged<InvoiceLine>.OnDeleted(InvoiceLine deleted)
        {
            if (InvoiceLines != null)
            {
                InvoiceLines.Remove(deleted);
                SelectedLines = null;
            }
        }

        #endregion
    }
}
