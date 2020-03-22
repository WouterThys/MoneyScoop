using MoneyScoop.ViewModel;
using MoneyScoop.Utils;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.Model;
using DevExpress.Data;
using System.Collections.Generic;
using System.Linq;

namespace MoneyScoop.View.Customers
{
    public partial class CustomerDetailView : BaseUserControl
    {
        public CustomerDetailView()
        {
            InitializeModel(typeof(CustomerDetialsViewModel));
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ViewHelpers.InitializeGridView(gvInvoices);
        }

        public void InitializeBindings(CustomerDetialsViewModel model)
        {
            if (!DesignMode)
            {
                InitializeModel(typeof(CustomerDetialsViewModel), model);
                var fluent = mvvmContext.OfType<CustomerDetialsViewModel>();

                fluent.SetObjectDataSourceBinding(bsInvoices, m => m.Invoices);
                fluent.SetObjectDataSourceBinding(bsCustomer, m => m.Entity);

                fluent.SetBinding(TitelLabel, lbl => lbl.Text, m => m.Entity.Code);

                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvInvoices, "SelectionChanged").SetBinding(
                    m => m.InvoiceSelection,
                    e => new List<Invoice>(gvInvoices.GetSelectedRows().Select(r => gvInvoices.GetRow(r) as Invoice)));

                // GridView - Row double clicked
                fluent.WithEvent<RowClickEventArgs>(gvInvoices, "RowClick").EventToCommand(
                        m => m.ShowInvoice(null),
                        m => m.SelectedInvoice,
                        args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));

            }
        }
    }
}
