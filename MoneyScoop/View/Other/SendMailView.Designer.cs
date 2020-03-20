namespace MoneyScoop.View
{
    partial class SendMailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMailView));
            this.bsModel = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.FromTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ReceiverTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MessageTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFrom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReceiver = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.rpgActions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiSend = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).BeginInit();
            this.dataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiverTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiSend});
            this.ribbonControl.MaxItemId = 2;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.SearchEditItem.UseEditorPadding = false;
            this.ribbonControl.Size = new System.Drawing.Size(514, 158);
            // 
            // MainRibbonPage
            // 
            this.MainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgActions});
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
            // 
            // bsModel
            // 
            this.bsModel.DataSource = typeof(MoneyScoop.ViewModel.SendMailViewModel);
            // 
            // dataLayoutControl
            // 
            this.dataLayoutControl.Controls.Add(this.FromTextEdit);
            this.dataLayoutControl.Controls.Add(this.ReceiverTextEdit);
            this.dataLayoutControl.Controls.Add(this.SubjectTextEdit);
            this.dataLayoutControl.Controls.Add(this.MessageTextEdit);
            this.dataLayoutControl.DataSource = this.bsModel;
            this.dataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl.Location = new System.Drawing.Point(0, 158);
            this.dataLayoutControl.Name = "dataLayoutControl";
            this.dataLayoutControl.Root = this.Root;
            this.dataLayoutControl.Size = new System.Drawing.Size(514, 321);
            this.dataLayoutControl.TabIndex = 0;
            this.dataLayoutControl.Text = "dataLayoutControl1";
            // 
            // FromTextEdit
            // 
            this.FromTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsModel, "From", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FromTextEdit.Location = new System.Drawing.Point(57, 12);
            this.FromTextEdit.Name = "FromTextEdit";
            this.FromTextEdit.Size = new System.Drawing.Size(445, 20);
            this.FromTextEdit.StyleController = this.dataLayoutControl;
            this.FromTextEdit.TabIndex = 4;
            // 
            // ReceiverTextEdit
            // 
            this.ReceiverTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsModel, "Receiver", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceiverTextEdit.Location = new System.Drawing.Point(57, 36);
            this.ReceiverTextEdit.Name = "ReceiverTextEdit";
            this.ReceiverTextEdit.Size = new System.Drawing.Size(445, 20);
            this.ReceiverTextEdit.StyleController = this.dataLayoutControl;
            this.ReceiverTextEdit.TabIndex = 5;
            // 
            // SubjectTextEdit
            // 
            this.SubjectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsModel, "Subject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SubjectTextEdit.Location = new System.Drawing.Point(57, 60);
            this.SubjectTextEdit.Name = "SubjectTextEdit";
            this.SubjectTextEdit.Size = new System.Drawing.Size(445, 20);
            this.SubjectTextEdit.StyleController = this.dataLayoutControl;
            this.SubjectTextEdit.TabIndex = 6;
            // 
            // MessageTextEdit
            // 
            this.MessageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsModel, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MessageTextEdit.Location = new System.Drawing.Point(12, 100);
            this.MessageTextEdit.Name = "MessageTextEdit";
            this.MessageTextEdit.Size = new System.Drawing.Size(490, 209);
            this.MessageTextEdit.StyleController = this.dataLayoutControl;
            this.MessageTextEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(514, 321);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFrom,
            this.ItemForReceiver,
            this.ItemForSubject,
            this.ItemForMessage});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 301);
            // 
            // ItemForFrom
            // 
            this.ItemForFrom.Control = this.FromTextEdit;
            this.ItemForFrom.Location = new System.Drawing.Point(0, 0);
            this.ItemForFrom.Name = "ItemForFrom";
            this.ItemForFrom.Size = new System.Drawing.Size(494, 24);
            this.ItemForFrom.Text = "From";
            this.ItemForFrom.TextSize = new System.Drawing.Size(42, 13);
            // 
            // ItemForReceiver
            // 
            this.ItemForReceiver.Control = this.ReceiverTextEdit;
            this.ItemForReceiver.Location = new System.Drawing.Point(0, 24);
            this.ItemForReceiver.Name = "ItemForReceiver";
            this.ItemForReceiver.Size = new System.Drawing.Size(494, 24);
            this.ItemForReceiver.Text = "Receiver";
            this.ItemForReceiver.TextSize = new System.Drawing.Size(42, 13);
            // 
            // ItemForSubject
            // 
            this.ItemForSubject.Control = this.SubjectTextEdit;
            this.ItemForSubject.Location = new System.Drawing.Point(0, 48);
            this.ItemForSubject.Name = "ItemForSubject";
            this.ItemForSubject.Size = new System.Drawing.Size(494, 24);
            this.ItemForSubject.Text = "Subject";
            this.ItemForSubject.TextSize = new System.Drawing.Size(42, 13);
            // 
            // ItemForMessage
            // 
            this.ItemForMessage.Control = this.MessageTextEdit;
            this.ItemForMessage.Location = new System.Drawing.Point(0, 72);
            this.ItemForMessage.Name = "ItemForMessage";
            this.ItemForMessage.Size = new System.Drawing.Size(494, 229);
            this.ItemForMessage.Text = "Message";
            this.ItemForMessage.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForMessage.TextSize = new System.Drawing.Size(42, 13);
            // 
            // rpgActions
            // 
            this.rpgActions.ItemLinks.Add(this.bbiSend);
            this.rpgActions.Name = "rpgActions";
            this.rpgActions.Text = "Actions";
            // 
            // bbiSend
            // 
            this.bbiSend.Caption = "Send";
            this.bbiSend.Id = 1;
            this.bbiSend.ImageOptions.ImageIndex = 21;
            this.bbiSend.ImageOptions.LargeImageIndex = 21;
            this.bbiSend.Name = "bbiSend";
            // 
            // SendMailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl);
            this.Name = "SendMailView";
            this.Size = new System.Drawing.Size(514, 479);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic16x16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic24x24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ic48x48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl)).EndInit();
            this.dataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FromTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiverTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsModel;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl;
        private DevExpress.XtraEditors.TextEdit FromTextEdit;
        private DevExpress.XtraEditors.TextEdit ReceiverTextEdit;
        private DevExpress.XtraEditors.TextEdit SubjectTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFrom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReceiver;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubject;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMessage;
        private DevExpress.XtraEditors.MemoEdit MessageTextEdit;
        private DevExpress.XtraBars.BarButtonItem bbiSend;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgActions;
    }
}
