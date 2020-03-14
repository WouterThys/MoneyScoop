using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;

namespace MoneyScoop.View
{
    public partial class InvoiceLineEditView : BaseEditView
    {
        public InvoiceLineEditView()
        {
            InitializeModel(typeof(InvoiceLineEditViewModel));
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

            ViewHelpers.SetTextAlignment(
                UnitPriceTextEdit,
                MultiplierTextEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<InvoiceLine, InvoiceLineEditViewModel>();
            }
        }
    }
}
