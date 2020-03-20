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
    public class OutgoingInvoiceEditViewModel : BaseEditViewModel<Invoice>, IDataChanged<Customer>
    {
        public static OutgoingInvoiceEditViewModel Create(Invoice original)
        {
            return ViewModelSource.Create(() => new OutgoingInvoiceEditViewModel(original));
        }

        public virtual BindingList<Customer> Customers { get; set; }

        protected OutgoingInvoiceEditViewModel(Invoice original) : base(ModuleTypes.OutgoingInvoiceEditModule, original)
        {
            Load();
        }

        protected List<Customer> tmpCustomers;
        public override void OnLoading()
        {
            base.OnLoading();
            tmpCustomers = new List<Customer>(DataSource.Ds.Customers);
        }

        public override void OnLoaded()
        {
            Customers = new BindingList<Customer>(tmpCustomers ?? new List<Customer>());

            DataChangedService.AddListener((IDataChanged<Customer>)this);

            base.OnLoaded();
        }

        protected override void RemoveDataChangedListeners()
        {
            base.RemoveDataChangedListeners();
            DataChangedService.RemoveListener((IDataChanged<Customer>)this);
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
        }

        public override bool CanSave()
        {
            return (Editable != null && Editable.Id < 0) || base.CanSave();
        }


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
    }
}
