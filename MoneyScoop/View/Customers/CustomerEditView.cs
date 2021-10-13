using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;
using MoneyScoop.Utils;

namespace MoneyScoop.View
{
    public partial class CustomerEditView : BaseEditView
    {
        public CustomerEditView()
        {
            InitializeModel(typeof(CustomerEditViewModel));
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

            ViewHelpers.SetTextAlignment(DefaultUnitPriceTextEdit);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                InitBindings<Customer, CustomerEditViewModel>();               
            }
        }
    }
}
