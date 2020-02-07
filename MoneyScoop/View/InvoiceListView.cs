using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace MoneyScoop.View
{
    public partial class InvoiceListView : BaseListView
    {
        public InvoiceListView()
        {
            InitializeModel(typeof(InvoiceListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                InitializeBindings();
                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Invoice, InvoiceListViewModel>(sender, e);
        }

        private void InitializeBindings()
        {
            var fluent = base.InitializeBindings<Invoice, InvoiceListViewModel>();

            fluent.BindCommand(bbiCustomers, m => m.ShowCustomers());
        }
    }
}
