using Database;
using System;
using System.Data.Common;

namespace MoneyScoop.Model
{
    public class InvoiceLine : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.InvoiceLine; } }

        private long invoiceId;

        private DateTime dateCreated;
        private decimal unitPrice;
        private double multiplier;

        // Configs
        private bool showUnitPrice;
        private bool showDate;

        public InvoiceLine(Invoice invoice) : this()
        {
            invoiceId = invoice != null ? invoice.Id : 1;

        }
        
        public InvoiceLine() : this("")
        {

        }

        public InvoiceLine(string code) : base(code)
        {
            DateCreated = DateTime.Now;
            Multiplier = 1;
        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            InvoiceLine obj = new InvoiceLine(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is InvoiceLine that)
            {
                base.CopyFrom(that);
                InvoiceId = that.InvoiceId;
                DateCreated = that.DateCreated;
                UnitPrice = that.UnitPrice;
                Multiplier = that.Multiplier;
                ShowUnitPrice = that.ShowUnitPrice;
                ShowDate = that.ShowDate;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is InvoiceLine that)
                {
                    return
                    InvoiceId == that.InvoiceId &&
                    DateCreated == that.DateCreated &&
                    UnitPrice == that.UnitPrice &&
                    Multiplier == that.Multiplier &&
                    ShowUnitPrice == that.ShowUnitPrice &&
                    ShowDate == that.ShowDate
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
            InvoiceId = DatabaseAccess.RGetLong(reader, "invoiceId");
            DateCreated = DatabaseAccess.RGetDateTime(reader, "dateCreated");
            UnitPrice = DatabaseAccess.RGetDecimal(reader, "unitPrice");
            Multiplier = DatabaseAccess.RGetDouble(reader, "multiplier");
            ShowUnitPrice = DatabaseAccess.RGetBool(reader, "showUnitPrice");
            ShowDate = DatabaseAccess.RGetBool(reader, "showDate");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "invoiceId", InvoiceId > UNKNOWN_ID ? InvoiceId : UNKNOWN_ID);
            DatabaseAccess.AddDbValue(command, "dateCreated", DateCreated);
            DatabaseAccess.AddDbValue(command, "unitPrice", UnitPrice);
            DatabaseAccess.AddDbValue(command, "multiplier", Multiplier);
            DatabaseAccess.AddDbValue(command, "showUnitPrice", ShowUnitPrice);
            DatabaseAccess.AddDbValue(command, "showDate", ShowDate);
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

        #endregion

        #region Methods & Calculated Fields

        public decimal Total => Multiplier > 0 ? ((decimal)Multiplier * UnitPrice) : UnitPrice;

        #endregion

        #region Properties

        public long InvoiceId
        {
            get => invoiceId;
            set
            {
                invoiceId = value;
                OnPropertyChanged("InvoiceId");
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

        public decimal UnitPrice
        {
            get => unitPrice;
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
                OnPropertyChanged("Total");
            }
        }

        public double Multiplier
        {
            get => multiplier;
            set
            {
                multiplier = value;
                OnPropertyChanged("Multiplier");
                OnPropertyChanged("Total");
            }
        }

        public bool ShowUnitPrice
        {
            get => showUnitPrice;
            set
            {
                showUnitPrice = value;
                OnPropertyChanged("ShowUnitPrice");
            }
        }

        public bool ShowDate
        {
            get => showDate;
            set
            {
                showDate = value;
                OnPropertyChanged("ShowDate");
            }
        }

        #endregion
    }
}
