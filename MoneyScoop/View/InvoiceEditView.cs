using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using System.Collections.Generic;
using System.Linq;

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
            ViewHelpers.InitializeGridView(gvInvoiceLines);

            ViewHelpers.SetTextAlignment(CustomerIdSearchLookUpEdit, VATTextEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<Invoice, InvoiceEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
                fluent.SetObjectDataSourceBinding(bsInvoiceLines, m => m.InvoiceLines, m => m.UpdateCommands());

                fluent.BindCommand(bbiAddLine, m => m.AddLine());
                fluent.BindCommand(bbiEditLine, m => m.EditLine());
                fluent.BindCommand(bbiDeleteLine, m => m.DeleteLines());

                fluent.BindCommand(bbiPreview, m => m.ShowInvoicePreview());
                fluent.BindCommand(bbiSavePdf, m => m.SavePdfReport());
                fluent.BindCommand(bbiMailToCustomer, m => m.SendMailToCustomer());

                fluent.SetTrigger(m => m.Editable.VATShifted, (shifted) => VATTextEdit.Enabled = !shifted);

                // GridView - Row double clicked
                fluent.WithEvent<RowClickEventArgs>(gvInvoiceLines, "RowClick").EventToCommand(
                        m => m.EditLine(),
                        args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));

                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvInvoiceLines, "SelectionChanged").SetBinding(
                    m => m.SelectedLines,
                    arg => new List<InvoiceLine>(gvInvoiceLines.GetSelectedRows().Select(r => gvInvoiceLines.GetRow(r) as InvoiceLine)));
            }
        }
    }
}
