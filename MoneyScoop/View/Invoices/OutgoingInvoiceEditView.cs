using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;

namespace MoneyScoop.View
{
    public partial class OutgoingInvoiceEditView : BaseEditView
    {
        public OutgoingInvoiceEditView()
        {
            InitializeModel(typeof(OutgoingInvoiceEditViewModel));
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
            ViewHelpers.SetTextAlignment(CustomerIdSearchLookUpEdit, TotalTextEdit);

            PdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<Invoice, OutgoingInvoiceEditViewModel>();

                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
                fluent.SetBinding(PdfViewer, pdf => pdf.DocumentFilePath, m => m.Editable.SavePath);
            }
        }
    }
}
