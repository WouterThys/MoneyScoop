using System;
using MoneyScoop.ViewModel;
using DevExpress.Utils.MVVM.Services;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace MoneyScoop.View
{
    public partial class SendMailView : BaseUserControl
    {
        public SendMailView()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeModel(typeof(SendMailViewModel));
                InitializeLayouts();
                InitializeServices();
            }
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            
        }

        protected override void InitializeServices()
        {
            base.InitializeServices();
            mvvmContext.RegisterService("DialogService", DialogService.Create(this, "Dialog", () => new BaseDialogForm()));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = mvvmContext.OfType<SendMailViewModel>();

                fluent.SetObjectDataSourceBinding(bsModel);

                fluent.SetBinding(this, t => t.Cursor, m => m.IsLoading, (loading) => loading ? Cursors.WaitCursor : Cursors.Default);
            }
        }

        public void InitializeBindings(SendMailViewModel viewModel)
        {
            InitializeModel(typeof(SendMailViewModel), viewModel);
            var fluent = mvvmContext.OfType<SendMailViewModel>();

            fluent.SetObjectDataSourceBinding(bsModel);

            fluent.SetBinding(this, t => t.Cursor, m => m.IsLoading, (loading) => loading ? Cursors.WaitCursor : Cursors.Default);
        }
    }
}
