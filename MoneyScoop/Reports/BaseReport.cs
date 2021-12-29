using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.Reports
{
    public class BaseReport : XtraReport
    {
        public virtual void ShowVATShifted(bool show) { }
    }
}
