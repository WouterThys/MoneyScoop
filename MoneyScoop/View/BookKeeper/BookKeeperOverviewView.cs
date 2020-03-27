using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MoneyScoop.ViewModel.BookKeeper;
using MoneyScoop.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Columns;
using MoneyScoop.ViewModel;

namespace MoneyScoop.View.BookKeeper
{
    public partial class BookKeeperOverviewView : BaseRibbonControl
    {
        public BookKeeperOverviewView()
        {
            InitializeModel(typeof(BookKeeperOverviewModel));
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeLayouts();
                InitializeServices();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            
            InitializeGridView(gvIncomingInvoices);
            InitializeGridView(gvOutgoingInvoices);

            sendMailView.InitializeLayouts();
        }

        private void InitializeGridView(GridView gridView)
        {
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = col.FieldName == "IsChecked";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = mvvmContext.OfType<BookKeeperOverviewModel>();

                sendMailView.InitializeBindings(fluent.ViewModel.SendMailViewModel);

                fluent.SetObjectDataSourceBinding(bsIncomingInvoices, m => m.IncomingInvoices, m => m.UpdateCommands());
                fluent.SetObjectDataSourceBinding(bsOutgoingInvoices, m => m.OutgoingInvoices, m => m.UpdateCommands());

                fluent.SetBinding(bciShowAll, ci => ci.Checked, m => m.ShowAll);
                fluent.SetBinding(bciInRange, ci => ci.Checked, m => m.ShowInRange);
                fluent.SetBinding(beiFromDate, bei => bei.EditValue, m => m.FromDate);
                fluent.SetBinding(beiTillDate, bei => bei.EditValue, m => m.TillDate);

                fluent.SetBinding(bciInRange, i => i.Enabled, m => m.ShowInRangeEnabled);
                fluent.SetBinding(beiFromDate, i => i.Enabled, m => m.FromDateEnabled);
                fluent.SetBinding(beiTillDate, i => i.Enabled, m => m.TillDateEnabled);
                
                fluent.BindCommand(bbiCreateAll, m => m.CreateAllPdfs());
                fluent.BindCommand(bbiCreateIncomingPdf, m => m.CreateIncomingPdf());
                fluent.BindCommand(bbiCreateOutgoingPdf, m => m.CreateOutgoingPdf());

                fluent.BindCommand(bbiSendToBooky, m => m.SendToBooky());
                
                // GridView - Row double clicked
                fluent.WithEvent<RowClickEventArgs>(gvIncomingInvoices, "RowClick").EventToCommand(
                        m => m.ShowIncomingInvoice(),
                        args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
                fluent.WithEvent<RowClickEventArgs>(gvOutgoingInvoices, "RowClick").EventToCommand(
                        m => m.CanShowOutgoingInvoice(),
                        args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

                // GridView - Multiple selected
                fluent.WithEvent<SelectionChangedEventArgs>(gvIncomingInvoices, "SelectionChanged").SetBinding(
                    m => m.IncomingSelection,
                    arg => new List<CheckedInvoice>(gvIncomingInvoices.GetSelectedRows().Select(r => gvIncomingInvoices.GetRow(r) as CheckedInvoice)));
                fluent.WithEvent<SelectionChangedEventArgs>(gvOutgoingInvoices, "SelectionChanged").SetBinding(
                    m => m.OutgoingSelection,
                    arg => new List<CheckedInvoice>(gvOutgoingInvoices.GetSelectedRows().Select(r => gvOutgoingInvoices.GetRow(r) as CheckedInvoice)));
            }
        }
    }
}
