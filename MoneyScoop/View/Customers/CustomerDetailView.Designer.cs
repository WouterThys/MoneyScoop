namespace MoneyScoop.View.Customers
{
    partial class CustomerDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetailView));
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bsInvoices = new System.Windows.Forms.BindingSource(this.components);
            this.HeaderPanel = new DevExpress.XtraEditors.PanelControl();
            this.TitelLabel = new DevExpress.XtraEditors.LabelControl();
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.VATNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InfoMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForVATNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcInvoices = new DevExpress.XtraGrid.GridControl();
            this.gvInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSendToBooky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPdfSaved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePayedString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSendString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateSendToBookyString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDateString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateModifiedString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutGoing = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VATNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).BeginInit();
            this.SuspendLayout();
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
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(MoneyScoop.Model.Customer);
            // 
            // bsInvoices
            // 
            this.bsInvoices.DataSource = typeof(MoneyScoop.Model.Invoice);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.TitelLabel);
            this.HeaderPanel.Controls.Add(this.dataLayoutControl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(449, 199);
            this.HeaderPanel.TabIndex = 0;
            // 
            // TitelLabel
            // 
            this.TitelLabel.Appearance.FontSizeDelta = 10;
            this.TitelLabel.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.TitelLabel.Appearance.Options.UseFont = true;
            this.TitelLabel.Appearance.Options.UseTextOptions = true;
            this.TitelLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TitelLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TitelLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.TitelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitelLabel.Location = new System.Drawing.Point(2, 2);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(445, 38);
            this.TitelLabel.TabIndex = 0;
            this.TitelLabel.Text = "CODE";
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.VATNumberTextEdit);
            this.dataLayoutControl.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl.Controls.Add(this.InfoMemoEdit);
            this.dataLayoutControl.DataSource = this.bsCustomer;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataLayoutControl.Images = this.ic16x16;
            this.dataLayoutControl.Location = new System.Drawing.Point(2, 40);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(445, 157);
            this.dataLayoutControl.TabIndex = 1;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // VATNumberTextEdit
            // 
            this.VATNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCustomer, "VATNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VATNumberTextEdit.Location = new System.Drawing.Point(39, 36);
            this.VATNumberTextEdit.Name = "VATNumberTextEdit";
            this.VATNumberTextEdit.Properties.ReadOnly = true;
            this.VATNumberTextEdit.Size = new System.Drawing.Size(394, 20);
            this.VATNumberTextEdit.StyleController = this.dataLayoutControl;
            this.VATNumberTextEdit.TabIndex = 4;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCustomer, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EmailTextEdit.Location = new System.Drawing.Point(39, 12);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.ReadOnly = true;
            this.EmailTextEdit.Size = new System.Drawing.Size(181, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl;
            this.EmailTextEdit.TabIndex = 5;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCustomer, "Phone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PhoneTextEdit.Location = new System.Drawing.Point(251, 12);
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Properties.ReadOnly = true;
            this.PhoneTextEdit.Size = new System.Drawing.Size(182, 20);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl;
            this.PhoneTextEdit.TabIndex = 6;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCustomer, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(39, 60);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Properties.ReadOnly = true;
            this.DescriptionTextEdit.Size = new System.Drawing.Size(394, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl;
            this.DescriptionTextEdit.TabIndex = 7;
            // 
            // InfoMemoEdit
            // 
            this.InfoMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsCustomer, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InfoMemoEdit.Location = new System.Drawing.Point(12, 84);
            this.InfoMemoEdit.Name = "InfoMemoEdit";
            this.InfoMemoEdit.Properties.ReadOnly = true;
            this.InfoMemoEdit.Size = new System.Drawing.Size(421, 61);
            this.InfoMemoEdit.StyleController = this.dataLayoutControl;
            this.InfoMemoEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(445, 157);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForVATNumber,
            this.ItemForDescription,
            this.ItemForInfo,
            this.ItemForEmail,
            this.ItemForPhone});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(425, 137);
            // 
            // ItemForVATNumber
            // 
            this.ItemForVATNumber.Control = this.VATNumberTextEdit;
            this.ItemForVATNumber.ImageOptions.ImageIndex = 31;
            this.ItemForVATNumber.Location = new System.Drawing.Point(0, 24);
            this.ItemForVATNumber.Name = "ItemForVATNumber";
            this.ItemForVATNumber.OptionsToolTip.ToolTip = "VAT Number";
            this.ItemForVATNumber.Size = new System.Drawing.Size(425, 24);
            this.ItemForVATNumber.Text = " ";
            this.ItemForVATNumber.TextSize = new System.Drawing.Size(24, 16);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.ImageOptions.ImageIndex = 30;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 48);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.OptionsToolTip.ToolTip = "Description";
            this.ItemForDescription.Size = new System.Drawing.Size(425, 24);
            this.ItemForDescription.Text = " ";
            this.ItemForDescription.TextSize = new System.Drawing.Size(24, 16);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Control = this.InfoMemoEdit;
            this.ItemForInfo.Location = new System.Drawing.Point(0, 72);
            this.ItemForInfo.Name = "ItemForInfo";
            this.ItemForInfo.Size = new System.Drawing.Size(425, 65);
            this.ItemForInfo.StartNewLine = true;
            this.ItemForInfo.Text = "Info";
            this.ItemForInfo.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForInfo.TextVisible = false;
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.ImageOptions.ImageIndex = 20;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 0);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.OptionsToolTip.ToolTip = "Email";
            this.ItemForEmail.Size = new System.Drawing.Size(212, 24);
            this.ItemForEmail.Text = " ";
            this.ItemForEmail.TextSize = new System.Drawing.Size(24, 16);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.ImageOptions.ImageIndex = 32;
            this.ItemForPhone.Location = new System.Drawing.Point(212, 0);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.OptionsToolTip.ToolTip = "Phone";
            this.ItemForPhone.Size = new System.Drawing.Size(213, 24);
            this.ItemForPhone.Text = " ";
            this.ItemForPhone.TextSize = new System.Drawing.Size(24, 16);
            // 
            // gcInvoices
            // 
            this.gcInvoices.DataSource = this.bsInvoices;
            this.gcInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInvoices.Location = new System.Drawing.Point(0, 199);
            this.gcInvoices.MainView = this.gvInvoices;
            this.gcInvoices.Name = "gcInvoices";
            this.gcInvoices.Size = new System.Drawing.Size(449, 332);
            this.gcInvoices.TabIndex = 1;
            this.gcInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvoices});
            // 
            // gvInvoices
            // 
            this.gvInvoices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colCustomerCode,
            this.colDueDate,
            this.colIsPayed,
            this.colIsSend,
            this.colIsSendToBooky,
            this.colIsPdfSaved,
            this.colDatePayedString,
            this.colDateSendString,
            this.colDateSendToBookyString,
            this.colDueDateString,
            this.colDateModifiedString,
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
            this.colLastModified});
            this.gvInvoices.GridControl = this.gcInvoices;
            this.gvInvoices.Name = "gvInvoices";
            this.gvInvoices.OptionsView.ShowGroupPanel = false;
            this.gvInvoices.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.OptionsColumn.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.OptionsColumn.ReadOnly = true;
            // 
            // colIsPayed
            // 
            this.colIsPayed.FieldName = "IsPayed";
            this.colIsPayed.Name = "colIsPayed";
            // 
            // colIsSend
            // 
            this.colIsSend.FieldName = "IsSend";
            this.colIsSend.Name = "colIsSend";
            // 
            // colIsSendToBooky
            // 
            this.colIsSendToBooky.FieldName = "IsSendToBooky";
            this.colIsSendToBooky.Name = "colIsSendToBooky";
            // 
            // colIsPdfSaved
            // 
            this.colIsPdfSaved.FieldName = "IsPdfSaved";
            this.colIsPdfSaved.Name = "colIsPdfSaved";
            this.colIsPdfSaved.OptionsColumn.ReadOnly = true;
            // 
            // colDatePayedString
            // 
            this.colDatePayedString.FieldName = "DatePayedString";
            this.colDatePayedString.Name = "colDatePayedString";
            this.colDatePayedString.OptionsColumn.ReadOnly = true;
            // 
            // colDateSendString
            // 
            this.colDateSendString.FieldName = "DateSendString";
            this.colDateSendString.Name = "colDateSendString";
            this.colDateSendString.OptionsColumn.ReadOnly = true;
            // 
            // colDateSendToBookyString
            // 
            this.colDateSendToBookyString.FieldName = "DateSendToBookyString";
            this.colDateSendToBookyString.Name = "colDateSendToBookyString";
            this.colDateSendToBookyString.OptionsColumn.ReadOnly = true;
            // 
            // colDueDateString
            // 
            this.colDueDateString.FieldName = "DueDateString";
            this.colDueDateString.Name = "colDueDateString";
            this.colDueDateString.OptionsColumn.ReadOnly = true;
            // 
            // colDateModifiedString
            // 
            this.colDateModifiedString.FieldName = "DateModifiedString";
            this.colDateModifiedString.Name = "colDateModifiedString";
            this.colDateModifiedString.OptionsColumn.ReadOnly = true;
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
            this.colTotal.VisibleIndex = 3;
            // 
            // colOutGoing
            // 
            this.colOutGoing.FieldName = "OutGoing";
            this.colOutGoing.Name = "colOutGoing";
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 2;
            // 
            // colDateSend
            // 
            this.colDateSend.FieldName = "DateSend";
            this.colDateSend.Name = "colDateSend";
            // 
            // colDatePayed
            // 
            this.colDatePayed.FieldName = "DatePayed";
            this.colDatePayed.Name = "colDatePayed";
            // 
            // colDateSendToBooky
            // 
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
            this.colDescription.VisibleIndex = 1;
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
            // CustomerDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcInvoices);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "CustomerDetailView";
            this.Size = new System.Drawing.Size(449, 531);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VATNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVATNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.BindingSource bsInvoices;
        private DevExpress.XtraEditors.PanelControl HeaderPanel;
        private DevExpress.XtraEditors.LabelControl TitelLabel;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraEditors.TextEdit VATNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.MemoEdit InfoMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVATNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInfo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraGrid.GridControl gcInvoices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPayed;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSend;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSendToBooky;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPdfSaved;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePayedString;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSendString;
        private DevExpress.XtraGrid.Columns.GridColumn colDateSendToBookyString;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDateString;
        private DevExpress.XtraGrid.Columns.GridColumn colDateModifiedString;
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
    }
}
