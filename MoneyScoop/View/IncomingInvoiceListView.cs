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
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace MoneyScoop.View
{
    public partial class IncomingInvoiceListView : BaseListView
    {
        private MVVMContextFluentAPI<IncomingInvoiceListViewModel> fluent;

        public IncomingInvoiceListView()
        {
            InitializeModel(typeof(IncomingInvoiceListViewModel));
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

            gridControl.ToolTipController = toolTipController;
            toolTipController.GetActiveObjectInfo += ToolTipController_GetActiveObjectInfo;
        }
        
        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            CreateDefaultPopupMenu<Invoice, IncomingInvoiceListViewModel>(sender, e);
        }

        private void ToolTipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info == null && e.SelectedControl == gridControl)
            {
                GridView view = gridControl.FocusedView as GridView;
                GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                if (info.InRowCell)
                {
                    string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                    string fieldName = info.Column.FieldName;
                    Invoice invoice = null;
                    switch (fieldName)
                    {
                        case "IsSend":
                            invoice = view.GetRow(info.RowHandle) as Invoice;
                            e.Info = new ToolTipControlInfo(cellKey, (invoice != null && invoice.IsSend) ? invoice.DateSendString : "Not yet send");
                            break;
                        case "IsPayed":
                            invoice = view.GetRow(info.RowHandle) as Invoice;
                            e.Info = new ToolTipControlInfo(cellKey, (invoice != null && invoice.IsPayed) ? invoice.DatePayedString : "Not yet payed");
                            break;
                        case "IsPdfSaved":
                            invoice = view.GetRow(info.RowHandle) as Invoice;
                            e.Info = new ToolTipControlInfo(cellKey, (invoice != null && invoice.IsPdfSaved) ? invoice.SavePath : "Not yet saved");
                            break;
                    }
                }
            }
        }

        private void InitializeBindings()
        {
            fluent = base.InitializeBindings<Invoice, IncomingInvoiceListViewModel>();
            
            fluent.BindCommand(bbiPreviewReports, m => m.ShowInvoicePreviews());
            fluent.BindCommand(bbiSaveReports, m => m.SavePdfReports());
            fluent.BindCommand(bbiMail, m => m.SendMailToCustomer());
        }
    }
}
