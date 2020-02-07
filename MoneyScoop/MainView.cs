using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Ribbon;
using MoneyScoop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyScoop
{
    public partial class MainView : RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
            {
                InitializeBindings();
                InitializeServices();
                InitializeLayouts();
            }
        }

        private void InitializeLayouts()
        {
            documentManager.RibbonAndBarsMergeStyle = RibbonAndBarsMergeStyle.WhenNotFloating;
            Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
            Ribbon.Merge += Ribbon_Merge;
            
        }

        private void InitializeServices()
        {
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView1));
            mvvmContext.RegisterService(MessageBoxService.Create(DefaultMessageBoxServiceType.XtraMessageBox));
            mvvmContext.RegisterService("FloatingDocumentService", WindowedDocumentManagerService.CreateXtraFormService(this));
            mvvmContext.RegisterDefaultService("DataChangedService", new DataChangedService());
        }

        private void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<MainViewModel>();

            // Events
            fluent.WithEvent(this, "Load").EventToCommand(x => x.Load());
            fluent.WithEvent<FormClosingEventArgs>(this, "FormClosing").EventToCommand(m => m.OnClose(null), new Func<CancelEventArgs, object>((args) => args));
        }

        #region Events
        private void Ribbon_Merge(object sender, RibbonMergeEventArgs e)
        {
            if (e.MergeOwner.MergedPages.Count > 0)
            {
                e.MergeOwner.SelectedPage = e.MergeOwner.MergedPages[0];
            }
        }

        #endregion
    }
}
