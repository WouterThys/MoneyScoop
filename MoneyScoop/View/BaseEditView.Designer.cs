namespace MoneyScoop.View
{
    partial class BaseEditView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndDone = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopy = new DevExpress.XtraBars.BarButtonItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.InfoTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.lcgId = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSave,
            this.bbiSaveAndDone,
            this.bbiDelete,
            this.bbiReset,
            this.bbiCopy});
            this.ribbonControl.MaxItemId = 6;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.MainPage});
            // 
            // MainPage
            // 
            this.MainPage.ItemLinks.Add(this.bbiSave);
            this.MainPage.ItemLinks.Add(this.bbiSaveAndDone);
            this.MainPage.ItemLinks.Add(this.bbiDelete);
            this.MainPage.ItemLinks.Add(this.bbiReset);
            this.MainPage.ItemLinks.Add(this.bbiCopy);
            this.MainPage.Name = "MainPage";
            this.MainPage.Text = "Main";
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageOptions.ImageIndex = 9;
            this.bbiSave.ImageOptions.LargeImageIndex = 9;
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndDone
            // 
            this.bbiSaveAndDone.Caption = "Done";
            this.bbiSaveAndDone.Id = 2;
            this.bbiSaveAndDone.ImageOptions.ImageIndex = 10;
            this.bbiSaveAndDone.ImageOptions.LargeImageIndex = 10;
            this.bbiSaveAndDone.Name = "bbiSaveAndDone";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset";
            this.bbiReset.Id = 4;
            this.bbiReset.ImageOptions.ImageIndex = 7;
            this.bbiReset.ImageOptions.LargeImageIndex = 7;
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiCopy
            // 
            this.bbiCopy.Caption = "Copy";
            this.bbiCopy.Id = 5;
            this.bbiCopy.ImageOptions.ImageIndex = 3;
            this.bbiCopy.ImageOptions.LargeImageIndex = 3;
            this.bbiCopy.Name = "bbiCopy";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.BaseObject);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl.Controls.Add(this.InfoTextEdit);
            this.dataLayoutControl.DataSource = this.bindingSource;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 158);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(452, 271);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(452, 271);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgId});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(432, 251);
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Code", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CodeTextEdit.Location = new System.Drawing.Point(89, 49);
            this.CodeTextEdit.MenuManager = this.ribbonControl;
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CodeTextEdit.Size = new System.Drawing.Size(339, 20);
            this.CodeTextEdit.StyleController = this.dataLayoutControl;
            this.CodeTextEdit.TabIndex = 4;
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(408, 24);
            this.ItemForCode.Text = "Code";
            this.ItemForCode.TextSize = new System.Drawing.Size(53, 13);
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(89, 73);
            this.DescriptionTextEdit.MenuManager = this.ribbonControl;
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(339, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl;
            this.DescriptionTextEdit.TabIndex = 5;
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 24);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(408, 24);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoTextEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 48);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(408, 154);
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForInfo.TextSize = new System.Drawing.Size(53, 13);
            // 
            // InfoTextEdit
            // 
            this.InfoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfoTextEdit.Location = new System.Drawing.Point(24, 113);
            this.InfoTextEdit.MenuManager = this.ribbonControl;
            this.InfoTextEdit.Name = "InfoTextEdit";
            this.InfoTextEdit.Size = new System.Drawing.Size(404, 134);
            this.InfoTextEdit.StyleController = this.dataLayoutControl;
            this.InfoTextEdit.TabIndex = 6;
            // 
            // lcgId
            // 
            this.lcgId.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCode,
            this.ItemForDescription,
            this.ItemForInfo});
            this.lcgId.Location = new System.Drawing.Point(0, 0);
            this.lcgId.Name = "lcgId";
            this.lcgId.Size = new System.Drawing.Size(432, 251);
            this.lcgId.Text = "Identification";
            // 
            // BaseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "BaseEditView";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraBars.BarButtonItem bbiSave;
        protected DevExpress.XtraBars.BarButtonItem bbiSaveAndDone;
        protected DevExpress.XtraBars.BarButtonItem bbiDelete;
        protected DevExpress.XtraBars.BarButtonItem bbiReset;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup MainPage;
        protected DevExpress.XtraBars.BarButtonItem bbiCopy;
        protected System.Windows.Forms.BindingSource bindingSource;
        protected DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        protected DevExpress.XtraLayout.LayoutControlGroup Root;
        protected DevExpress.XtraEditors.TextEdit CodeTextEdit;
        protected DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        protected DevExpress.XtraEditors.MemoEdit InfoTextEdit;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgId;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        protected DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}
