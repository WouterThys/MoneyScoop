namespace MoneyScoop.View
{
    partial class CustomerListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListView));
            this.colAddressLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressLine2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATNumber = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.Customer);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddressLine1,
            this.colAddressLine2,
            this.colEmail,
            this.colPhone,
            this.colVATNumber});
            this.gridView.DetailHeight = 350;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCode, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // colAddressLine1
            // 
            this.colAddressLine1.FieldName = "AddressLine1";
            this.colAddressLine1.MinWidth = 25;
            this.colAddressLine1.Name = "colAddressLine1";
            this.colAddressLine1.Width = 94;
            // 
            // colAddressLine2
            // 
            this.colAddressLine2.FieldName = "AddressLine2";
            this.colAddressLine2.MinWidth = 25;
            this.colAddressLine2.Name = "colAddressLine2";
            this.colAddressLine2.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 94;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 94;
            // 
            // colVATNumber
            // 
            this.colVATNumber.FieldName = "VATNumber";
            this.colVATNumber.MinWidth = 25;
            this.colVATNumber.Name = "colVATNumber";
            this.colVATNumber.Width = 94;
            // 
            // CustomerListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerListView";
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

        private DevExpress.XtraGrid.Columns.GridColumn colAddressLine1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressLine2;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colVATNumber;
    }
}
