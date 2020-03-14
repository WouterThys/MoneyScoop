using DevExpress.XtraReports.UI;
using MoneyScoop.Model;
using MoneyScoop.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    static class InvoiceActionHelper
    {

        public static InvoiceReport CreateReport(Invoice invoice)
        {
            InvoiceReport report = new InvoiceReport
            {
                DataSource = new List<Invoice>() { invoice }
            };
            report.ShowVATShifted(invoice.VATShifted);
            return report;
        }

        public static void ShowPreview(Invoice invoice)
        {
            ReportPrintTool tool = new ReportPrintTool(CreateReport(invoice));
            tool.ShowPreview();
        }

        public static void SaveToPdf(Invoice invoice)
        {
            string file = Path.Combine(Context.Ctx.MyInfo.SavePdfPath, invoice.Code);
            file += ".pdf";

            InvoiceReport report = CreateReport(invoice);
            report.ExportToPdf(file);
            if (File.Exists(file))
            {
                invoice.SavePath = file;
                invoice.Save();
            }
        }
    }
}
