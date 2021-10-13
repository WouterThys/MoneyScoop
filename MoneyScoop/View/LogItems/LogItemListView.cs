using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.ViewModel.LogItems;
using DevExpress.Utils;

namespace MoneyScoop.View.LogItems
{ 

    public partial class LogItemListView : BaseListView
    {
        public LogItemListView()
        {
            InitializeModel(typeof(LogItemListViewModel));
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
            LogItemDetails.InitializeLayouts();

            colStartTime.DisplayFormat.FormatType = FormatType.DateTime;
            colStartTime.DisplayFormat.FormatString = LogItemEditView.dtFormat;
            
            colStopTime.DisplayFormat.FormatType = FormatType.DateTime;
            colStopTime.DisplayFormat.FormatString = LogItemEditView.dtFormat;

            //LogItemDetails.Hide();
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<LogItem, LogItemListViewModel>(sender, e);
        }

        private void InitializeBindings()
        {
            var fluent = base.InitializeBindings<LogItem, LogItemListViewModel>();
            LogItemDetails.InitializeBindings(fluent.ViewModel.DetailModel);

            fluent.BindCommand(bbiCreateInvoices, m => m.CreateInvoices());

            fluent.SetTrigger(m => m.Selection, (s) =>
            {
                if (s != null && s.Count > 0) { DetailsPanel.Show(); }
                else { DetailsPanel.HideSliding(); }
            });
        }

        
        
    }
}
