namespace MoneyScoop.View
{
    partial class OutgoingInvoiceListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingInvoiceListView));
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditPayed = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsSaved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditSend = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bbiCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPreviewReports = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveReports = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMail = new DevExpress.XtraBars.BarButtonItem();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPdfSaved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditSaved = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSaved)).BeginInit();
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
            this.MainGroup.ItemLinks.Add(this.bbiRefresh);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.Invoice);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCheckEditPayed,
            this.riCheckEditSend,
            this.riCheckEditSaved});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerCode,
            this.colCustomerId,
            this.colDateCreated,
            this.colDatePayed,
            this.colDateSend,
            this.colIsPayed,
            this.colIsSaved,
            this.colIsSend,
            this.colVAT,
            this.colDueDate,
            this.colIsPdfSaved});
            this.gridView.DetailHeight = 350;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateCreated, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.MinWidth = 21;
            this.colId.Width = 75;
            // 
            // colCode
            // 
            this.colCode.MinWidth = 21;
            this.colCode.Width = 75;
            // 
            // colDescription
            // 
            this.colDescription.MinWidth = 21;
            this.colDescription.Width = 75;
            // 
            // colInfo
            // 
            this.colInfo.MinWidth = 21;
            this.colInfo.Width = 75;
            // 
            // colLastModified
            // 
            this.colLastModified.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastModified.MinWidth = 21;
            this.colLastModified.Width = 75;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiCustomers,
            this.bbiPreviewReports,
            this.bbiSaveReports,
            this.bbiMail,
            this.bbiRefresh});
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 9;
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
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.MinWidth = 25;
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 3;
            this.colCustomerCode.Width = 94;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 25;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Width = 94;
            // 
            // colDateCreated
            // 
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.MinWidth = 25;
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 2;
            this.colDateCreated.Width = 94;
            // 
            // colDatePayed
            // 
            this.colDatePayed.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colDatePayed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDatePayed.FieldName = "DatePayed";
            this.colDatePayed.MinWidth = 25;
            this.colDatePayed.Name = "colDatePayed";
            this.colDatePayed.Width = 94;
            // 
            // colDateSend
            // 
            this.colDateSend.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colDateSend.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateSend.FieldName = "DateSend";
            this.colDateSend.MinWidth = 25;
            this.colDateSend.Name = "colDateSend";
            this.colDateSend.Width = 94;
            // 
            // colIsPayed
            // 
            this.colIsPayed.Caption = " ";
            this.colIsPayed.ColumnEdit = this.riCheckEditPayed;
            this.colIsPayed.FieldName = "IsPayed";
            this.colIsPayed.MaxWidth = 30;
            this.colIsPayed.MinWidth = 30;
            this.colIsPayed.Name = "colIsPayed";
            this.colIsPayed.ToolTip = "Payed";
            this.colIsPayed.Visible = true;
            this.colIsPayed.VisibleIndex = 6;
            this.colIsPayed.Width = 30;
            // 
            // riCheckEditPayed
            // 
            this.riCheckEditPayed.AutoHeight = false;
            this.riCheckEditPayed.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditPayed.ImageOptions.ImageIndexChecked = 19;
            this.riCheckEditPayed.ImageOptions.Images = this.ic16x16;
            this.riCheckEditPayed.Name = "riCheckEditPayed";
            // 
            // colIsSaved
            // 
            this.colIsSaved.FieldName = "IsSaved";
            this.colIsSaved.MinWidth = 25;
            this.colIsSaved.Name = "colIsSaved";
            this.colIsSaved.Width = 94;
            // 
            // colIsSend
            // 
            this.colIsSend.Caption = " ";
            this.colIsSend.ColumnEdit = this.riCheckEditSend;
            this.colIsSend.FieldName = "IsSend";
            this.colIsSend.MaxWidth = 30;
            this.colIsSend.MinWidth = 30;
            this.colIsSend.Name = "colIsSend";
            this.colIsSend.ToolTip = "Send";
            this.colIsSend.Visible = true;
            this.colIsSend.VisibleIndex = 5;
            this.colIsSend.Width = 30;
            // 
            // riCheckEditSend
            // 
            this.riCheckEditSend.AutoHeight = false;
            this.riCheckEditSend.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditSend.ImageOptions.ImageIndexChecked = 18;
            this.riCheckEditSend.ImageOptions.Images = this.ic16x16;
            this.riCheckEditSend.Name = "riCheckEditSend";
            // 
            // colVAT
            // 
            this.colVAT.FieldName = "VAT";
            this.colVAT.MinWidth = 25;
            this.colVAT.Name = "colVAT";
            this.colVAT.Width = 94;
            // 
            // bbiCustomers
            // 
            this.bbiCustomers.Caption = "Customers";
            this.bbiCustomers.Id = 4;
            this.bbiCustomers.ImageOptions.ImageIndex = 11;
            this.bbiCustomers.ImageOptions.LargeImageIndex = 11;
            this.bbiCustomers.Name = "bbiCustomers";
            // 
            // bbiPreviewReports
            // 
            this.bbiPreviewReports.Caption = "Preview";
            this.bbiPreviewReports.Id = 5;
            this.bbiPreviewReports.ImageOptions.ImageIndex = 12;
            this.bbiPreviewReports.ImageOptions.LargeImageIndex = 12;
            this.bbiPreviewReports.Name = "bbiPreviewReports";
            // 
            // bbiSaveReports
            // 
            this.bbiSaveReports.Caption = "Save";
            this.bbiSaveReports.Id = 6;
            this.bbiSaveReports.ImageOptions.ImageIndex = 10;
            this.bbiSaveReports.ImageOptions.LargeImageIndex = 10;
            this.bbiSaveReports.Name = "bbiSaveReports";
            // 
            // bbiMail
            // 
            this.bbiMail.Caption = "Mail";
            this.bbiMail.Id = 7;
            this.bbiMail.ImageOptions.ImageIndex = 20;
            this.bbiMail.ImageOptions.LargeImageIndex = 20;
            this.bbiMail.Name = "bbiMail";
            // 
            // colDueDate
            // 
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Width = 64;
            // 
            // colIsPdfSaved
            // 
            this.colIsPdfSaved.Caption = " ";
            this.colIsPdfSaved.ColumnEdit = this.riCheckEditSaved;
            this.colIsPdfSaved.FieldName = "IsPdfSaved";
            this.colIsPdfSaved.MaxWidth = 30;
            this.colIsPdfSaved.MinWidth = 30;
            this.colIsPdfSaved.Name = "colIsPdfSaved";
            this.colIsPdfSaved.ToolTip = "PDF saved";
            this.colIsPdfSaved.Visible = true;
            this.colIsPdfSaved.VisibleIndex = 4;
            this.colIsPdfSaved.Width = 30;
            // 
            // riCheckEditSaved
            // 
            this.riCheckEditSaved.AutoHeight = false;
            this.riCheckEditSaved.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditSaved.ImageOptions.ImageIndexChecked = 10;
            this.riCheckEditSaved.ImageOptions.Images = this.ic16x16;
            this.riCheckEditSaved.Name = "riCheckEditSaved";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 8;
            this.bbiRefresh.ImageOptions.ImageIndex = 6;
            this.bbiRefresh.ImageOptions.LargeImageIndex = 6;
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // OutgoingInvoiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutgoingInvoiceListView";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSaved)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePayed;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSend;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSaved;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSend;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraBars.BarButtonItem bbiCustomers;
        private DevExpress.XtraBars.BarButtonItem bbiPreviewReports;
        private DevExpress.XtraBars.BarButtonItem bbiSaveReports;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPdfSaved;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditSend;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditSaved;
        private DevExpress.Utils.ToolTipController toolTipController;
        private DevExpress.XtraBars.BarButtonItem bbiMail;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
    }
}
