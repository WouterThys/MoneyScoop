using System;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                var fluent = InitBindings<Customer, CustomerEditViewModel>();

                
            }
        }
    }
}
