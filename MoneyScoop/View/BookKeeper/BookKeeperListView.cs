using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MoneyScoop.Utils;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using MoneyScoop.Model;
using MoneyScoop.ViewModel;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using MoneyScoop.ViewModel.BookKeeper;

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

            //// GridView - Row double clicked
            //fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
            //        m => m.Edit(null),
            //        m => m.Selected,
            //        args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gridView, "SelectionChanged").SetBinding(
                m => m.Selection,
                e => new List<Invoice>(gridView.GetSelectedRows().Select(r => gridView.GetRow(r) as Invoice)));

            //// GridView - Keys
            //fluent.WithEvent<KeyEventArgs>(gridView, "KeyDown").EventToCommand(
            //    m => m.KeyPressed(null));

            // Ribbon
            //fluent.BindCommand(bbiAdd, m => m.Add());
            //fluent.BindCommand(bbiEdit, m => m.Edit(null), m => m.Selected);
            //fluent.BindCommand(bbiDelete, m => m.Delete(null), m => m.Selection);


        }
    }
}
