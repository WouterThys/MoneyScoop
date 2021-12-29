using DevExpress.XtraReports.UI;

namespace MoneyScoop.Reports
{
    public partial class InvoiceReport_wDetails : BaseReport
    {
        public InvoiceReport_wDetails()
        {
            InitializeComponent();
        }

        
        public override void ShowVATShifted(bool show)
        {
            xrLabelVATShifted.Visible = show;
        }
    }
}
