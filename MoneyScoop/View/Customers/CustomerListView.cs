using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace MoneyScoop.View
{
    public partial class CustomerListView : BaseListView
    {
        public CustomerListView()
        {
            InitializeModel(typeof(CustomerListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                InitializeBindings();
                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            CustomerDetailView.InitializeLayouts();
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Customer, CustomerListViewModel>(sender, e);
        }

        private void InitializeBindings()
        {
            var fluent = base.InitializeBindings<Customer, CustomerListViewModel>();
            CustomerDetailView.InitializeBindings(fluent.ViewModel.DetailModel);
        }
    }
}
