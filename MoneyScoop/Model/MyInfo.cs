using System.ComponentModel;

namespace MoneyScoop.Model
{
    public class MyInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private string addressLine1;
        private string addressLine2;
        private string vatNumber;
        private string email;
        private string phone;
        private string bankAccount;

        private string savePdfPath;
        private int dueDays;
    

        #region Interface Methods

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion

        #region Properties

        public string Name
        {
            get => name ?? "";
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

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

        public string BankAccount
        {
            get => bankAccount ?? "";
            set
            {
                bankAccount = value;
                OnPropertyChanged("BankAccount");
            }
        }

        public string SavePdfPath
        {
            get => savePdfPath ?? "";
            set
            {
                savePdfPath = value;
                OnPropertyChanged("SavePdfPath");
            }
        }

        public int DueDays
        {
            get => dueDays;
            set
            {
                dueDays = value;
                OnPropertyChanged("DueDays");
            }
        }

        #endregion
    }
}
