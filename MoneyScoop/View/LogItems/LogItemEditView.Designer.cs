
namespace MoneyScoop.View.LogItems
{
    partial class LogItemEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogItemEditView));
            this.TimeStampDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForTimeStamp = new DevExpress.XtraLayout.LayoutControlItem();
            this.GroupTagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForGroupTag = new DevExpress.XtraLayout.LayoutControlItem();
            this.VersionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForVersion = new DevExpress.XtraLayout.LayoutControlItem();
            this.StartTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForStartTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.StopTimeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForStopTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustomerIdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAddressLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressLine2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefaultUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemForCustomerId = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStampDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStampDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTimeStamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopTimeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopTimeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStopTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerId)).BeginInit();
            this.SuspendLayout();
            // 
            // bbiSave
            // 
            this.bbiSave.ImageOptions.ImageIndex = 9;
            this.bbiSave.ImageOptions.LargeImageIndex = 9;
            // 
            // bbiSaveAndDone
            // 
            this.bbiSaveAndDone.ImageOptions.ImageIndex = 10;
            this.bbiSaveAndDone.ImageOptions.LargeImageIndex = 10;
            // 
            // bbiDelete
            // 
            this.bbiDelete.ImageOptions.ImageIndex = 2;
            this.bbiDelete.ImageOptions.LargeImageIndex = 2;
            // 
            // bbiReset
            // 
            this.bbiReset.ImageOptions.ImageIndex = 7;
            this.bbiReset.ImageOptions.LargeImageIndex = 7;
            // 
            // bbiCopy
            // 
            this.bbiCopy.ImageOptions.ImageIndex = 3;
            this.bbiCopy.ImageOptions.LargeImageIndex = 3;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.LogItem);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.TimeStampDateEdit);
            this.dataLayoutControl.Controls.Add(this.GroupTagTextEdit);
            this.dataLayoutControl.Controls.Add(this.VersionTextEdit);
            this.dataLayoutControl.Controls.Add(this.StartTimeDateEdit);
            this.dataLayoutControl.Controls.Add(this.StopTimeDateEdit);
            this.dataLayoutControl.Controls.Add(this.CustomerIdSearchLookUpEdit);
            this.dataLayoutControl.Size = new System.Drawing.Size(479, 351);
            this.dataLayoutControl.Controls.SetChildIndex(this.CustomerIdSearchLookUpEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.StopTimeDateEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.StartTimeDateEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.VersionTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.GroupTagTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.TimeStampDateEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.InfoTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.DescriptionTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.CodeTextEdit, 0);
            // 
            // Root
            // 
            this.Root.Size = new System.Drawing.Size(479, 351);
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.Location = new System.Drawing.Point(95, 49);
            this.CodeTextEdit.Size = new System.Drawing.Size(360, 20);
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.Location = new System.Drawing.Point(95, 73);
            this.DescriptionTextEdit.Size = new System.Drawing.Size(360, 20);
            // 
            // InfoTextEdit
            // 
            this.InfoTextEdit.Location = new System.Drawing.Point(24, 257);
            this.InfoTextEdit.Size = new System.Drawing.Size(431, 70);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Size = new System.Drawing.Size(459, 331);
            // 
            // lcgId
            // 
            this.lcgId.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTimeStamp,
            this.ItemForGroupTag,
            this.ItemForVersion,
            this.ItemForStartTime,
            this.ItemForStopTime,
            this.ItemForCustomerId});
            this.lcgId.Size = new System.Drawing.Size(459, 331);
            // 
            // ItemForCode
            // 
            this.ItemForCode.Size = new System.Drawing.Size(435, 24);
            this.ItemForCode.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Size = new System.Drawing.Size(435, 24);
            this.ItemForDescription.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Location = new System.Drawing.Point(0, 192);
            this.ItemForInfo.Size = new System.Drawing.Size(435, 90);
            this.ItemForInfo.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ribbonControl
            // 
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(479, 158);
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
            // TimeStampDateEdit
            // 
            this.TimeStampDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "TimeStamp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TimeStampDateEdit.EditValue = null;
            this.TimeStampDateEdit.Location = new System.Drawing.Point(95, 97);
            this.TimeStampDateEdit.MenuManager = this.ribbonControl;
            this.TimeStampDateEdit.Name = "TimeStampDateEdit";
            this.TimeStampDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeStampDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeStampDateEdit.Size = new System.Drawing.Size(360, 20);
            this.TimeStampDateEdit.StyleController = this.dataLayoutControl;
            this.TimeStampDateEdit.TabIndex = 7;
            // 
            // ItemForTimeStamp
            // 
            this.ItemForTimeStamp.Control = this.TimeStampDateEdit;
            this.ItemForTimeStamp.Location = new System.Drawing.Point(0, 48);
            this.ItemForTimeStamp.Name = "ItemForTimeStamp";
            this.ItemForTimeStamp.Size = new System.Drawing.Size(435, 24);
            this.ItemForTimeStamp.Text = "Time Stamp";
            this.ItemForTimeStamp.TextSize = new System.Drawing.Size(59, 13);
            // 
            // GroupTagTextEdit
            // 
            this.GroupTagTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "GroupTag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GroupTagTextEdit.Location = new System.Drawing.Point(95, 121);
            this.GroupTagTextEdit.MenuManager = this.ribbonControl;
            this.GroupTagTextEdit.Name = "GroupTagTextEdit";
            this.GroupTagTextEdit.Size = new System.Drawing.Size(360, 20);
            this.GroupTagTextEdit.StyleController = this.dataLayoutControl;
            this.GroupTagTextEdit.TabIndex = 8;
            // 
            // ItemForGroupTag
            // 
            this.ItemForGroupTag.Control = this.GroupTagTextEdit;
            this.ItemForGroupTag.Location = new System.Drawing.Point(0, 72);
            this.ItemForGroupTag.Name = "ItemForGroupTag";
            this.ItemForGroupTag.Size = new System.Drawing.Size(435, 24);
            this.ItemForGroupTag.Text = "Group Tag";
            this.ItemForGroupTag.TextSize = new System.Drawing.Size(59, 13);
            // 
            // VersionTextEdit
            // 
            this.VersionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VersionTextEdit.Location = new System.Drawing.Point(95, 145);
            this.VersionTextEdit.MenuManager = this.ribbonControl;
            this.VersionTextEdit.Name = "VersionTextEdit";
            this.VersionTextEdit.Size = new System.Drawing.Size(360, 20);
            this.VersionTextEdit.StyleController = this.dataLayoutControl;
            this.VersionTextEdit.TabIndex = 9;
            // 
            // ItemForVersion
            // 
            this.ItemForVersion.Control = this.VersionTextEdit;
            this.ItemForVersion.Location = new System.Drawing.Point(0, 96);
            this.ItemForVersion.Name = "ItemForVersion";
            this.ItemForVersion.Size = new System.Drawing.Size(435, 24);
            this.ItemForVersion.Text = "Version";
            this.ItemForVersion.TextSize = new System.Drawing.Size(59, 13);
            // 
            // StartTimeDateEdit
            // 
            this.StartTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "StartTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartTimeDateEdit.EditValue = null;
            this.StartTimeDateEdit.Location = new System.Drawing.Point(95, 169);
            this.StartTimeDateEdit.MenuManager = this.ribbonControl;
            this.StartTimeDateEdit.Name = "StartTimeDateEdit";
            this.StartTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartTimeDateEdit.Size = new System.Drawing.Size(360, 20);
            this.StartTimeDateEdit.StyleController = this.dataLayoutControl;
            this.StartTimeDateEdit.TabIndex = 10;
            // 
            // ItemForStartTime
            // 
            this.ItemForStartTime.Control = this.StartTimeDateEdit;
            this.ItemForStartTime.Location = new System.Drawing.Point(0, 120);
            this.ItemForStartTime.Name = "ItemForStartTime";
            this.ItemForStartTime.Size = new System.Drawing.Size(435, 24);
            this.ItemForStartTime.Text = "Start Time";
            this.ItemForStartTime.TextSize = new System.Drawing.Size(59, 13);
            // 
            // StopTimeDateEdit
            // 
            this.StopTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "StopTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StopTimeDateEdit.EditValue = null;
            this.StopTimeDateEdit.Location = new System.Drawing.Point(95, 193);
            this.StopTimeDateEdit.MenuManager = this.ribbonControl;
            this.StopTimeDateEdit.Name = "StopTimeDateEdit";
            this.StopTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StopTimeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StopTimeDateEdit.Size = new System.Drawing.Size(360, 20);
            this.StopTimeDateEdit.StyleController = this.dataLayoutControl;
            this.StopTimeDateEdit.TabIndex = 11;
            // 
            // ItemForStopTime
            // 
            this.ItemForStopTime.Control = this.StopTimeDateEdit;
            this.ItemForStopTime.Location = new System.Drawing.Point(0, 144);
            this.ItemForStopTime.Name = "ItemForStopTime";
            this.ItemForStopTime.Size = new System.Drawing.Size(435, 24);
            this.ItemForStopTime.Text = "Stop Time";
            this.ItemForStopTime.TextSize = new System.Drawing.Size(59, 13);
            // 
            // CustomerIdSearchLookUpEdit
            // 
            this.CustomerIdSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "CustomerId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CustomerIdSearchLookUpEdit.Location = new System.Drawing.Point(95, 217);
            this.CustomerIdSearchLookUpEdit.MenuManager = this.ribbonControl;
            this.CustomerIdSearchLookUpEdit.Name = "CustomerIdSearchLookUpEdit";
            this.CustomerIdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CustomerIdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CustomerIdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomerIdSearchLookUpEdit.Properties.DataSource = this.bsCustomers;
            this.CustomerIdSearchLookUpEdit.Properties.DisplayMember = "Code";
            this.CustomerIdSearchLookUpEdit.Properties.NullText = "";
            this.CustomerIdSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.CustomerIdSearchLookUpEdit.Properties.ValueMember = "Id";
            this.CustomerIdSearchLookUpEdit.Size = new System.Drawing.Size(360, 20);
            this.CustomerIdSearchLookUpEdit.StyleController = this.dataLayoutControl;
            this.CustomerIdSearchLookUpEdit.TabIndex = 12;
            // 
            // bsCustomers
            // 
            this.bsCustomers.DataSource = typeof(MoneyScoop.Model.Customer);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddressLine1,
            this.colAddressLine2,
            this.colCode,
            this.colDefaultUnitPrice,
            this.colDescription,
            this.colEmail,
            this.colPhone,
            this.colVATNumber,
            this.colWebsite});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colAddressLine1
            // 
            this.colAddressLine1.FieldName = "AddressLine1";
            this.colAddressLine1.Name = "colAddressLine1";
            // 
            // colAddressLine2
            // 
            this.colAddressLine2.FieldName = "AddressLine2";
            this.colAddressLine2.Name = "colAddressLine2";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 247;
            // 
            // colDefaultUnitPrice
            // 
            this.colDefaultUnitPrice.FieldName = "DefaultUnitPrice";
            this.colDefaultUnitPrice.Name = "colDefaultUnitPrice";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 459;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            this.colEmail.Width = 148;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 162;
            // 
            // colVATNumber
            // 
            this.colVATNumber.FieldName = "VATNumber";
            this.colVATNumber.Name = "colVATNumber";
            this.colVATNumber.Visible = true;
            this.colVATNumber.VisibleIndex = 4;
            this.colVATNumber.Width = 223;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            // 
            // ItemForCustomerId
            // 
            this.ItemForCustomerId.Control = this.CustomerIdSearchLookUpEdit;
            this.ItemForCustomerId.Location = new System.Drawing.Point(0, 168);
            this.ItemForCustomerId.Name = "ItemForCustomerId";
            this.ItemForCustomerId.Size = new System.Drawing.Size(435, 24);
            this.ItemForCustomerId.Text = "Customer Id";
            this.ItemForCustomerId.TextSize = new System.Drawing.Size(59, 13);
            // 
            // LogItemEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LogItemEditView";
            this.Size = new System.Drawing.Size(479, 509);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStampDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStampDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTimeStamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGroupTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopTimeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopTimeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStopTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit TimeStampDateEdit;
        private DevExpress.XtraEditors.TextEdit GroupTagTextEdit;
        private DevExpress.XtraEditors.TextEdit VersionTextEdit;
        private DevExpress.XtraEditors.DateEdit StartTimeDateEdit;
        private DevExpress.XtraEditors.DateEdit StopTimeDateEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit CustomerIdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTimeStamp;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGroupTag;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVersion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStartTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStopTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerId;
        private System.Windows.Forms.BindingSource bsCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressLine1;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressLine2;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colVATNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
    }
}
