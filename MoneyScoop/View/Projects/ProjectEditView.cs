using System;
using MoneyScoop.ViewModel.Projects;
using MoneyScoop.Model;

namespace MoneyScoop.View.Projects
{
    public partial class ProjectEditView : BaseEditView
    {
        public ProjectEditView()
        {
            InitializeModel(typeof(ProjectEditViewModel));
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
                InitBindings<Project, ProjectEditViewModel>();
            }
        }
    }
}
