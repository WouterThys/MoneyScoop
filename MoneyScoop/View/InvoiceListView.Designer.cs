namespace MoneyScoop.View
{
    partial class InvoiceListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListView));
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSaved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCustomers = new DevExpress.XtraBars.BarButtonItem();
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
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.Invoice);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.colVAT});
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateCreated, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCode
            // 
            this.colCode.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.VisibleIndex = 2;
            // 
            // colLastModified
            // 
            this.colLastModified.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiCustomers});
            this.ribbonControl.MaxItemId = 5;
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
            this.rpgCustomer});
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
            this.colDateCreated.VisibleIndex = 0;
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
            this.colIsPayed.FieldName = "IsPayed";
            this.colIsPayed.MinWidth = 25;
            this.colIsPayed.Name = "colIsPayed";
            this.colIsPayed.Visible = true;
            this.colIsPayed.VisibleIndex = 4;
            this.colIsPayed.Width = 94;
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
            this.colIsSend.FieldName = "IsSend";
            this.colIsSend.MinWidth = 25;
            this.colIsSend.Name = "colIsSend";
            this.colIsSend.Visible = true;
            this.colIsSend.VisibleIndex = 5;
            this.colIsSend.Width = 94;
            // 
            // colVAT
            // 
            this.colVAT.FieldName = "VAT";
            this.colVAT.MinWidth = 25;
            this.colVAT.Name = "colVAT";
            this.colVAT.Width = 94;
            // 
            // rpgCustomer
            // 
            this.rpgCustomer.ItemLinks.Add(this.bbiCustomers);
            this.rpgCustomer.Name = "rpgCustomer";
            this.rpgCustomer.Text = "Customers";
            // 
            // bbiCustomers
            // 
            this.bbiCustomers.Caption = "Customers";
            this.bbiCustomers.Id = 4;
            this.bbiCustomers.ImageOptions.ImageIndex = 11;
            this.bbiCustomers.ImageOptions.LargeImageIndex = 11;
            this.bbiCustomers.Name = "bbiCustomers";
            // 
            // InvoiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "InvoiceListView";
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCustomer;
    }
}
