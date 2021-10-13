using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;
using MoneyScoop.ViewModel.LogItems;
using DevExpress.Utils;

namespace MoneyScoop.View.LogItems
{ 
    public partial class LogItemEditView : BaseEditView
    {

        public const string dtFormat = "dd/MM HH:mm";

        public LogItemEditView()
        {
            InitializeModel(typeof(LogItemEditViewModel));
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

            ViewHelpers.InitializeSearchLookUpEdit(CustomerIdSearchLookUpEdit);

            StartTimeDateEdit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            StartTimeDateEdit.Properties.DisplayFormat.FormatString = dtFormat;
            StartTimeDateEdit.Properties.EditMask = dtFormat;
            StartTimeDateEdit.Properties.ShowToday = true;

            StopTimeDateEdit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            StopTimeDateEdit.Properties.DisplayFormat.FormatString = dtFormat;
            StopTimeDateEdit.Properties.EditMask = dtFormat;
            StopTimeDateEdit.Properties.ShowToday = true;


            //ViewHelpers.SetTextAlignment(DefaultUnitPriceTextEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<LogItem, LogItemEditViewModel>();
                fluent.SetObjectDataSourceBinding(bsCustomers, m => m.Customers);
            }
        }
    }
}
