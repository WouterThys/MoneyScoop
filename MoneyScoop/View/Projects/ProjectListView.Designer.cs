namespace MoneyScoop.View.Projects
{
    partial class ProjectListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListView));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colCode = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.rpgProjects = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcProjects = new DevExpress.XtraGrid.GridControl();
            this.bsProjects = new System.Windows.Forms.BindingSource(this.components);
            this.tvProjects = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.ribbonControl.MaxItemId = 4;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(1206, 194);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgProjects});
            // 
            // ic16x16
            // 
            this.ic16x16.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic16x16.ImageStream")));
            this.ic16x16.Images.SetKeyName(0, "add.png");
            this.ic16x16.Images.SetKeyName(1, "pencil.png");
            this.ic16x16.Images.SetKeyName(2, "delete.png");
            this.ic16x16.Images.SetKeyName(3, "copy.png");
            this.ic16x16.Images.SetKeyName(4, "cut.png");
            this.ic16x16.Images.SetKeyName(5, "paste.png");
            this.ic16x16.Images.SetKeyName(6, "refresh.png");
            this.ic16x16.Images.SetKeyName(7, "undo.png");
            this.ic16x16.Images.SetKeyName(8, "redo.png");
            this.ic16x16.Images.SetKeyName(9, "floppy_disk.png");
            this.ic16x16.Images.SetKeyName(10, "floppy_disk_ok.png");
            this.ic16x16.Images.SetKeyName(11, "hand_money.png");
            this.ic16x16.Images.SetKeyName(12, "invoice_euro.png");
            this.ic16x16.Images.SetKeyName(13, "table_row.png");
            this.ic16x16.Images.SetKeyName(14, "cashier.png");
            this.ic16x16.Images.SetKeyName(15, "table_row_add.png");
            this.ic16x16.Images.SetKeyName(16, "table_row_edit.png");
            this.ic16x16.Images.SetKeyName(17, "table_row_delete.png");
            this.ic16x16.Images.SetKeyName(18, "mail_ok.png");
            this.ic16x16.Images.SetKeyName(19, "moneybag2_ok.png");
            this.ic16x16.Images.SetKeyName(20, "mail.png");
            this.ic16x16.Images.SetKeyName(21, "mail_forward.png");
            this.ic16x16.Images.SetKeyName(22, "document_ok.png");
            this.ic16x16.Images.SetKeyName(23, "document.png");
            this.ic16x16.Images.SetKeyName(24, "bookkeeper.png");
            this.ic16x16.Images.SetKeyName(25, "bookkeeper_ok.png");
            this.ic16x16.Images.SetKeyName(26, "symbol_percent.png");
            this.ic16x16.Images.SetKeyName(27, "calendar_warning.png");
            this.ic16x16.Images.SetKeyName(28, "money_bills.png");
            this.ic16x16.Images.SetKeyName(29, "symbol_sum.png");
            this.ic16x16.Images.SetKeyName(30, "information.png");
            this.ic16x16.Images.SetKeyName(31, "symbol_hash.png");
            this.ic16x16.Images.SetKeyName(32, "telephone2.png");
            this.ic16x16.Images.SetKeyName(33, "chest_into.png");
            this.ic16x16.Images.SetKeyName(34, "chest_out.png");
            this.ic16x16.Images.SetKeyName(35, "folder_document.png");
            this.ic16x16.Images.SetKeyName(36, "blueprint.png");
            this.ic16x16.Images.SetKeyName(37, "odometer.png");
            this.ic16x16.Images.SetKeyName(38, "ticket_yellow.png");
            this.ic16x16.Images.SetKeyName(39, "ticket_blue.png");
            this.ic16x16.Images.SetKeyName(40, "ticket_green.png");
            this.ic16x16.Images.SetKeyName(41, "ticket_red.png");
            // 
            // ic24x24
            // 
            this.ic24x24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic24x24.ImageStream")));
            this.ic24x24.Images.SetKeyName(0, "add.png");
            this.ic24x24.Images.SetKeyName(1, "pencil.png");
            this.ic24x24.Images.SetKeyName(2, "delete.png");
            this.ic24x24.Images.SetKeyName(3, "copy.png");
            this.ic24x24.Images.SetKeyName(4, "cut.png");
            this.ic24x24.Images.SetKeyName(5, "paste.png");
            this.ic24x24.Images.SetKeyName(6, "refresh.png");
            this.ic24x24.Images.SetKeyName(7, "undo.png");
            this.ic24x24.Images.SetKeyName(8, "redo.png");
            this.ic24x24.Images.SetKeyName(9, "floppy_disk.png");
            this.ic24x24.Images.SetKeyName(10, "floppy_disk_ok.png");
            this.ic24x24.Images.SetKeyName(11, "hand_money.png");
            this.ic24x24.Images.SetKeyName(12, "invoice_euro.png");
            this.ic24x24.Images.SetKeyName(13, "table_row.png");
            this.ic24x24.Images.SetKeyName(14, "cashier.png");
            this.ic24x24.Images.SetKeyName(15, "table_row_add.png");
            this.ic24x24.Images.SetKeyName(16, "table_row_edit.png");
            this.ic24x24.Images.SetKeyName(17, "table_row_delete.png");
            this.ic24x24.Images.SetKeyName(18, "mail_ok.png");
            this.ic24x24.Images.SetKeyName(19, "moneybag2_ok.png");
            this.ic24x24.Images.SetKeyName(20, "mail.png");
            this.ic24x24.Images.SetKeyName(21, "mail_forward.png");
            this.ic24x24.Images.SetKeyName(22, "document_ok.png");
            this.ic24x24.Images.SetKeyName(23, "document.png");
            this.ic24x24.Images.SetKeyName(24, "bookkeeper.png");
            this.ic24x24.Images.SetKeyName(25, "bookkeeper_ok.png");
            this.ic24x24.Images.SetKeyName(26, "symbol_percent.png");
            this.ic24x24.Images.SetKeyName(27, "calendar_warning.png");
            this.ic24x24.Images.SetKeyName(28, "money_bills.png");
            this.ic24x24.Images.SetKeyName(29, "symbol_sum.png");
            this.ic24x24.Images.SetKeyName(30, "information.png");
            this.ic24x24.Images.SetKeyName(31, "symbol_hash.png");
            this.ic24x24.Images.SetKeyName(32, "telephone2.png");
            this.ic24x24.Images.SetKeyName(33, "chest_into.png");
            this.ic24x24.Images.SetKeyName(34, "chest_out.png");
            this.ic24x24.Images.SetKeyName(35, "folder_document.png");
            this.ic24x24.Images.SetKeyName(36, "blueprint.png");
            this.ic24x24.Images.SetKeyName(37, "odometer.png");
            this.ic24x24.Images.SetKeyName(38, "ticket_yellow.png");
            this.ic24x24.Images.SetKeyName(39, "ticket_blue.png");
            this.ic24x24.Images.SetKeyName(40, "ticket_green.png");
            this.ic24x24.Images.SetKeyName(41, "ticket_red.png");
            // 
            // ic48x48
            // 
            this.ic48x48.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ic48x48.ImageStream")));
            this.ic48x48.Images.SetKeyName(0, "add.png");
            this.ic48x48.Images.SetKeyName(1, "pencil.png");
            this.ic48x48.Images.SetKeyName(2, "delete.png");
            this.ic48x48.Images.SetKeyName(3, "copy.png");
            this.ic48x48.Images.SetKeyName(4, "cut.png");
            this.ic48x48.Images.SetKeyName(5, "paste.png");
            this.ic48x48.Images.SetKeyName(6, "refresh.png");
            this.ic48x48.Images.SetKeyName(7, "undo.png");
            this.ic48x48.Images.SetKeyName(8, "redo.png");
            this.ic48x48.Images.SetKeyName(9, "floppy_disk.png");
            this.ic48x48.Images.SetKeyName(10, "floppy_disk_ok.png");
            this.ic48x48.Images.SetKeyName(11, "hand_money.png");
            this.ic48x48.Images.SetKeyName(12, "invoice_euro.png");
            this.ic48x48.Images.SetKeyName(13, "table_row.png");
            this.ic48x48.Images.SetKeyName(14, "cashier.png");
            this.ic48x48.Images.SetKeyName(15, "table_row_add.png");
            this.ic48x48.Images.SetKeyName(16, "table_row_edit.png");
            this.ic48x48.Images.SetKeyName(17, "table_row_delete.png");
            this.ic48x48.Images.SetKeyName(18, "mail_ok.png");
            this.ic48x48.Images.SetKeyName(19, "moneybag2_ok.png");
            this.ic48x48.Images.SetKeyName(20, "mail.png");
            this.ic48x48.Images.SetKeyName(21, "mail_forward.png");
            this.ic48x48.Images.SetKeyName(22, "document_ok.png");
            this.ic48x48.Images.SetKeyName(23, "document.png");
            this.ic48x48.Images.SetKeyName(24, "bookkeeper.png");
            this.ic48x48.Images.SetKeyName(25, "bookkeeper_ok.png");
            this.ic48x48.Images.SetKeyName(26, "symbol_percent.png");
            this.ic48x48.Images.SetKeyName(27, "calendar_warning.png");
            this.ic48x48.Images.SetKeyName(28, "money_bills.png");
            this.ic48x48.Images.SetKeyName(29, "symbol_sum.png");
            this.ic48x48.Images.SetKeyName(30, "information.png");
            this.ic48x48.Images.SetKeyName(31, "symbol_hash.png");
            this.ic48x48.Images.SetKeyName(32, "telephone2.png");
            this.ic48x48.Images.SetKeyName(33, "chest_into.png");
            this.ic48x48.Images.SetKeyName(34, "chest_out.png");
            this.ic48x48.Images.SetKeyName(35, "folder_document.png");
            this.ic48x48.Images.SetKeyName(36, "blueprint.png");
            this.ic48x48.Images.SetKeyName(37, "odometer.png");
            this.ic48x48.Images.SetKeyName(38, "ticket_yellow.png");
            this.ic48x48.Images.SetKeyName(39, "ticket_blue.png");
            this.ic48x48.Images.SetKeyName(40, "ticket_green.png");
            this.ic48x48.Images.SetKeyName(41, "ticket_red.png");
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 94;
            // 
            // rpgProjects
            // 
            this.rpgProjects.ItemLinks.Add(this.bbiAdd);
            this.rpgProjects.ItemLinks.Add(this.bbiEdit);
            this.rpgProjects.ItemLinks.Add(this.bbiDelete);
            this.rpgProjects.Name = "rpgProjects";
            this.rpgProjects.Text = "Projects";
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
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 194);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.gcProjects);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1206, 460);
            this.splitContainerControl.SplitterPosition = 315;
            this.splitContainerControl.TabIndex = 1;
            // 
            // gcProjects
            // 
            this.gcProjects.DataSource = this.bsProjects;
            this.gcProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProjects.Location = new System.Drawing.Point(0, 0);
            this.gcProjects.MainView = this.tvProjects;
            this.gcProjects.MenuManager = this.ribbonControl;
            this.gcProjects.Name = "gcProjects";
            this.gcProjects.Size = new System.Drawing.Size(315, 460);
            this.gcProjects.TabIndex = 0;
            this.gcProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvProjects});
            // 
            // bsProjects
            // 
            this.bsProjects.DataSource = typeof(MoneyScoop.Model.Project);
            // 
            // tvProjects
            // 
            this.tvProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colDescription,
            this.colInfo});
            this.tvProjects.GridControl = this.gcProjects;
            this.tvProjects.Name = "tvProjects";
            this.tvProjects.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tvProjects.OptionsTiles.IndentBetweenGroups = 0;
            this.tvProjects.OptionsTiles.IndentBetweenItems = 0;
            this.tvProjects.OptionsTiles.ItemSize = new System.Drawing.Size(248, 90);
            this.tvProjects.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tvProjects.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tvProjects.OptionsTiles.Padding = new System.Windows.Forms.Padding(14);
            this.tvProjects.OptionsTiles.RowCount = 0;
            this.tvProjects.TileColumns.Add(tableColumnDefinition1);
            this.tvProjects.TileRows.Add(tableRowDefinition1);
            this.tvProjects.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.FontSizeDelta = 2;
            tileViewItemElement1.Appearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colCode;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colCode";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.Column = this.colDescription;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colDescription";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tvProjects.TileTemplate.Add(tileViewItemElement1);
            this.tvProjects.TileTemplate.Add(tileViewItemElement2);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.MinWidth = 25;
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 3;
            this.colInfo.Width = 94;
            // 
            // ProjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "ProjectListView";
            this.Size = new System.Drawing.Size(1206, 654);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.splitContainerControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgProjects;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraGrid.GridControl gcProjects;
        private System.Windows.Forms.BindingSource bsProjects;
        private DevExpress.XtraGrid.Views.Tile.TileView tvProjects;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCode;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colInfo;
    }
}
