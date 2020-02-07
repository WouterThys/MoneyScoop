using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;

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
