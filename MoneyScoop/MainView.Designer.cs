namespace MoneyScoop
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.behaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelNavigation = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceInvoiceIncoming = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceInvoiceOutgoing = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceCusomers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanelNavigation.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(1574, 60);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(MoneyScoop.MainViewModel);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbonControl1;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelNavigation});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanelNavigation
            // 
            this.dockPanelNavigation.Controls.Add(this.dockPanel1_Container);
            this.dockPanelNavigation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelNavigation.ID = new System.Guid("213f10cd-add6-4101-bb1b-0d3e02a13ed6");
            this.dockPanelNavigation.Location = new System.Drawing.Point(0, 60);
            this.dockPanelNavigation.Name = "dockPanelNavigation";
            this.dockPanelNavigation.OriginalSize = new System.Drawing.Size(300, 200);
            this.dockPanelNavigation.Size = new System.Drawing.Size(300, 618);
            this.dockPanelNavigation.Text = "Navigation";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.accordionControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(293, 585);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceGroup});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(293, 585);
            this.accordionControl.TabIndex = 0;
            this.accordionControl.Text = "accordionControl1";
            // 
            // aceGroup
            // 
            this.aceGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceInvoiceIncoming,
            this.aceInvoiceOutgoing,
            this.aceCusomers});
            this.aceGroup.Expanded = true;
            this.aceGroup.Name = "aceGroup";
            this.aceGroup.Text = "Select";
            // 
            // aceInvoiceIncoming
            // 
            this.aceInvoiceIncoming.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceInvoiceIncoming.ImageOptions.Image")));
            this.aceInvoiceIncoming.Name = "aceInvoiceIncoming";
            this.aceInvoiceIncoming.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceInvoiceIncoming.Text = "Incomingsss";
            // 
            // aceInvoiceOutgoing
            // 
            this.aceInvoiceOutgoing.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceInvoiceOutgoing.ImageOptions.Image")));
            this.aceInvoiceOutgoing.Name = "aceInvoiceOutgoing";
            this.aceInvoiceOutgoing.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceInvoiceOutgoing.Text = "Outgoing";
            // 
            // aceCusomers
            // 
            this.aceCusomers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceCusomers.ImageOptions.Image")));
            this.aceCusomers.Name = "aceCusomers";
            this.aceCusomers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceCusomers.Text = "Customers";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.behaviorManager.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForForm), null, DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.True)))});
            this.ClientSize = new System.Drawing.Size(1574, 678);
            this.Controls.Add(this.dockPanelNavigation);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainView.IconOptions.Image")));
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl1;
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanelNavigation.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelNavigation;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGroup;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInvoiceIncoming;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceInvoiceOutgoing;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceCusomers;
    }
}

