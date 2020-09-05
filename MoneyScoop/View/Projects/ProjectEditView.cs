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
