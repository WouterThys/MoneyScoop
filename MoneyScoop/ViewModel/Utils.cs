using DevExpress.XtraReports.UI;
using MoneyScoop.Model;
using MoneyScoop.Reports;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.AccessControl;

namespace MoneyScoop.ViewModel
{
    static class Utils
    {

        public static InvoiceReport2 CreateReport(Invoice invoice)
        {
            InvoiceReport2 report = new InvoiceReport2
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

            InvoiceReport2 report = CreateReport(invoice);
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
            mail.CC.Add(from);
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
                UseDefaultCredentials = true
            };

            server.Credentials = new NetworkCredential(
                    Context.Ctx.Email,
                    Context.Ctx.SMTPPassword);


            server.Send(mail);
        }

        public static bool MergePdfs(string targetPath, IEnumerable<Invoice> invoices)
        {
            IEnumerable<string> pdfs = invoices.Select(i => i.SavePath);
            return MergePdfs(targetPath, pdfs.Where(p => !string.IsNullOrEmpty(p) && File.Exists(p)));
        }

        public static bool MergePdfs(string targetPath, IEnumerable<string> pdfs)
        {
            try
            {
                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                }
                string directory = Path.GetDirectoryName(targetPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    DirectorySecurity ds = Directory.GetAccessControl(directory);
                    ds.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                    Directory.SetAccessControl(directory, ds);
                }

                using (PdfDocument targetDoc = new PdfDocument())
                {
                    foreach (string pdf in pdfs)
                    {
                        using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                        {
                            for (int i = 0; i < pdfDoc.PageCount; i++)
                            {
                                targetDoc.AddPage(pdfDoc.Pages[i]);
                            }
                        }
                    }
                    targetDoc.Save(targetPath);
                    File.SetAttributes(targetPath, FileAttributes.Normal);
                    DirectorySecurity ds = Directory.GetAccessControl(directory);
                    ds.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                    Directory.SetAccessControl(targetPath, ds);
                }
                return File.Exists(targetPath);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}
