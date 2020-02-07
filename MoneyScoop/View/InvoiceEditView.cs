using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;
using DevExpress.XtraLayout.Utils;

namespace MoneyScoop.View
{
    public partial class InvoiceEditView : BaseEditView
    {
        public InvoiceEditView()
        {
            InitializeModel(typeof(InvoiceEditViewModel));
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLayouts();
                InitializeServices();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ViewHelpers.InitializeSearchLookUpEdit(CustomerIdSearchLookUpEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<Invoice, InvoiceEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
            }
        }
    }
}
