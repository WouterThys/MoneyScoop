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

namespace MoneyScoop.View
{
    public partial class BaseListView : BaseRibbonControl
    {
        public BaseListView()
        {
            InitializeComponent();
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
        }

        protected virtual MVVMContextFluentAPI<TModel> InitializeBindings<T, TModel>()
            where TModel : BaseListViewModel<T>
            where T : class, IBaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();

            // Events
            fluent.WithEvent<EventArgs>(this, "Load").EventToCommand(m => m.Load());

            // GridView
            fluent.SetBinding(gridView, gv => gv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bindingSource, m => m.Entities, m => m.UpdateCommands());

            // GridView - Row double clicked
            fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick").EventToCommand(
                    m => m.Edit(null),
                    m => m.Selected,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            // GridView - Multiple selected
            fluent.WithEvent<SelectionChangedEventArgs>(gridView, "SelectionChanged").SetBinding(
                m => m.Selection,
                e => new List<T>(gridView.GetSelectedRows().Select(r => gridView.GetRow(r) as T)));

            // GridView - Keys
            fluent.WithEvent<KeyEventArgs>(gridView, "KeyDown").EventToCommand(
                m => m.KeyPressed(null));

            // Ribbon
            fluent.BindCommand(bbiAdd, m => m.Add());
            fluent.BindCommand(bbiEdit, m => m.Edit(null), m => m.Selected);
            fluent.BindCommand(bbiDelete, m => m.Delete(null), m => m.Selection);

            return fluent;
        }

        #region EVENTS

        
        #endregion

        #region FILTERS
        protected bool showEnabled = false;
        protected virtual void GridView_CustomTypeRowFilter(object sender, RowFilterEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            object selected = view.GetRow(e.ListSourceRow);
            if (selected is IBaseObject bObj)
            {
                bool show = !bObj.IsUnknown();
                if (!show)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
        }


        #endregion

        #region POPUP MENU
        protected virtual void CreateDefaultPopupMenu<T, TModel>(object sender, PopupMenuShowingEventArgs e) where TModel : BaseListViewModel<T> where T : BaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();
            GridView view = sender as GridView;
            int rowHandle = e.HitInfo.RowHandle;
            if (rowHandle >= 0 && e.Menu != null)
            {
                e.Menu.Items.Clear();

                //DXMenuItem addItem = CreateMenuItemAdd(view, rowHandle);
                DXMenuItem editItem = CreateMenuItemEdit(view, rowHandle);
                DXMenuItem deleteItem = CreateMenuItemDelete(view, rowHandle);

                //fluent.BindCommand(addItem, m => m.Add());
                fluent.BindCommand(editItem, m => m.Edit(null), m => m.Selected);
                fluent.BindCommand(deleteItem, m => m.Delete(null), m => m.Selection);

                //e.Menu.Items.Add(addItem);
                e.Menu.Items.Add(editItem);
                e.Menu.Items.Add(deleteItem);
            }
        }

        protected virtual DXMenuItem CreateMenuItemAdd(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Add");
            menuItemAdd.ImageOptions.Image = ic16x16.Images[0];
            return menuItemAdd;
        }

        protected virtual DXMenuItem CreateMenuItemEdit(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Edit");
            menuItemAdd.ImageOptions.Image = ic16x16.Images[1];
            return menuItemAdd;
        }

        protected virtual DXMenuItem CreateMenuItemDelete(GridView view, int rowHandle)
        {
            DXMenuItem menuItemAdd = new DXMenuItem("&Delete");
            menuItemAdd.ImageOptions.Image = ic16x16.Images[2];
            return menuItemAdd;
        }
        #endregion
    }
}
