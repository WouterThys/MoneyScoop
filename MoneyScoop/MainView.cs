using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using MoneyScoop.Services;
using MoneyScoop.ViewModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
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
            
            CultureInfo cultureInfo = new CultureInfo("nl-BE");
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            accordionControl.AllowItemSelection = true;
            aceInvoiceIncoming.Tag = ModuleTypes.IncomingInvoiceListModule;
            aceInvoiceOutgoing.Tag = ModuleTypes.OutgoingInvoiceListModule;
            aceCusomers.Tag = ModuleTypes.CustomerListModule;
        }

        private void InitializeServices()
        {
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView));
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
            fluent.WithEvent<AccordionControl, SelectedElementChangedEventArgs>(accordionControl, "SelectedElementChanged").SetBinding(
                (m) => m.ActiveModule,
                (args) => args.Element.Tag as IModuleType,
                (ac, mdl) =>
                {
                    if (mdl != null && ac.Elements != null)
                    {
                        foreach (var element in ac.Elements)
                        {
                            var found = element.Elements.Where(el => el.Tag != null && ((IModuleType)el.Tag).Id == mdl.Id).FirstOrDefault();
                            if (found != null)
                            {
                                ac.SelectedElement = found;
                                return;
                            }
                        }
                    }
                });
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
