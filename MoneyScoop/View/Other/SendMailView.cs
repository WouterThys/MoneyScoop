using System;
using MoneyScoop.ViewModel;
using DevExpress.Utils.MVVM.Services;
using System.Windows.Forms;

namespace MoneyScoop.View
{
    public partial class SendMailView : BaseRibbonControl
    {
        public SendMailView()
        {
            InitializeModel(typeof(SendMailViewModel));
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
                fluent.BindCommand(bbiSend, m => m.SendMail());

                fluent.SetBinding(this, t => t.Cursor, m => m.IsLoading, (loading) => loading ? Cursors.WaitCursor : Cursors.Default);
            }
        }
    }
}
