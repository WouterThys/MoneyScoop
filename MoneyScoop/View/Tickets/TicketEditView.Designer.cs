namespace MoneyScoop.View.Tickets
{
    partial class TicketEditView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketEditView));
            this.TypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ItemForType = new DevExpress.XtraLayout.LayoutControlItem();
            this.StateImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.OriginVersionIdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForOriginVersionId = new DevExpress.XtraLayout.LayoutControlItem();
            this.FixedInVersionIdSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForFixedInVersionId = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginVersionIdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOriginVersionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixedInVersionIdSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFixedInVersionId)).BeginInit();
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
            this.bindingSource.DataSource = typeof(MoneyScoop.Model.Ticket);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.AllowGeneratingCollectionProperties = DevExpress.Utils.DefaultBoolean.False;
            this.dataLayoutControl.AllowGeneratingNestedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.dataLayoutControl.Controls.Add(this.TypeImageComboBoxEdit);
            this.dataLayoutControl.Controls.Add(this.StateImageComboBoxEdit);
            this.dataLayoutControl.Controls.Add(this.OriginVersionIdSearchLookUpEdit);
            this.dataLayoutControl.Controls.Add(this.FixedInVersionIdSearchLookUpEdit);
            this.dataLayoutControl.Controls.SetChildIndex(this.FixedInVersionIdSearchLookUpEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.OriginVersionIdSearchLookUpEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.StateImageComboBoxEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.TypeImageComboBoxEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.InfoTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.DescriptionTextEdit, 0);
            this.dataLayoutControl.Controls.SetChildIndex(this.CodeTextEdit, 0);
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.Location = new System.Drawing.Point(113, 49);
            this.CodeTextEdit.Size = new System.Drawing.Size(315, 20);
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.Location = new System.Drawing.Point(113, 73);
            this.DescriptionTextEdit.Size = new System.Drawing.Size(315, 20);
            // 
            // InfoTextEdit
            // 
            this.InfoTextEdit.Size = new System.Drawing.Size(404, 38);
            // 
            // lcgId
            // 
            this.lcgId.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForType,
            this.ItemForState,
            this.ItemForOriginVersionId,
            this.ItemForFixedInVersionId});
            // 
            // ItemForCode
            // 
            this.ItemForCode.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForInfo
            // 
            this.ItemForInfo.Size = new System.Drawing.Size(408, 58);
            this.ItemForInfo.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
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
            // TypeImageComboBoxEdit
            // 
            this.TypeImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Type", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TypeImageComboBoxEdit.Location = new System.Drawing.Point(113, 155);
            this.TypeImageComboBoxEdit.MenuManager = this.ribbonControl;
            this.TypeImageComboBoxEdit.Name = "TypeImageComboBoxEdit";
            this.TypeImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TypeImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unknown", MoneyScoop.Model.TicketType.Unknown, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bug", MoneyScoop.Model.TicketType.Bug, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Task", MoneyScoop.Model.TicketType.Task, 2)});
            this.TypeImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.TypeImageComboBoxEdit.Size = new System.Drawing.Size(315, 20);
            this.TypeImageComboBoxEdit.StyleController = this.dataLayoutControl;
            this.TypeImageComboBoxEdit.TabIndex = 7;
            // 
            // ItemForType
            // 
            this.ItemForType.Control = this.TypeImageComboBoxEdit;
            this.ItemForType.Location = new System.Drawing.Point(0, 106);
            this.ItemForType.Name = "ItemForType";
            this.ItemForType.Size = new System.Drawing.Size(408, 24);
            this.ItemForType.Text = "Type";
            this.ItemForType.TextSize = new System.Drawing.Size(77, 13);
            // 
            // StateImageComboBoxEdit
            // 
            this.StateImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "State", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StateImageComboBoxEdit.Location = new System.Drawing.Point(113, 179);
            this.StateImageComboBoxEdit.MenuManager = this.ribbonControl;
            this.StateImageComboBoxEdit.Name = "StateImageComboBoxEdit";
            this.StateImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StateImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StateImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StateImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pending", MoneyScoop.Model.TicketState.Pending, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Busy", MoneyScoop.Model.TicketState.Busy, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Ready", MoneyScoop.Model.TicketState.Ready, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Done", MoneyScoop.Model.TicketState.Done, 3)});
            this.StateImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.StateImageComboBoxEdit.Size = new System.Drawing.Size(315, 20);
            this.StateImageComboBoxEdit.StyleController = this.dataLayoutControl;
            this.StateImageComboBoxEdit.TabIndex = 8;
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateImageComboBoxEdit;
            this.ItemForState.Location = new System.Drawing.Point(0, 130);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(408, 24);
            this.ItemForState.Text = "State";
            this.ItemForState.TextSize = new System.Drawing.Size(77, 13);
            // 
            // OriginVersionIdSearchLookUpEdit
            // 
            this.OriginVersionIdSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "OriginVersionId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OriginVersionIdSearchLookUpEdit.Location = new System.Drawing.Point(113, 203);
            this.OriginVersionIdSearchLookUpEdit.MenuManager = this.ribbonControl;
            this.OriginVersionIdSearchLookUpEdit.Name = "OriginVersionIdSearchLookUpEdit";
            this.OriginVersionIdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OriginVersionIdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OriginVersionIdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OriginVersionIdSearchLookUpEdit.Properties.NullText = "";
            this.OriginVersionIdSearchLookUpEdit.Properties.PopupView = this.searchLookUpEdit1View;
            this.OriginVersionIdSearchLookUpEdit.Size = new System.Drawing.Size(315, 20);
            this.OriginVersionIdSearchLookUpEdit.StyleController = this.dataLayoutControl;
            this.OriginVersionIdSearchLookUpEdit.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForOriginVersionId
            // 
            this.ItemForOriginVersionId.Control = this.OriginVersionIdSearchLookUpEdit;
            this.ItemForOriginVersionId.Location = new System.Drawing.Point(0, 154);
            this.ItemForOriginVersionId.Name = "ItemForOriginVersionId";
            this.ItemForOriginVersionId.Size = new System.Drawing.Size(408, 24);
            this.ItemForOriginVersionId.Text = "Origin Version";
            this.ItemForOriginVersionId.TextSize = new System.Drawing.Size(77, 13);
            // 
            // FixedInVersionIdSearchLookUpEdit
            // 
            this.FixedInVersionIdSearchLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "FixedInVersionId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FixedInVersionIdSearchLookUpEdit.Location = new System.Drawing.Point(113, 227);
            this.FixedInVersionIdSearchLookUpEdit.MenuManager = this.ribbonControl;
            this.FixedInVersionIdSearchLookUpEdit.Name = "FixedInVersionIdSearchLookUpEdit";
            this.FixedInVersionIdSearchLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.FixedInVersionIdSearchLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.FixedInVersionIdSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FixedInVersionIdSearchLookUpEdit.Properties.NullText = "";
            this.FixedInVersionIdSearchLookUpEdit.Properties.PopupView = this.gridView1;
            this.FixedInVersionIdSearchLookUpEdit.Size = new System.Drawing.Size(315, 20);
            this.FixedInVersionIdSearchLookUpEdit.StyleController = this.dataLayoutControl;
            this.FixedInVersionIdSearchLookUpEdit.TabIndex = 10;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForFixedInVersionId
            // 
            this.ItemForFixedInVersionId.Control = this.FixedInVersionIdSearchLookUpEdit;
            this.ItemForFixedInVersionId.Location = new System.Drawing.Point(0, 178);
            this.ItemForFixedInVersionId.Name = "ItemForFixedInVersionId";
            this.ItemForFixedInVersionId.Size = new System.Drawing.Size(408, 24);
            this.ItemForFixedInVersionId.Text = "Fixed In Version";
            this.ItemForFixedInVersionId.TextSize = new System.Drawing.Size(77, 13);
            // 
            // TicketEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TicketEditView";
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
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginVersionIdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOriginVersionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixedInVersionIdSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFixedInVersionId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageComboBoxEdit TypeImageComboBoxEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit StateImageComboBoxEdit;
        private DevExpress.XtraEditors.SearchLookUpEdit OriginVersionIdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit FixedInVersionIdSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOriginVersionId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFixedInVersionId;
    }
}
