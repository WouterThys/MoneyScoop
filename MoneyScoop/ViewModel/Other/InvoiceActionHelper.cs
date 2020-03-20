using DevExpress.XtraReports.UI;
using MoneyScoop.Model;
using MoneyScoop.Reports;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

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
            string file = Path.Combine(Context.Ctx.SavePdfPath, invoice.Code);
            file += ".pdf";

            InvoiceReport report = CreateReport(invoice);
            report.ExportToPdf(file);
            if (File.Exists(file))
            {
                invoice.SavePath = file;
                invoice.Save();
            }
        }

        public static IEnumerable<string> GetAllOutgoingInvoices()
        {
            return Directory.GetFiles(Context.Ctx.ReadPdfPath, "*.pdf");
        }

        public static void SendMail(
            string from, 
            string to,
            string subject, 
            string message, 
            IEnumerable<string> attachments)
        {
            if (Context.Ctx.Debug)
            {
                to = "thys_wouter@hotmail.com";
            }

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(from, Context.Ctx.MyInfo.Name),
                Subject = subject,
                Body = message,
            };
            mail.To.Add(to);
            if (attachments != null && attachments.Count() > 0)
            {
                foreach (string attachment in attachments)
                {
                    mail.Attachments.Add(new Attachment(attachment));
                }
            }

            SmtpClient server = new SmtpClient(Context.Ctx.SMTPServer)
            {
                Port = Context.Ctx.SMTPPort,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };

            server.Credentials = new NetworkCredential(
                    Context.Ctx.Email,
                    Context.Ctx.SMTPPassword);


            server.Send(mail);
        }
    }
}
