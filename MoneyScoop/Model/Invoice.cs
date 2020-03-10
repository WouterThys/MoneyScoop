using Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.Model
{
    public class Invoice : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Invoice; } }

        private DateTime dateCreated;
        private DateTime dateSend;
        private DateTime datePayed;
        private int vat;
        private long customerId;

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
                DateCreated = that.DateCreated;
                DateSend = that.DateSend;
                DatePayed = that.DatePayed;
                VAT = that.VAT;
                CustomerId = that.CustomerId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is Invoice that)
                {
                    return
                        CustomerId == that.CustomerId &&
                        DateCreated == that.DateCreated &&
                        DateSend == that.DateSend &&
                        DatePayed == that.DatePayed &&
                        VAT == that.VAT
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
            DateCreated = DatabaseAccess.RGetDateTime(reader, "dateCreated");
            DateSend = DatabaseAccess.RGetDateTime(reader, "dateSend");
            DatePayed = DatabaseAccess.RGetDateTime(reader, "datePayed");
            VAT = DatabaseAccess.RGetInt(reader, "vat");
            CustomerId = DatabaseAccess.RGetLong(reader, "customerId");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "dateCreated", DateCreated);
            DatabaseAccess.AddDbValue(command, "dateSend", DateSend);
            DatabaseAccess.AddDbValue(command, "datePayed", DatePayed);
            DatabaseAccess.AddDbValue(command, "vat", VAT);
            DatabaseAccess.AddDbValue(command, "customerId", CustomerId > UNKNOWN_ID ? CustomerId : UNKNOWN_ID);


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
                    break;
            }
        }

        public override string Code
        {
            get
            {
                if (Id <= UNKNOWN_ID)
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
            get { return DateCreated.AddDays(Context.Ctx.MyInfo.DueDays); }
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
            }
        }

        public void UpdateInvoiceLine(InvoiceLine line)
        {
            if (line != null && InvoiceLines != null)
            {
                // TODO
            }
        }

        public void DeleteInvoiceLine(InvoiceLine line)
        {
            if (line != null && InvoiceLines != null)
            {
                if (invoiceLines.Remove(line))
                {
                    OnPropertyChanged("InvoiceLines");
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

        public string DatePayedString
        {
            get
            {
                return IsPayed ? DatePayed.ToString("dd/MM/yyyy hh:mm") : "";
            }
        }

        public string DateSendString
        {
            get
            {
                return IsSend ? DateSend.ToString("dd/MM/yyyy hh:mm") : "";
            }
        }

        #endregion

        #region Properties

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

        public int VAT
        {
            get => vat;
            set
            {
                vat = value;
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

        #endregion
    }
}
