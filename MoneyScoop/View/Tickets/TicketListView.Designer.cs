namespace MoneyScoop.View.Tickets
{
    partial class TicketListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketListView));
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            this.SuspendLayout();
            // 
            // bbiAdd
            // 
            this.bbiAdd.ImageOptions.ImageIndex = 0;
            this.bbiAdd.ImageOptions.LargeImageIndex = 0;
            // 
            // bbiEdit
            // 
            this.bbiEdit.ImageOptions.ImageIndex = 1;
            this.bbiEdit.ImageOptions.LargeImageIndex = 1;
            // 
            // bbiDelete
            // 
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            // 
            // MainGroup
            // 
            this.MainGroup.Text = "Tickets";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.Ticket);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colState,
            this.colType});
            // 
            // colLastModified
            // 
            this.colLastModified.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
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
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.MinWidth = 25;
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            this.colState.Width = 94;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.MinWidth = 25;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            this.colType.Width = 94;
            // 
            // TicketListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketListView";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
    }
}
