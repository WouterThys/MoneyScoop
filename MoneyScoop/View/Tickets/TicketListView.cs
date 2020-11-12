using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.ViewModel.Tickets;

namespace MoneyScoop.View.Tickets
{
    public partial class TicketListView : BaseListView
    {
        public TicketListView()
        {
            InitializeModel(typeof(TicketListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Ticket, TicketListViewModel>(sender, e);
        }

        public void InitializeBindings(TicketListViewModel viewModel)
        {
            InitializeModel(typeof(TicketListViewModel), viewModel);
            var fluent = base.InitializeBindings<Ticket, TicketListViewModel>();
            //CustomerDetailView.InitializeBindings(fluent.ViewModel.DetailModel);

            //fluent.SetTrigger(m => m.Selection, (s) =>
            //{
            //    if (s != null && s.Count > 0) { DetailsPanel.Show(); }
            //    else { DetailsPanel.HideSliding(); }
            //});
        }
    }
}
