using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.MVVM;
using MoneyScoop.Reports;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars;
using System.IO;

namespace MoneyScoop.View
{
    public partial class InvoiceListView : BaseListView
    {
        private MVVMContextFluentAPI<InvoiceListViewModel> fluent;

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

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            bbiCreateReport.ItemClick += BbiCreateReport_ItemClick;
            bbiSaveReport.ItemClick += BbiSaveReport_ItemClick;
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Invoice, InvoiceListViewModel>(sender, e);
        }

        private void InitializeBindings()
        {
            fluent = base.InitializeBindings<Invoice, InvoiceListViewModel>();

            fluent.BindCommand(bbiCustomers, m => m.ShowCustomers());
        }

        private void BbiCreateReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fluent == null) return;
            if (fluent.ViewModel.Selected == null) return;

            InvoiceReport report = new InvoiceReport
            {
                DataSource = new List<Invoice>() { fluent.ViewModel.Selected }
            };
            
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void BbiSaveReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fluent == null) return;
            if (fluent.ViewModel.Selected == null) return;

            string file = Path.Combine(Context.Ctx.MyInfo.SavePdfPath,
                fluent.ViewModel.Selected.Code);

            InvoiceReport report = new InvoiceReport
            {
                DataSource = new List<Invoice>() { fluent.ViewModel.Selected }
            };

            report.ExportToPdf(file + ".pdf");
        }
    }
}
