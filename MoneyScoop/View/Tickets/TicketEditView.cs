using System;
using MoneyScoop.ViewModel.Tickets;
using MoneyScoop.Model;

namespace MoneyScoop.View.Tickets
{
    public partial class TicketEditView : BaseEditView
    {
        public TicketEditView()
        {
            InitializeModel(typeof(TicketEditViewModel));
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
                InitBindings<Ticket, TicketEditViewModel>();
            }
        }
    }
}
