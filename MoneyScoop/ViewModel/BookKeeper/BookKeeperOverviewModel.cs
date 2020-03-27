using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using MoneyScoop.Model;
using MoneyScoop.ViewModel.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel.BookKeeper
{
    [POCOViewModel]
    public class BookKeeperOverviewModel : BaseDocumentViewModel
    {
        public static BookKeeperOverviewModel Create()
        {
            return ViewModelSource.Create(() => new BookKeeperOverviewModel());
        }

        public virtual bool IsLoadingOutgoing { get; set; } = false;
        public virtual bool IsLoadingIncoming { get; set; } = false;
        public virtual BindingList<CheckedInvoice> OutgoingInvoices { get; protected set; }
        public virtual BindingList<CheckedInvoice> IncomingInvoices { get; protected set; }

        public virtual List<CheckedInvoice> OutgoingSelection { get; set; }
        public virtual List<CheckedInvoice> IncomingSelection { get; set; }

        public virtual bool ShowInRange { get; set; }
        public virtual DateTime FromDate { get; set; }
        public virtual DateTime TillDate { get; set; }
        public virtual bool ShowAll { get; set; }

        public virtual bool ShowInRangeEnabled { get; set; }
        public virtual bool FromDateEnabled { get; set; }
        public virtual bool TillDateEnabled { get; set; }

        private bool isFirstLoad = true;

        public virtual SendMailViewModel SendMailViewModel { get; set; }

        protected BookKeeperOverviewModel() : base(ModuleTypes.BookKeeperOverviewModule)
        {
            SendMailViewModel = SendMailViewModel.CreateForBooky();
            Load();
        }
        

        #region Loading

        public override Task Load()
        {
            IsLoading = true;
            return Task.Factory.StartNew((disp) =>
            {
                bool showInRange = ShowInRange;
                bool showAll = ShowAll;
                DateTime fromDate = FromDate;
                DateTime tillDate = TillDate;
                if (isFirstLoad)
                {
                    // Defaults
                    showInRange = false;
                    showAll = false;
                    fromDate = DateTime.Now.AddMonths(-4).Date;
                    tillDate = DateTime.Now.AddDays(1).Date;
                    isFirstLoad = false;
                }
                LoadIncomingInvoices();
                LoadOutgoingInvoices();

                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    ShowInRange = showInRange;
                    ShowAll = showAll;
                    FromDate = fromDate;
                    TillDate = tillDate;
                    IsLoading = false;
                    UpdateCommands();
                });
            }, DispatcherService);
        }

        public override void OnLoading() { }
        public override void OnLoaded() { }

        public override bool IsLoading
        {
            get => base.IsLoading || IsLoadingIncoming || IsLoadingOutgoing;
            set => base.IsLoading = value;
        }

        private Task LoadIncomingInvoices()
        {
            IsLoadingIncoming = true;
            return Task.Factory.StartNew((disp) =>
            {
                List<CheckedInvoice> invoices = FilterInvoices(DataSource.Ds.Invoices.Where(i => !i.OutGoing));
                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    IsLoadingIncoming = false;
                    IncomingInvoices = new BindingList<CheckedInvoice>(invoices);
                    UpdateCommands();
                });
            }, DispatcherService);
        }

        private Task LoadOutgoingInvoices()
        {
            IsLoadingOutgoing = true;
            return Task.Factory.StartNew((disp) =>
            {
                List<CheckedInvoice> invoices = FilterInvoices(DataSource.Ds.Invoices.Where(i => i.OutGoing));
                ((IDispatcherService)disp).BeginInvoke(() =>
                {
                    IsLoadingOutgoing = false;
                    OutgoingInvoices = new BindingList<CheckedInvoice>(invoices);
                    UpdateCommands();
                });
            }, DispatcherService);
        }

        private List<CheckedInvoice> FilterInvoices(IEnumerable<Invoice> allInvoices)
        {
            List<CheckedInvoice> invoices = new List<CheckedInvoice>();
            foreach (Invoice i in allInvoices)
            {
                if (!i.IsSaved) continue;

                CheckedInvoice ci = new CheckedInvoice(i);
                if (ShowAll)
                {
                    invoices.Add(ci);
                }
                else if (ShowInRange)
                {
                    if (i.DateCreated >= FromDate && i.DateCreated <= TillDate)
                    {
                        invoices.Add(ci);
                    }
                }
                else if (!i.IsSendToBooky)
                {
                    invoices.Add(ci);
                }
            }
            return invoices;
        }

        #endregion

        public virtual void UpdateCommands()
        {
            if (IsLoading || IsLoadingIncoming || IsLoadingOutgoing) return;

            this.RaiseCanExecuteChanged(x => x.ShowIncomingInvoice());
            this.RaiseCanExecuteChanged(x => x.CreateAllPdfs());
            this.RaiseCanExecuteChanged(x => x.CreateIncomingPdf());
            this.RaiseCanExecuteChanged(x => x.CreateOutgoingPdf());
            this.RaiseCanExecuteChanged(x => x.SendToBooky());
        }

        private void OnInvoicesChanged()
        {
            if (IsLoadingIncoming || IsLoadingOutgoing) return;
            SendMailViewModel.SetInvoices(GetAllCheckedInvoices());
        }

        public virtual void OnIncomingInvoicesChanged() => OnInvoicesChanged();

        public virtual void OnOutgoingInvoicesChanged() => OnInvoicesChanged();

        protected virtual void OnOptionsChanged()
        {
            if (!IsLoadingIncoming)
                LoadIncomingInvoices();

            if (!IsLoadingOutgoing)
                LoadOutgoingInvoices();

            ShowInRangeEnabled = !ShowAll;
            FromDateEnabled = ShowInRangeEnabled && ShowInRange;
            TillDateEnabled = ShowInRangeEnabled && ShowInRange;
        }

        public virtual void OnShowInRangeChanged() => OnOptionsChanged();

        public virtual void OnFromDateChanged() => OnOptionsChanged();

        public virtual void OnTillDateChanged() => OnOptionsChanged();

        public virtual void OnShowAllChanged() => OnOptionsChanged();

        public virtual void OnSelectionChanged()
        {
            if (IsLoading) return;
            UpdateCommands();
        }

        public virtual CheckedInvoice SelectedIncoming
        {
            get
            {
                if (IncomingSelection != null && IncomingSelection.Count > 0)
                {
                    return IncomingSelection[0];
                }
                return null;
            }
        }


        public virtual CheckedInvoice SelectedOutgoing
        {
            get
            {
                if (OutgoingSelection != null && OutgoingSelection.Count > 0)
                {
                    return OutgoingSelection[0];
                }
                return null;
            }
        }

        private IEnumerable<Invoice> GetAllCheckedInvoices()
        {
            return GetCheckedInvoices(null);
        }

        private IEnumerable<Invoice> GetCheckedInvoices(IEnumerable<CheckedInvoice> invoices)
        {
            if (invoices != null)
            {
                // Select checked
                return new List<CheckedInvoice>(invoices.Where(ci => ci.IsChecked)).ConvertAll(i => i.Invoice);
            }
            else
            {
                // Return all
                List<CheckedInvoice> checkedInvoices = new List<CheckedInvoice>();
                checkedInvoices.AddRange(IncomingInvoices.Where(i => i.IsChecked));
                checkedInvoices.AddRange(OutgoingInvoices.Where(i => i.IsChecked));
                return checkedInvoices.ConvertAll(i => i.Invoice);
            }
        }

        private bool HasSelectedInvoices(IEnumerable<CheckedInvoice> invoices)
        {
            foreach (CheckedInvoice ci in invoices)
            {
                if (ci.IsChecked)
                {
                    return true;
                }
            }
            return false;
        }


        #region Commands

        public virtual bool CanShowIncomingInvoice()
        {
            return !IsLoading && !IsLoadingIncoming && SelectedIncoming != null;
        }

        public virtual void ShowIncomingInvoice()
        {
            BaseViewModel model = IncomingInvoiceEditViewModel.Create(SelectedIncoming.Invoice);
            model.SetParentViewModel(this);
            ShowDocument(model);
        }


        public virtual bool CanShowOutgoingInvoice()
        {
            return !IsLoading && !IsLoadingOutgoing && SelectedOutgoing != null;
        }

        public virtual void ShowIncomingOutgoing()
        {
            BaseViewModel model = OutgoingInvoiceEditViewModel.Create(SelectedOutgoing.Invoice);
            model.SetParentViewModel(this);
            ShowDocument(model);
        }


        public virtual bool CanCreateAllPdfs()
        {
            return !IsLoading && (CanCreateIncomingPdf() || CanCreateOutgoingPdf());
        }

        public virtual void CreateAllPdfs()
        {
            CreateIncomingPdf();
            CreateOutgoingPdf();
        }

        public virtual bool CanCreateIncomingPdf()
        {
            return !IsLoadingIncoming && HasSelectedInvoices(IncomingInvoices) ;
        }

        public virtual void CreateIncomingPdf()
        {
            CreatePdf(false);
        }

        public virtual bool CanCreateOutgoingPdf()
        {
            return !IsLoadingOutgoing && HasSelectedInvoices(OutgoingInvoices);
        }

        public virtual void CreateOutgoingPdf()
        {
            CreatePdf(true);
        }


        private void CreatePdf(bool outgoing)
        {
            string targetName = "" + (outgoing ? "Aankoop_" : "Verkoop_") +
                Context.Ctx.MyInfo.Name.Replace(" ", "") + "_" +
                DateTime.Now.ToString("yyyyMMdd") +
                ".pdf";
            string targetPdf = Path.Combine(Context.Ctx.BookyPdfPath, targetName);
            IEnumerable<Invoice> checkedInvoices = GetCheckedInvoices(outgoing ? OutgoingInvoices : IncomingInvoices);
            if (Utils.MergePdfs(targetPdf, checkedInvoices))
            {
                MessageBoxService.ShowMessage("PDF created at\n" + targetPdf, "Created", MessageButton.OK, MessageIcon.Information);
                MailAttachment attachment = new MailAttachment(targetPdf);
                if (!SendMailViewModel.Attachments.Contains(attachment))
                {
                    SendMailViewModel.Attachments.Add(attachment);
                }
                foreach(Invoice invoice in checkedInvoices)
                {
                    invoice.BookySavePath = targetPdf;
                    invoice.Save();
                }
            }
            else
            {
                MessageBoxService.ShowMessage("Failed to create pdf..", "Error", MessageButton.OK, MessageIcon.Error);
            }
        }


        public virtual bool CanSendToBooky()
        {
            return !IsLoading && SendMailViewModel != null;
        }

        public virtual void SendToBooky()
        {
            SendMailViewModel.SendMail();
        }

        #endregion
    }
}
