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
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.DetailPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.OutgoingInvoiceDetailView = new MoneyScoop.View.Invoices.OutgoingInvoiceDetailView();
            this.colIsSendToBooky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditSendToBooky = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDateSendToBookyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutGoing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEditOutGoing = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpgHandy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiOpenDirectory = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.DetailPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSendToBooky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditOutGoing)).BeginInit();
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
            this.riCheckEditSaved,
            this.riCheckEditSendToBooky,
            this.riCheckEditOutGoing});
            this.gridControl.Size = new System.Drawing.Size(952, 362);
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
            this.colIsPdfSaved,
            this.colIsSendToBooky,
            this.colDateSendToBookyDate,
            this.colTotal,
            this.colOutGoing,
            this.colBankAccount});
            this.gridView.DetailHeight = 350;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateCreated, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.ColumnEdit = this.riCheckEditSendToBooky;
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
            this.bbiRefresh,
            this.bbiOpenDirectory});
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 10;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(1352, 158);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHandy});
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
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.MinWidth = 25;
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 4;
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
            this.colDateCreated.VisibleIndex = 3;
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
            this.colIsPayed.VisibleIndex = 8;
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
            this.colIsPdfSaved.VisibleIndex = 6;
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
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DetailPanel});
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
            // DetailPanel
            // 
            this.DetailPanel.Controls.Add(this.dockPanel1_Container);
            this.DetailPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DetailPanel.ID = new System.Guid("37091cb3-08a8-43b2-8eb9-c95286da5f4d");
            this.DetailPanel.Location = new System.Drawing.Point(952, 158);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Options.ShowCloseButton = false;
            this.DetailPanel.OriginalSize = new System.Drawing.Size(400, 200);
            this.DetailPanel.Size = new System.Drawing.Size(400, 362);
            this.DetailPanel.Text = "Details";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.OutgoingInvoiceDetailView);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(393, 329);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // OutgoingInvoiceDetailView
            // 
            this.OutgoingInvoiceDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutgoingInvoiceDetailView.Location = new System.Drawing.Point(0, 0);
            this.OutgoingInvoiceDetailView.Name = "OutgoingInvoiceDetailView";
            this.OutgoingInvoiceDetailView.Size = new System.Drawing.Size(393, 329);
            this.OutgoingInvoiceDetailView.TabIndex = 0;
            // 
            // colIsSendToBooky
            // 
            this.colIsSendToBooky.Caption = " ";
            this.colIsSendToBooky.FieldName = "IsSendToBooky";
            this.colIsSendToBooky.MaxWidth = 30;
            this.colIsSendToBooky.MinWidth = 30;
            this.colIsSendToBooky.Name = "colIsSendToBooky";
            this.colIsSendToBooky.Visible = true;
            this.colIsSendToBooky.VisibleIndex = 9;
            this.colIsSendToBooky.Width = 30;
            // 
            // riCheckEditSendToBooky
            // 
            this.riCheckEditSendToBooky.AutoHeight = false;
            this.riCheckEditSendToBooky.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditSendToBooky.ImageOptions.ImageIndexChecked = 25;
            this.riCheckEditSendToBooky.ImageOptions.Images = this.ic16x16;
            this.riCheckEditSendToBooky.Name = "riCheckEditSendToBooky";
            // 
            // colDateSendToBookyDate
            // 
            this.colDateSendToBookyDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colDateSendToBookyDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateSendToBookyDate.FieldName = "DateSendToBookyDate";
            this.colDateSendToBookyDate.Name = "colDateSendToBookyDate";
            this.colDateSendToBookyDate.Width = 64;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 64;
            // 
            // colOutGoing
            // 
            this.colOutGoing.Caption = " ";
            this.colOutGoing.ColumnEdit = this.riCheckEditOutGoing;
            this.colOutGoing.FieldName = "OutGoing";
            this.colOutGoing.MaxWidth = 30;
            this.colOutGoing.MinWidth = 30;
            this.colOutGoing.Name = "colOutGoing";
            this.colOutGoing.Visible = true;
            this.colOutGoing.VisibleIndex = 2;
            this.colOutGoing.Width = 30;
            // 
            // riCheckEditOutGoing
            // 
            this.riCheckEditOutGoing.AutoHeight = false;
            this.riCheckEditOutGoing.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            this.riCheckEditOutGoing.ImageOptions.ImageIndexChecked = 34;
            this.riCheckEditOutGoing.ImageOptions.ImageIndexUnchecked = 33;
            this.riCheckEditOutGoing.ImageOptions.Images = this.ic16x16;
            this.riCheckEditOutGoing.Name = "riCheckEditOutGoing";
            // 
            // colBankAccount
            // 
            this.colBankAccount.FieldName = "BankAccount";
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.Width = 64;
            // 
            // rpgHandy
            // 
            this.rpgHandy.ItemLinks.Add(this.bbiOpenDirectory);
            this.rpgHandy.Name = "rpgHandy";
            this.rpgHandy.Text = "Handy";
            // 
            // bbiOpenDirectory
            // 
            this.bbiOpenDirectory.Caption = "Open Folder";
            this.bbiOpenDirectory.Id = 9;
            this.bbiOpenDirectory.ImageOptions.ImageIndex = 35;
            this.bbiOpenDirectory.ImageOptions.LargeImageIndex = 35;
            this.bbiOpenDirectory.Name = "bbiOpenDirectory";
            // 
            // OutgoingInvoiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutgoingInvoiceListView";
            this.Size = new System.Drawing.Size(1352, 520);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.DetailPanel, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.DetailPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditSendToBooky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEditOutGoing)).EndInit();
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
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel DetailPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private Invoices.OutgoingInvoiceDetailView OutgoingInvoiceDetailView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditSendToBooky;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSendToBooky;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSendToBookyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEditOutGoing;
        private DevExpress.XtraGrid.Columns.GridColumn colOutGoing;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccount;
        private DevExpress.XtraBars.BarButtonItem bbiOpenDirectory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHandy;
    }
}
