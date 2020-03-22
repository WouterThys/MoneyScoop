using MoneyScoop.ViewModel.Invoices;
using MoneyScoop.Utils;

namespace MoneyScoop.View.Invoices
{
    public partial class OutgoingInvoiceDetailView : BaseUserControl
    {

        public OutgoingInvoiceDetailView()
        {
            InitializeModel(typeof(OutgoingInvoiceDetailsViewModel));
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            PdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
        }

        public void InitialiseBindings(OutgoingInvoiceDetailsViewModel model)
        {
            if (!DesignMode)
            {
                InitializeModel(typeof(OutgoingInvoiceDetailsViewModel), model);
                var fluent = mvvmContext.OfType<OutgoingInvoiceDetailsViewModel>();
                
                fluent.SetObjectDataSourceBinding(bsInvoice, m => m.Entity);

                fluent.SetBinding(CodeLabel, lbl => lbl.Text, m => m.Entity.Code);
                fluent.SetBinding(PdfViewer, pdf => pdf.DocumentFilePath, m => m.Entity.SavePath);

                fluent.SetBinding(CreatedLabel, lbl => lbl.Visible, m => m.Entity.IsPdfSaved);
                fluent.SetBinding(SendLabel, lbl => lbl.Visible, m => m.Entity.IsSend);
                fluent.SetBinding(PayedLabel, lbl => lbl.Visible, m => m.Entity.IsPayed);

                fluent.SetBinding(CreatedLabel, lbl => lbl.ToolTip, m => m.Entity.DateModifiedString);
                fluent.SetBinding(SendLabel, lbl => lbl.ToolTip, m => m.Entity.DateSendString);
                fluent.SetBinding(PayedLabel, lbl => lbl.ToolTip, m => m.Entity.DatePayedString);
            }
        }
    }
}
