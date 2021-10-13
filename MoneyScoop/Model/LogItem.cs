using Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyScoop.Utils;

namespace MoneyScoop.Model
{
    public class LogItem : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.LogItem; } }

        private DateTime timeStamp;
        private string groupTag;
        private string version;
        private DateTime startTime;
        private DateTime stopTime;

        private long customerId;
        private Customer customer;

        private long invoiceLineId;
        private InvoiceLine invoiceLine;

        public LogItem() : this("") { }
        public LogItem(string code) : base(code) {

            timeStamp = DateTime.Now;
            startTime = DateTime.Now;
            stopTime = DateTime.Now;
        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            LogItem obj = new LogItem(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is LogItem that)
            {
                base.CopyFrom(that);
                TimeStamp = that.TimeStamp;
                Version = that.Version;
                GroupTag = that.GroupTag;
                StartTime = that.StartTime;
                StopTime = that.StopTime;
                CustomerId = that.CustomerId;
                InvoiceLineId = that.InvoiceLineId;
            }
        }

        #endregion

        #region Database Overrides

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
            TimeStamp = DatabaseAccess.RGetDateTime(reader, "timestamp");
            GroupTag = DatabaseAccess.RGetString(reader, "groupTag");
            Version = DatabaseAccess.RGetString(reader, "version");
            StartTime = DatabaseAccess.RGetDateTime(reader, "startTime");
            StopTime = DatabaseAccess.RGetDateTime(reader, "stopTime");
            CustomerId = DatabaseAccess.RGetLong(reader, "customerId");
            InvoiceLineId = DatabaseAccess.RGetLong(reader, "invoiceLineId");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "timestamp", TimeStamp);
            DatabaseAccess.AddDbValue(command, "groupTag", GroupTag);
            DatabaseAccess.AddDbValue(command, "version", Version);
            DatabaseAccess.AddDbValue(command, "startTime", StartTime);
            DatabaseAccess.AddDbValue(command, "stopTime", StopTime);
            DatabaseAccess.AddDbValue(command, "customerId", CustomerId);
            DatabaseAccess.AddDbValue(command, "invoiceLineId", InvoiceLineId);

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

        #region Methods

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

        public InvoiceLine InvoiceLine
        {
            get
            {
                if (invoiceLine == null && InvoiceLineId > UNKNOWN_ID)
                {
                    invoiceLine = DataSource.Ds.InvoiceLines.ById(InvoiceLineId);
                }
                return invoiceLine;
            }
        }

        public long InvoiceId
        {
            get
            {
                return Invoice != null ? Invoice.Id : 0;
            }
        }

        public Invoice Invoice
        {
            get
            {
                if (InvoiceLine != null)
                {
                    return DataSource.Ds.Invoices.ById(InvoiceLine.InvoiceId);
                }
                return null;
            }
        }

        public string InvoiceCode
        {
            get
            {
                return Invoice != null ? Invoice.Code : "";
            }
        }

        public string CustomerCode
        {
            get
            {
                return Customer != null ? Customer.Code : "";
            }
        }

        public TimeSpan WorkTime
        {
            get
            {
                if (StartTime.Year > 2000 && StopTime.Year > 200)
                {
                    TimeSpan diff = StopTime - StartTime;
                    if (diff.TotalMinutes < 30)
                    {
                        diff = new TimeSpan(0, 30, 0);
                    }
                    return diff.RoundToNearestMinutes(15);
                }
                return TimeSpan.Zero;
            }
        }

        #endregion

        #region Properties

        public DateTime TimeStamp
        {
            get => timeStamp;
            set => SetProperty(ref timeStamp, value, "TimeStamp");
        }

        public string GroupTag
        {
            get => groupTag ?? "";
            set => SetProperty(ref groupTag, value, "GroupTag");
        }

        public string Version
        {
            get => version ?? "";
            set => SetProperty(ref version, value, "Version");
        }

        public DateTime StartTime
        {
            get => startTime;
            set => SetProperty(ref startTime, value, "StartTime");
        }

        public DateTime StopTime
        {
            get => stopTime;
            set => SetProperty(ref stopTime, value, "StopTime");
        }

        public long CustomerId
        {
            get 
            { 
                if (customerId <= UNKNOWN_ID)
                {
                    customerId = UNKNOWN_ID;
                }
                return customerId;
            }
            set => SetProperty(ref customerId, value, "CustomerId", (o, n) =>
            {
                if (customer != null && customer.Id != n)
                {
                    customer = null;
                }
            });
        }

        public long InvoiceLineId
        {
            get
            {
                if (invoiceLineId <= UNKNOWN_ID)
                {
                    invoiceLineId = UNKNOWN_ID;
                }
                return invoiceLineId;
            }
            set => SetProperty(ref invoiceLineId, value, "InvoiceLineId", (o, n) =>
            {
                if (invoiceLine != null && invoiceLine.Id != n)
                {
                    invoiceLine = null;
                }
            });
        }

        #endregion
    }
}
