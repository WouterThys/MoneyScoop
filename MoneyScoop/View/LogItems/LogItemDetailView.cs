using MoneyScoop.ViewModel;
using MoneyScoop.Utils;
using DevExpress.XtraGrid.Views.Grid;
using MoneyScoop.Model;
using DevExpress.Data;
using System.Collections.Generic;
using System.Linq;
using MoneyScoop.ViewModel.LogItems;
using DevExpress.Utils;

namespace MoneyScoop.View.LogItems
{
    public partial class LogItemDetailView : BaseUserControl
    {
        public LogItemDetailView()
        {
            InitializeModel(typeof(LogItemDetailsViewModel));
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();

            StartTimeDateEdit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            StartTimeDateEdit.Properties.DisplayFormat.FormatString = LogItemEditView.dtFormat;
            StartTimeDateEdit.Properties.EditMask = LogItemEditView.dtFormat;
            StartTimeDateEdit.Properties.ShowToday = true;

            StopTimeDateEdit.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            StopTimeDateEdit.Properties.DisplayFormat.FormatString = LogItemEditView.dtFormat;
            StopTimeDateEdit.Properties.EditMask = LogItemEditView.dtFormat;
            StopTimeDateEdit.Properties.ShowToday = true;

            //ViewHelpers.InitializeGridView(gvInvoices);
        }

        public void InitializeBindings(LogItemDetailsViewModel model)
        {
            if (!DesignMode)
            {
                InitializeModel(typeof(LogItemDetailsViewModel), model);
                var fluent = mvvmContext.OfType<LogItemDetailsViewModel>();

                fluent.SetObjectDataSourceBinding(bsLogItem, m => m.Entity);
                //fluent.SetObjectDataSourceBinding(bsCustomer, m => m.Entity);

                fluent.SetBinding(TitelLabel, lbl => lbl.Text, m => m.Entity.Code);

                

            }
        }
    }
}
