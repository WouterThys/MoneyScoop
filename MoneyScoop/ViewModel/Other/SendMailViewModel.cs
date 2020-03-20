using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    [POCOViewModel]
    public class SendMailViewModel : BaseViewModel
    {
        public static SendMailViewModel Create(Invoice invoice)
        {
            return ViewModelSource.Create(() => new SendMailViewModel(invoice));
        }

        private readonly Invoice invoice;

        public virtual string From { get; set; }
        public virtual string Receiver { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Message { get; set; }
        public virtual BindingList<string> Attachments { get; set; }

        public SendMailViewModel(Invoice invoice) : base(ModuleTypes.SendMailModule)
        {
            this.invoice = (Invoice)invoice.CreateCopy();
            Load();
        }

        public override Task Load()
        {
            return Task.Factory.StartNew((disp) =>
            {
                string from = "";
                string receiver = "";
                string subject = "";
                string message = "";
                List<string> attachments = new List<string>();
                if (invoice != null)
                {
                    from = Context.Ctx.Email;
                    receiver = invoice?.Customer?.Email ?? "";
                    subject = "Factuur " + invoice.Code;
                    message = "Beste, " + Environment.NewLine + Environment.NewLine +
                              "In bijlage factuur " + invoice.Code + "." + Environment.NewLine +
                              "Mvg," + Environment.NewLine + Environment.NewLine +
                              "Wouter Thys";
                    if (invoice.IsPdfSaved)
                    {
                        attachments.Add(invoice.SavePath);
                    }
                }

                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    From = from;
                    Receiver = receiver;
                    Subject = subject;
                    Message = message;
                    Attachments = new BindingList<string>(attachments);
                    IsLoading = false;
                });
            }, DispatcherService);
        }

        public override void OnLoading() { }

        public override void OnLoaded() { }


        public virtual bool CanSendMail()
        {
            return !IsLoading && invoice != null;
        }

        public virtual void SendMail()
        {
            if (invoice.IsSend)
            {
                var result = MessageBoxService.ShowMessage("Invoice is already send on " +
                    invoice.DateSendString + " " +
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
                    InvoiceActionHelper.SendMail(
                        From,
                        Receiver,
                        Subject,
                        Message,
                        Attachments);
                    
                    invoice.IsSend = true;
                    invoice.Save();
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
