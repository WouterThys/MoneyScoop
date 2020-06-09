using DevExpress.XtraReports.UI;

namespace MoneyScoop.Reports
{
    public partial class InvoiceReport2 : XtraReport
    {
        public InvoiceReport2()
        {
            InitializeComponent();
        }

        
        public void ShowVATShifted(bool show)
        {
            xrLabelVATShifted.Visible = show;
        }
    }
}
