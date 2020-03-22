using MoneyScoop.ViewModel.Invoices;
using MoneyScoop.Utils;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.XtraLayout.Utils;
using System.Linq.Expressions;
using System;

namespace MoneyScoop.View.Invoices
{
    public partial class IncomingInvoiceDetailView : BaseUserControl
    {

        public IncomingInvoiceDetailView()
        {
            InitializeModel(typeof(IncomingInvoiceDetailsViewModel));
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            ViewHelpers.InitializeGridView(gvInvoiceLines);
            ViewHelpers.SetTextAlignment(SubTotalTextEdit, TotalTextEdit, VATTextEdit);
        }

        public void InitialiseBindings(IncomingInvoiceDetailsViewModel model)
        {
            if (!DesignMode)
            {
                InitializeModel(typeof(IncomingInvoiceDetailsViewModel), model);
                var fluent = mvvmContext.OfType<IncomingInvoiceDetailsViewModel>();

                fluent.SetObjectDataSourceBinding(bsInvoiceLines, m => m.InvoiceLines);
                fluent.SetObjectDataSourceBinding(bsInvoice, m => m.Entity);

                fluent.SetBinding(CodeLabel, lbl => lbl.Text, m => m.Entity.Code);

                SetupLabels(fluent, ItemForCreated, CreatedLabel, m => m.Entity.IsPdfSaved, m => m.Entity.DateModifiedString);
                SetupLabels(fluent, ItemForSend, SendLabel, m => m.Entity.IsSend, m => m.Entity.DateSendString);
                SetupLabels(fluent, ItemForPayed, PayedLabel, m => m.Entity.IsPayed, m => m.Entity.DatePayedString);
                SetupLabels(fluent, ItemForSendToBooky, LabelSendToBooky, m => m.Entity.IsSendToBooky, m => m.Entity.DateSendToBookyString);
            }
        }

        private void SetupLabels(
            MVVMContextFluentAPI<IncomingInvoiceDetailsViewModel> f, 
            LayoutControlItem lci, LabelControl lbl, 
            Expression<Func<IncomingInvoiceDetailsViewModel, bool>> isVisibleExp,
            Expression<Func<IncomingInvoiceDetailsViewModel, string>> tooltipExp)
        {
            f.SetBinding(lci, itm => itm.Visibility, isVisibleExp, v => v ? LayoutVisibility.Always : LayoutVisibility.Never);
            f.SetBinding(lbl, l => l.ToolTip, tooltipExp);
        }
    }
}
