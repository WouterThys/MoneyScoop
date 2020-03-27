using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.ViewModel.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class SendMailViewModel : BaseViewModel
    {
        public enum SendMailType
        {
            Customer,
            Booky
        }

        public static SendMailViewModel CreateForCustomer(Invoice invoice)
        {
            return ViewModelSource.Create(() => new SendMailViewModel(SendMailType.Customer, new List<Invoice>() { invoice }));
        }

        public static SendMailViewModel CreateForBooky()
        {
            return ViewModelSource.Create(() => new SendMailViewModel(SendMailType.Booky, null));
        }

        private readonly SendMailType mailType;
        private readonly List<Invoice> invoices = new List<Invoice>();

        public virtual string From { get; set; }
        public virtual string Receiver { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Message { get; set; }
        public virtual BindingList<MailAttachment> Attachments { get; set; }

        public SendMailViewModel(SendMailType mailType, IEnumerable<Invoice> data) : base(ModuleTypes.SendMailModule)
        {
            this.mailType = mailType;
            SetInvoices(data);
            Load();
        }

        public void SetInvoices(IEnumerable<Invoice> data)
        {
            invoices.Clear();
            if (data != null)
            {
                foreach (Invoice i in data)
                {
                    invoices.Add((Invoice)i.CreateCopy());
                    if (mailType == SendMailType.Booky)
                    {
                        List<MailAttachment> attachments = new List<MailAttachment>();
                        foreach (Invoice inv in data)
                        {
                            var attachment = new MailAttachment(inv.BookySavePath);
                            if (inv.IsBookyPdfSaved && !attachments.Contains(attachment))
                            {
                                attachments.Add(attachment);
                            }
                        }
                        Attachments = new BindingList<MailAttachment>(attachments);
                    }
                }
            }
        }

        protected SendMailViewModel() : base(ModuleTypes.SendMailModule)
        {
            
        }

        public override Task Load()
        {
            return Task.Factory.StartNew((disp) =>
            {
                string from = "";
                string receiver = "";
                string subject = "";
                string message = "";
                List<MailAttachment> attachments = new List<MailAttachment>();
                switch (mailType)
                {
                    case SendMailType.Customer:
                        Invoice invoice = invoices[0];
                        from = Context.Ctx.Email;
                        receiver = invoice?.Customer?.Email ?? "";
                        subject = "Factuur " + invoice.Code;
                        message = "Beste, " + Environment.NewLine + Environment.NewLine +
                                  "In bijlage factuur " + invoice.Code + "." + Environment.NewLine +
                                  "Mvg," + Environment.NewLine + Environment.NewLine +
                                  "Wouter Thys";
                        if (invoice.IsPdfSaved)
                        {
                            attachments.Add(new MailAttachment(invoice.SavePath));
                        }
                        break;
                    case SendMailType.Booky:
                        from = Context.Ctx.Email;
                        receiver = Context.Ctx.BookKeeper.Email;
                        subject = "Factuuren " + Context.Ctx.MyInfo.Name;
                        message = "Beste, " + Environment.NewLine + Environment.NewLine +
                                  "In bijlage de facturen voor dit kwartaal" + Environment.NewLine +
                                  "Mvg," + Environment.NewLine + Environment.NewLine +
                                  Context.Ctx.MyInfo.Name;
                        
                        break;
                }

                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    From = from;
                    Receiver = receiver;
                    Subject = subject;
                    Message = message;
                    Attachments = new BindingList<MailAttachment>(attachments);
                    IsLoading = false;
                });
            }, DispatcherService);
        }

        public override void OnLoading() { }

        public override void OnLoaded() { }

        public virtual void SendMail()
        {
            if (mailType == SendMailType.Customer && invoices[0].IsSend)
            {
                var result = MessageBoxService.ShowMessage("Invoice is already send on " +
                    invoices[0].DateSendString + " " +
                    "do you really want to send again?",
                    "Already send",
                    MessageButton.YesNo,
                    MessageIcon.Warning);

                if (result == MessageResult.No) return;
            }

            IsLoading = true;
            Task.Factory.StartNew((disp) =>
            {
                try
                {
                    Utils.SendMail(
                        From,
                        Receiver,
                        Subject,
                        Message,
                        new List<MailAttachment>(Attachments).ConvertAll(a => a.AttachmentPath));

                    // Save
                    foreach (Invoice invoice in invoices)
                    {
                        switch (mailType)
                        {
                            case SendMailType.Customer:
                                invoice.IsSend = true;
                                break;
                            case SendMailType.Booky:
                                invoice.IsSendToBooky = true;
                                break;
                        }
                        invoice.Save();
                    }
                }
                catch (Exception e)
                {
                    MessageBoxService.ShowMessage(e.Message, "Error", MessageButton.OK, MessageIcon.Error);
                }

                ((IDispatcherService)disp).BeginInvoke(() =>
                {

                    IsLoading = false;
                });
            }, DispatcherService);
        }
    }
}
