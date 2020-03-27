using MoneyScoop.Model;

namespace MoneyScoop.ViewModel.BookKeeper
{
    public class CheckedInvoice
    {
        public virtual bool IsChecked { get; set; }
        public virtual Invoice Invoice { get; set; }
        public CheckedInvoice(Invoice invoice)
        {
            Invoice = invoice;
            IsChecked = !invoice.IsSendToBooky;
        }
    }
}
