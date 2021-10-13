using Database;
using System.Data.Common;

namespace MoneyScoop.Model
{
    public class Customer : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Customer; } }

        private string addressLine1;
        private string addressLine2;
        private string vatNumber;
        private string email;
        private string phone;
        private string website;

        // Defaults for invoice
        private bool vatShifted;
        private decimal defaultUnitPrice;
        private string invoiceCode;

        public Customer() : this("")
        {

        }

        public Customer(string code) : base(code)
        {

        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            Customer obj = new Customer(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Customer that)
            {
                base.CopyFrom(that);
                AddressLine1 = that.AddressLine1;
                AddressLine2 = that.AddressLine2;
                VATNumber = that.VATNumber;
                Email = that.Email;
                Phone = that.Phone;
                Website = that.Website;
                VatShifted = that.VatShifted;
                DefaultUnitPrice = that.DefaultUnitPrice;
                InvoiceCode = that.InvoiceCode;
            }
        }

        #endregion

        #region Database Overrides

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
            AddressLine1 = DatabaseAccess.RGetString(reader, "addressLine1");
            AddressLine2 = DatabaseAccess.RGetString(reader, "addressLine2");
            VATNumber = DatabaseAccess.RGetString(reader, "vatNumber");
            Email = DatabaseAccess.RGetString(reader, "email");
            Phone = DatabaseAccess.RGetString(reader, "phone");
            Website = DatabaseAccess.RGetString(reader, "website");
            VatShifted = DatabaseAccess.RGetBool(reader, "vatShifted");
            DefaultUnitPrice = DatabaseAccess.RGetDecimal(reader, "defaultUnitPrice");
            InvoiceCode = DatabaseAccess.RGetString(reader, "invoiceCode");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "addressLine1", AddressLine1);
            DatabaseAccess.AddDbValue(command, "addressLine2", AddressLine2);
            DatabaseAccess.AddDbValue(command, "vatNumber", VATNumber);
            DatabaseAccess.AddDbValue(command, "email", Email);
            DatabaseAccess.AddDbValue(command, "phone", Phone);
            DatabaseAccess.AddDbValue(command, "website", Website);
            DatabaseAccess.AddDbValue(command, "vatShifted", VatShifted);
            DatabaseAccess.AddDbValue(command, "defaultUnitPrice", DefaultUnitPrice);
            DatabaseAccess.AddDbValue(command, "invoiceCode", InvoiceCode);
            
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


        #endregion

        #region Properties

        public string AddressLine1
        {
            get => addressLine1 ?? "";
            set
            {
                addressLine1 = value;
                OnPropertyChanged("AddressLine1");
            }
        }

        public string AddressLine2
        {
            get => addressLine2 ?? "";
            set
            {
                addressLine2 = value;
                OnPropertyChanged("AddressLine2");
            }
        }

        public string VATNumber
        {
            get => vatNumber ?? "";
            set
            {
                vatNumber = value;
                OnPropertyChanged("VATNumber");
            }
        }

        public string Email
        {
            get => email ?? "";
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Phone
        {
            get => phone ?? "";
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string Website
        {
            get => website ?? "";
            set
            {
                website = value;
                OnPropertyChanged("Website");
            }
        }

        public bool VatShifted
        {
            get => vatShifted;
            set
            {
                vatShifted = value;
                OnPropertyChanged("VatShifted");
            }
        }

        public decimal DefaultUnitPrice
        {
            get => defaultUnitPrice;
            set
            {
                defaultUnitPrice = value;
                OnPropertyChanged("DefaultUnitPrice");
            }
        }

        public string InvoiceCode
        {
            get => invoiceCode ?? "";
            set
            {
                invoiceCode = value;
                OnPropertyChanged("InvoiceCode");
            }
        }

        #endregion
    }
}
