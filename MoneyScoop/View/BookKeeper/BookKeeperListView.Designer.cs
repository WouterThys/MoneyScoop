namespace MoneyScoop.View.BookKeeper
{
    partial class BookKeeperListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookKeeperListView));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bsInvoices = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colIsPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditPayed = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditSend = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsSendToBooky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditBooky = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIsPdfSaved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditCreated = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutGoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditOutgoing = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSendToBooky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATShifted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSavePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSendToBookyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgMain = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiOverview = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditBooky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditOutgoing)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiOverview});
            this.ribbonControl.MaxItemId = 2;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(1089, 158);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMain});
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
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsInvoices;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 158);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDateEdit,
            this.riCheckEditOutgoing,
            this.riCheckEditCreated,
            this.riCheckEditSend,
            this.riCheckEditPayed,
            this.riCheckEditBooky});
            this.gridControl.Size = new System.Drawing.Size(1089, 386);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // bsInvoices
            // 
            this.bsInvoices.DataSource = typeof(MoneyScoop.Model.Invoice);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCustomerCode,
            this.colDueDate,
            this.colIsPayed,
            this.colIsSend,
            this.colIsSendToBooky,
            this.colIsPdfSaved,
            this.colBankAccount,
            this.colSubTotal,
            this.colTotal,
            this.colOutGoing,
            this.colDateCreated,
            this.colDateSend,
            this.colDatePayed,
            this.colDateSendToBooky,
            this.colVAT,
            this.colVATShifted,
            this.colCustomerId,
            this.colSavePath,
            this.colId,
            this.colDescription,
            this.colInfo,
            this.colLastModified,
            this.colDateSendToBookyDate});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.Name = "gridView";
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateSendToBookyDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 109;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.OptionsColumn.ReadOnly = true;
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 3;
            this.colCustomerCode.Width = 109;
            // 
            // colDueDate
            // 
            this.colDueDate.ColumnEdit = this.riDateEdit;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.OptionsColumn.ReadOnly = true;
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 4;
            this.colDueDate.Width = 109;
            // 
            // riDateEdit
            // 
            this.riDateEdit.AutoHeight = false;
            this.riDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.Name = "riDateEdit";
            // 
            // colIsPayed
            // 
            this.colIsPayed.Caption = " ";
            this.colIsPayed.ColumnEdit = this.riCheckEditPayed;
            this.colIsPayed.FieldName = "IsPayed";
            this.colIsPayed.MaxWidth = 30;
            this.colIsPayed.MinWidth = 30;
            this.colIsPayed.Name = "colIsPayed";
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
            // colIsSend
            // 
            this.colIsSend.Caption = " ";
            this.colIsSend.ColumnEdit = this.riCheckEditSend;
            this.colIsSend.FieldName = "IsSend";
            this.colIsSend.MaxWidth = 30;
            this.colIsSend.MinWidth = 30;
            this.colIsSend.Name = "colIsSend";
            this.colIsSend.Visible = true;
            this.colIsSend.VisibleIndex = 7;
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
            // colIsSendToBooky
            // 
            this.colIsSendToBooky.Caption = " ";
            this.colIsSendToBooky.ColumnEdit = this.riCheckEditBooky;
            this.colIsSendToBooky.FieldName = "IsSendToBooky";
            this.colIsSendToBooky.MaxWidth = 30;
            this.colIsSendToBooky.MinWidth = 30;
            this.colIsSendToBooky.Name = "colIsSendToBooky";
            this.colIsSendToBooky.Visible = true;
            this.colIsSendToBooky.VisibleIndex = 8;
            this.colIsSendToBooky.Width = 30;
            // 
            // riCheckEditBooky
            // 
            this.riCheckEditBooky.AutoHeight = false;
            this.riCheckEditBooky.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditBooky.ImageOptions.ImageIndexChecked = 25;
            this.riCheckEditBooky.ImageOptions.Images = this.ic16x16;
            this.riCheckEditBooky.Name = "riCheckEditBooky";
            // 
            // colIsPdfSaved
            // 
            this.colIsPdfSaved.Caption = " ";
            this.colIsPdfSaved.ColumnEdit = this.riCheckEditCreated;
            this.colIsPdfSaved.FieldName = "IsPdfSaved";
            this.colIsPdfSaved.MaxWidth = 30;
            this.colIsPdfSaved.MinWidth = 30;
            this.colIsPdfSaved.Name = "colIsPdfSaved";
            this.colIsPdfSaved.OptionsColumn.ReadOnly = true;
            this.colIsPdfSaved.Visible = true;
            this.colIsPdfSaved.VisibleIndex = 9;
            this.colIsPdfSaved.Width = 30;
            // 
            // riCheckEditCreated
            // 
            this.riCheckEditCreated.AutoHeight = false;
            this.riCheckEditCreated.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditCreated.ImageOptions.ImageIndexChecked = 22;
            this.riCheckEditCreated.ImageOptions.Images = this.ic16x16;
            this.riCheckEditCreated.Name = "riCheckEditCreated";
            // 
            // colBankAccount
            // 
            this.colBankAccount.FieldName = "BankAccount";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.OptionsColumn.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DisplayFormat.FormatString = "C";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.OptionsColumn.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 128;
            // 
            // colOutGoing
            // 
            this.colOutGoing.Caption = "Direction";
            this.colOutGoing.ColumnEdit = this.riCheckEditOutgoing;
            this.colOutGoing.FieldName = "OutGoing";
            this.colOutGoing.MaxWidth = 30;
            this.colOutGoing.MinWidth = 30;
            this.colOutGoing.Name = "colOutGoing";
            this.colOutGoing.Visible = true;
            this.colOutGoing.VisibleIndex = 0;
            this.colOutGoing.Width = 72;
            // 
            // riCheckEditOutgoing
            // 
            this.riCheckEditOutgoing.AutoHeight = false;
            this.riCheckEditOutgoing.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditOutgoing.ImageOptions.ImageIndexChecked = 34;
            this.riCheckEditOutgoing.ImageOptions.ImageIndexUnchecked = 33;
            this.riCheckEditOutgoing.ImageOptions.Images = this.ic16x16;
            this.riCheckEditOutgoing.Name = "riCheckEditOutgoing";
            // 
            // colDateCreated
            // 
            this.colDateCreated.ColumnEdit = this.riDateEdit;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colDateSend
            // 
            this.colDateSend.ColumnEdit = this.riDateEdit;
            this.colDateSend.FieldName = "DateSend";
            this.colDateSend.Name = "colDateSend";
            // 
            // colDatePayed
            // 
            this.colDatePayed.ColumnEdit = this.riDateEdit;
            this.colDatePayed.FieldName = "DatePayed";
            this.colDatePayed.Name = "colDatePayed";
            // 
            // colDateSendToBooky
            // 
            this.colDateSendToBooky.ColumnEdit = this.riDateEdit;
            this.colDateSendToBooky.FieldName = "DateSendToBooky";
            this.colDateSendToBooky.Name = "colDateSendToBooky";
            // 
            // colVAT
            // 
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            // 
            // colVATShifted
            // 
            this.colVATShifted.FieldName = "VATShifted";
            this.colVATShifted.Name = "colVATShifted";
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colSavePath
            // 
            this.colSavePath.FieldName = "SavePath";
            this.colSavePath.Name = "colSavePath";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 109;
            // 
            // colInfo
            // 
            this.colInfo.FieldName = "Info";
            this.colInfo.Name = "colInfo";
            // 
            // colLastModified
            // 
            this.colLastModified.FieldName = "LastModified";
            this.colLastModified.Name = "colLastModified";
            // 
            // colDateSendToBookyDate
            // 
            this.colDateSendToBookyDate.FieldName = "DateSendToBookyDate";
            this.colDateSendToBookyDate.Name = "colDateSendToBookyDate";
            this.colDateSendToBookyDate.Visible = true;
            this.colDateSendToBookyDate.VisibleIndex = 10;
            // 
            // rpgMain
            // 
            this.rpgMain.ItemLinks.Add(this.bbiOverview);
            this.rpgMain.Name = "rpgMain";
            this.rpgMain.Text = "Actions";
            // 
            // bbiOverview
            // 
            this.bbiOverview.Caption = "Overview";
            this.bbiOverview.Id = 1;
            this.bbiOverview.Name = "bbiOverview";
            // 
            // BookKeeperListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "BookKeeperListView";
            this.Size = new System.Drawing.Size(1089, 544);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditBooky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditCreated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditOutgoing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource bsInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSend;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSendToBooky;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPdfSaved;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colOutGoing;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSend;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePayed;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSendToBooky;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colVATShifted;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colSavePath;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colLastModified;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditOutgoing;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditPayed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditSend;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditBooky;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSendToBookyDate;
        private DevExpress.XtraBars.BarButtonItem bbiOverview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMain;
    }
}
