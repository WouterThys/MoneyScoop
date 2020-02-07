namespace MoneyScoop.View
{
    partial class BaseListView
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseUserControl));
            this.MainGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            this.SuspendLayout();
            //// 
            //// ic16x16
            //// 
            //this.ic16x16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic16x16.ImageStream")));
            //this.ic16x16.Images.SetKeyName(0, "add.png");
            //this.ic16x16.Images.SetKeyName(1, "pencil.png");
            //this.ic16x16.Images.SetKeyName(2, "delete.png");
            //this.ic16x16.Images.SetKeyName(3, "copy.png");
            //this.ic16x16.Images.SetKeyName(4, "cut.png");
            //this.ic16x16.Images.SetKeyName(5, "paste.png");
            //this.ic16x16.Images.SetKeyName(6, "refresh.png");
            //this.ic16x16.Images.SetKeyName(7, "undo.png");
            //this.ic16x16.Images.SetKeyName(8, "redo.png");
            //this.ic16x16.Images.SetKeyName(9, "floppy_disk.png");
            //this.ic16x16.Images.SetKeyName(10, "floppy_disk_ok.png");
            //this.ic16x16.Images.SetKeyName(11, "hand_money.png");
            //this.ic16x16.Images.SetKeyName(12, "invoice_euro.png");
            //this.ic16x16.Images.SetKeyName(13, "table_row.png");
            //// 
            //// ic24x24
            //// 
            //this.ic24x24.ImageSize = new System.Drawing.Size(24, 24);
            //this.ic24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic24x24.ImageStream")));
            //this.ic24x24.Images.SetKeyName(0, "add.png");
            //this.ic24x24.Images.SetKeyName(1, "pencil.png");
            //this.ic24x24.Images.SetKeyName(2, "delete.png");
            //this.ic24x24.Images.SetKeyName(3, "copy.png");
            //this.ic24x24.Images.SetKeyName(4, "cut.png");
            //this.ic24x24.Images.SetKeyName(5, "paste.png");
            //this.ic24x24.Images.SetKeyName(6, "refresh.png");
            //this.ic24x24.Images.SetKeyName(7, "undo.png");
            //this.ic24x24.Images.SetKeyName(8, "redo.png");
            //this.ic24x24.Images.SetKeyName(9, "floppy_disk.png");
            //this.ic24x24.Images.SetKeyName(10, "floppy_disk_ok.png");
            //this.ic24x24.Images.SetKeyName(11, "hand_money.png");
            //this.ic24x24.Images.SetKeyName(12, "invoice_euro.png");
            //this.ic24x24.Images.SetKeyName(13, "table_row.png");
            //// 
            //// ic48x48
            //// 
            //this.ic48x48.ImageSize = new System.Drawing.Size(48, 48);
            //this.ic48x48.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic48x48.ImageStream")));
            //this.ic48x48.Images.SetKeyName(0, "add.png");
            //this.ic48x48.Images.SetKeyName(1, "pencil.png");
            //this.ic48x48.Images.SetKeyName(2, "delete.png");
            //this.ic48x48.Images.SetKeyName(3, "copy.png");
            //this.ic48x48.Images.SetKeyName(4, "cut.png");
            //this.ic48x48.Images.SetKeyName(5, "paste.png");
            //this.ic48x48.Images.SetKeyName(6, "refresh.png");
            //this.ic48x48.Images.SetKeyName(7, "undo.png");
            //this.ic48x48.Images.SetKeyName(8, "redo.png");
            //this.ic48x48.Images.SetKeyName(9, "floppy_disk.png");
            //this.ic48x48.Images.SetKeyName(10, "floppy_disk_ok.png");
            //this.ic48x48.Images.SetKeyName(11, "hand_money.png");
            //this.ic48x48.Images.SetKeyName(12, "invoice_euro.png");
            //this.ic48x48.Images.SetKeyName(13, "table_row.png");
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ribbonControl.MaxItemId = 4;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(1058, 194);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.MainGroup});
            
            // 
            // MainGroup
            // 
            this.MainGroup.ItemLinks.Add(this.bbiAdd);
            this.MainGroup.ItemLinks.Add(this.bbiEdit);
            this.MainGroup.ItemLinks.Add(this.bbiDelete);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Text = "Main";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 1;
            this.bbiAdd.ImageOptions.ImageIndex = 0;
            this.bbiAdd.ImageOptions.LargeImageIndex = 0;
            this.bbiAdd.Name = "bbiAdd";
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageOptions.ImageIndex = 1;
            this.bbiEdit.ImageOptions.LargeImageIndex = 1;
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.BaseObject);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 194);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1058, 446);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colDescription,
            this.colInfo,
            this.colLastModified});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 24;
            this.colId.Name = "colId";
            this.colId.Width = 87;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 24;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 87;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 24;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 87;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 24;
            this.colInfo.Name = "colInfo";
            this.colInfo.Width = 87;
            // 
            // colLastModified
            // 
            this.colLastModified.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.MinWidth = 24;
            this.colLastModified.Name = "colLastModified";
            this.colLastModified.Width = 87;
            // 
            // BaseListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "BaseListView";
            this.Size = new System.Drawing.Size(1058, 640);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            //((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraBars.BarButtonItem bbiAdd;
        protected DevExpress.XtraBars.BarButtonItem bbiEdit;
        protected DevExpress.XtraBars.BarButtonItem bbiDelete;
        protected DevExpress.XtraBars.Ribbon.RibbonPageGroup MainGroup;
        protected System.Windows.Forms.BindingSource bindingSource;
        protected DevExpress.XtraGrid.GridControl gridControl;
        protected DevExpress.XtraGrid.Views.Grid.GridView gridView;
        protected DevExpress.XtraGrid.Columns.GridColumn colId;
        protected DevExpress.XtraGrid.Columns.GridColumn colCode;
        protected DevExpress.XtraGrid.Columns.GridColumn colDescription;
        protected DevExpress.XtraGrid.Columns.GridColumn colInfo;
        protected DevExpress.XtraGrid.Columns.GridColumn colLastModified;
    }
}
