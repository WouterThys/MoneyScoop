using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.ViewModel.Projects;
using DevExpress.Utils.MVVM.Services;
using System;
using System.Windows.Forms;
using DevExpress.Data;
using System.Collections.Generic;
using System.Linq;
using MoneyScoop.Utils;
using DevExpress.XtraGrid.Views.Base;

namespace MoneyScoop.View.Projects
{
    public partial class ProjectListView : BaseRibbonControl
    {
        public ProjectListView()
        {
            InitializeModel(typeof(ProjectListViewModel));
            InitializeComponent();
            InitializeLayouts();
            if (!DesignMode)
            {
                InitializeServices();
                InitializeBindings();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            Ribbon.MergeRibbon(ticketListView.Ribbon);
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
            //gridControl.ForceInitialize();
        }

        private void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<ProjectListViewModel>();

            // Events
            fluent.WithEvent<EventArgs>(this, "Load").EventToCommand(m => m.Load());

            // GridView
            //fluent.SetBinding(tvProjects, tv => tv.LoadingPanelVisible, m => m.IsLoading);
            fluent.SetObjectDataSourceBinding(bsProjects, m => m.Entities, m => m.UpdateCommands());

            // GridView - Row double clicked
            fluent.WithEvent<RowClickEventArgs>(tvProjects, "RowClick").EventToCommand(
                    m => m.Edit(null),
                    m => m.Selected,
                    args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));

            // GridView - Multiple selected
            fluent.WithEvent<FocusedRowChangedEventArgs>(tvProjects, "FocusedRowChanged").SetBinding(
                m => m.Selected,
                e => tvProjects.GetRow(e.FocusedRowHandle) as Project);


            // GridView - Keys
            fluent.WithEvent<KeyEventArgs>(tvProjects, "KeyDown").EventToCommand(
                m => m.KeyPressed(null));

            // Ribbon
            fluent.BindCommand(bbiAdd, m => m.Add());
            fluent.BindCommand(bbiEdit, m => m.Edit(null), m => m.Selected);
            fluent.BindCommand(bbiDelete, m => m.Delete(null), m => m.Selection);

            // Tickets
            ticketListView.InitializeBindings(fluent.ViewModel.TicketListViewModel);
        }
    }
}
