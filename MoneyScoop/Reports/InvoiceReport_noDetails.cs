using DevExpress.XtraReports.UI;

namespace MoneyScoop.Reports
{
    public partial class InvoiceReport_noDetails : BaseReport
    {
        public InvoiceReport_noDetails()
        {
            InitializeComponent();
        }

        
        public override void ShowVATShifted(bool show)
        {
            xrLabelVATShifted.Visible = show;
        }
    }
}
