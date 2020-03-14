using DevExpress.XtraReports.UI;

namespace MoneyScoop.Reports
{
    public partial class InvoiceReport : XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }

        
        public void ShowVATShifted(bool show)
        {
            xrLabelVATShifted.Visible = show;
        }
    }
}
