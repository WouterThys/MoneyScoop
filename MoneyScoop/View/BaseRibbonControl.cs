using DevExpress.XtraBars.Ribbon;

namespace MoneyScoop.View
{
    public partial class BaseRibbonControl : BaseUserControl, IRibbonControl
    {
        public BaseRibbonControl()
        {
            InitializeComponent();
            Ribbon.Images = ic24x24;
            Ribbon.LargeImages = ic48x48;
        }

        public RibbonControl Ribbon { get { return ribbonControl; } }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            Ribbon.ShowPageHeadersMode = ShowPageHeadersMode.ShowOnMultiplePages;
            Ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            Ribbon.ShowQatLocationSelector = false;
            Ribbon.ShowToolbarCustomizeItem = false;
            Ribbon.ShowItemCaptionsInQAT = false;
            Ribbon.AllowCustomization = false;
        }
    }
}
