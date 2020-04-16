using Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MoneyScoop.Model
{
    public class Invoice : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Invoice; } }

        private bool outgoing; // Created by me (false) or invoice to pay (true)
        private DateTime dateCreated;
        private DateTime dateSend;
        private DateTime datePayed;
        private DateTime dateSendToBooky;
        private decimal total;
        private int vat;
        private bool vatShifted;
        private long customerId;
        private string savePath;
        private string bookySavePath;

        // Cached
        private Customer customer;
        private List<InvoiceLine> invoiceLines;

        public Invoice() : this("")
        {

        }

        public Invoice(string code) : base(code)
        {
            DateCreated = DateTime.Now;
            DateSend = DateTime.MinValue.AddYears(10);
            DatePayed = DateTime.MinValue.AddYears(10);
            DateSendToBooky = DateTime.MinValue.AddYears(10);
            Code = Guid.NewGuid().ToString();
            VAT = 21;
        }
        
        #region Base Overrides
        public override IObject CreateCopy()
        {
            Invoice obj = new Invoice(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Invoice that)
            {
                base.CopyFrom(that);
                OutGoing = that.OutGoing;
                DateCreated = that.DateCreated;
                DateSend = that.DateSend;
                DatePayed = that.DatePayed;
                DateSendToBooky = that.DateSendToBooky;
                VAT = that.VAT;
                VATShifted = that.VATShifted;
                CustomerId = that.CustomerId;
                SavePath = that.SavePath;
                BookySavePath = that.BookySavePath;
                Total = that.Total;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is Invoice that)
                {
                    return
                        OutGoing == that.OutGoing &&
                        CustomerId == that.CustomerId &&
                        DateCreated == that.DateCreated &&
                        DateSend == that.DateSend &&
                        DatePayed == that.DatePayed &&
                        DateSendToBooky == that.DateSendToBooky &&
                        VAT == that.VAT &&
                        VATShifted == that.VATShifted &&
                        SavePath == that.SavePath &&
                        BookySavePath == that.BookySavePath &&
                        Total == that.Total
                        ;
                }
            }
            return false;
        }
        #endregion

        #region Database Overrides

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
            OutGoing = DatabaseAccess.RGetBool(reader, "outgoing");
            DateCreated = DatabaseAccess.RGetDateTime(reader, "dateCreated");
            DateSend = DatabaseAccess.RGetDateTime(reader, "dateSend");
            DatePayed = DatabaseAccess.RGetDateTime(reader, "datePayed");
            DateSendToBooky = DatabaseAccess.RGetDateTime(reader, "dateSendToBooky");
            VAT = DatabaseAccess.RGetInt(reader, "vat");
            VATShifted = DatabaseAccess.RGetBool(reader, "vatShifted");
            CustomerId = DatabaseAccess.RGetLong(reader, "customerId");
            SavePath = DatabaseAccess.RGetString(reader, "savePath");
            BookySavePath = DatabaseAccess.RGetString(reader, "bookySavePath");
            Total = DatabaseAccess.RGetDecimal(reader, "total");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "outgoing", OutGoing);
            DatabaseAccess.AddDbValue(command, "dateCreated", DateCreated);
            DatabaseAccess.AddDbValue(command, "dateSend", DateSend);
            DatabaseAccess.AddDbValue(command, "datePayed", DatePayed);
            DatabaseAccess.AddDbValue(command, "dateSendToBooky", DateSendToBooky);
            DatabaseAccess.AddDbValue(command, "vat", VAT);
            DatabaseAccess.AddDbValue(command, "vatShifted", VATShifted);
            DatabaseAccess.AddDbValue(command, "customerId", CustomerId > UNKNOWN_ID ? CustomerId : UNKNOWN_ID);
            DatabaseAccess.AddDbValue(command, "savePath", SavePath);
            DatabaseAccess.AddDbValue(command, "bookySavePath", BookySavePath);
            DatabaseAccess.AddDbValue(command, "total", Total);
        }

        protected override void OnDbActionDone(ActionType action)
        {
            switch (action)
            {
                case ActionType.Insert:
                    DataSource.Ds.OnInserted(this);
                    break;
                case ActionType.Update:
                    DataSource.Ds.OnUpdated(this);
                    break;
                case ActionType.Delete:
                    DataSource.Ds.OnDeleted(this);
                    if (!OutGoing)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(SavePath) && File.Exists(SavePath))
                            {
                                File.Delete(SavePath);
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine("Failed to delete file " + SavePath + ". " + e.Message);
                        }
                    }
                    break;
            }
        }

        public override string Code
        {
            get
            {
                if (Id <= UNKNOWN_ID && !OutGoing)
                {
                    return DateCreated.Year + "-" + DataSource.Ds.NextInvoiceNumber.ToString("D3");
                }
                return base.Code;
            }

            set
            {
                base.Code = value;
            }
        }

        #endregion

        #region Methods & Calculated Fields

        public MyInfo MyInfo
        {
            get { return Context.Ctx.MyInfo; }
        }

        public Customer Customer
        {
            get
            {
                if (customer == null && CustomerId > UNKNOWN_ID)
                {
                    customer = DataSource.Ds.Customers.ById(CustomerId);
                }
                return customer;
            }
        }

        public string CustomerCode
        {
            get { return Customer?.Code ?? ""; }
        }

        public DateTime DueDate
        {
            get { return DateCreated.AddDays(Context.Ctx.DueDays).Date; }
        }

        public List<InvoiceLine> InvoiceLines
        {
            get
            {
                if (invoiceLines == null && Id > UNKNOWN_ID)
                {
                    invoiceLines = new List<InvoiceLine>(DataSource.Ds.InvoiceLines.Where(il => il.InvoiceId == Id));
                }
                return invoiceLines;
            }
        }

        public void UpdateInvoiceLines()
        {
            invoiceLines = null;
        }

        public void AddInvoiceLine(InvoiceLine line)
        {
            if (line != null && InvoiceLines != null)
            {
                invoiceLines.Add(line);
                OnPropertyChanged("InvoiceLines");
                //OnPropertyChanged("Total");
            }
        }

        public void UpdateInvoiceLine(InvoiceLine line)
        {
            if (line != null && InvoiceLines != null)
            {
                // TODO
                //OnPropertyChanged("Total");
            }
        }

        public void DeleteInvoiceLine(InvoiceLine line)
        {
            if (line != null && InvoiceLines != null)
            {
                if (invoiceLines.Remove(line))
                {
                    OnPropertyChanged("InvoiceLines");
                    //OnPropertyChanged("Total");
                }
            }
        }

        public bool IsPayed
        {
            get
            {
                return DatePayed != null && DatePayed.Year > 2000;
            }
            set
            {
                DatePayed = value ? DateTime.Now : DateTime.MinValue.AddYears(10);
                OnPropertyChanged("IsPayed");
            }
        }

        public bool IsSend
        {
            get
            {
                return DateSend != null && DateSend.Year > 2000;
            }
            set
            {
                DateSend = value ? DateTime.Now : DateTime.MinValue.AddYears(10);
                OnPropertyChanged("IsSend");
            }
        }

        public bool IsSendToBooky
        {
            get
            {
                return DateSendToBooky != null && DateSendToBooky.Year > 2000;
            }
            set
            {
                DateSendToBooky = value ? DateTime.Now : DateTime.MinValue.AddYears(10);
                OnPropertyChanged("IsSendToBooky");
            }
        }

        public bool IsPdfSaved => !string.IsNullOrEmpty(SavePath) && File.Exists(SavePath);

        public bool IsBookyPdfSaved => !string.IsNullOrEmpty(BookySavePath) && File.Exists(BookySavePath);

        public string DatePayedString => IsPayed ? DatePayed.ToString("dd/MM/yyyy hh:mm") : "";

        public string DateSendString => IsSend ? DateSend.ToString("dd/MM/yyyy hh:mm") : "";

        public string DateSendToBookyString => IsSendToBooky ? DateSendToBooky.ToString("dd/MM/yyyy hh:mm") : "";

        public DateTime DateSendToBookyDate => DateSendToBooky.Date;

        public string DateCreatedString => DateCreated.ToString("dd/MM/yyyy");

        public string DueDateString => DueDate.ToString("dd/MM/yyyy");

        public string DateModifiedString => LastModified.ToString("dd/MM/yyyy hh:mm");

        public string BankAccount => MyInfo.BankAccount;


        public decimal SubTotal
        {
            get
            {
                decimal result = 0;
                if (InvoiceLines != null)
                {
                    foreach (InvoiceLine line in InvoiceLines)
                    {
                        result += line.Total;
                    }
                    //OnPropertyChanged("Total");
                }
                return result;
            }
        }

        public decimal Total
        {
            get
            {
                if (OutGoing)
                {
                    return total;
                }
                else
                {
                    if (VATShifted)
                    {
                        return SubTotal;
                    }
                    else
                    {
                        return SubTotal + (SubTotal * VAT / 100);
                    }
                }
            }
            set
            {
                if (OutGoing)
                {
                    total = value;
                    //OnPropertyChanged("Total");
                }
            }
        }

        #endregion

        #region Properties

        public bool OutGoing
        {
            get => outgoing;
            set
            {
                outgoing = value;
                OnPropertyChanged("OutGoing");
            }
        }

        public DateTime DateCreated
        {
            get => dateCreated;
            set
            {
                dateCreated = value;
                OnPropertyChanged("DateCreated");
            }
        }

        public DateTime DateSend
        {
            get => dateSend;
            set
            {
                dateSend = value;
                OnPropertyChanged("DateSend");
            }
        }

        public DateTime DatePayed
        {
            get => datePayed;
            set
            {
                datePayed = value;
                OnPropertyChanged("DatePayed");
            }
        }

        public DateTime DateSendToBooky
        {
            get => dateSendToBooky;
            set
            {
                dateSendToBooky = value;
                OnPropertyChanged("DateSendToBooky");
            }
        }

        public int VAT
        {
            get
            {
                if (VATShifted)
                {
                    return 0;
                }
                else
                {
                    return vat;
                }
            }
            set
            {
                vat = value;
                OnPropertyChanged("VAT");
            }
        }

        public bool VATShifted
        {
            get => vatShifted;
            set
            {
                vatShifted = value;
                OnPropertyChanged("VATShifted");
                OnPropertyChanged("VAT");
            }
        }

        public long CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                if (customer != null && customer.Id != value)
                {
                    customer = null;
                }
                customerId = value;
                OnPropertyChanged("CustomerId");
            }
        }

        public string SavePath
        {
            get => savePath ?? "";
            set
            {
                savePath = value;
                OnPropertyChanged("SavePath");
            }
        }

        public string BookySavePath
        {
            get => bookySavePath ?? "";
            set
            {
                bookySavePath = value;
                OnPropertyChanged("BookySavePath");
            }
        }

        #endregion
    }
}
