using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MoneyScoop.Utils;
using DevExpress.Utils.MVVM.Services;
using MoneyScoop.Model;
using DevExpress.Data;
using MoneyScoop.ViewModel.BookKeeper;
using DevExpress.XtraGrid.Views.Grid;

namespace MoneyScoop.View.BookKeeper
{
    public partial class BookKeeperListView : BaseRibbonControl
    {
        public BookKeeperListView()
        {
            InitializeModel(typeof(BookKeeperListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                InitializeBindings();
                //gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ViewHelpers.InitializeGridView(gridView);
        }

        protected override void InitializeServices()
        {
            base.InitializeServices();
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateXtraFormService(this));
            mvvmContext.RegisterService(MessageBoxService.Create(DefaultMessageBoxServiceType.XtraMessageBox));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            gridControl.ForceInitialize();
        }

        private void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<BookKeeperListViewModel>();

            // Events
            fluent.WithEvent<EventArgs>(this, "Load").EventToCommand(m => m.Load());

            // GridView
            fluent.SetBinding(gridView, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsInvoices, m => m.Invoices, m => m.UpdateCommands());

            // GridView - Row double clicked
            fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    m => m.ShowInvoice(null),
                    m => m.Selected,
                    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));

            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gridView, "SelectionChanged").SetBinding(
                m => m.Selection,
                e => new List<Invoice>(gridView.GetSelectedRows().Select(r => gridView.GetRow(r) as Invoice)));

            // Ribbon
            fluent.BindCommand(bbiOverview, m => m.ShowOverview());


        }
    }
}
