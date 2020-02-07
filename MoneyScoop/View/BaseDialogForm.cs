using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM.Services;

namespace MoneyScoop.View
{
    public partial class BaseDialogForm : XtraDialogForm, IDialogForm
    {
        private Control content;
        private DialogResult resultOk = DialogResult.OK;
        private DialogResult resultCancel = DialogResult.Cancel;

        public BaseDialogForm()
        {
            InitializeComponent();

            AcceptButton = sbOk;
            CancelButton = sbCancel;

            sbOk.Click += (s, e) => { DialogResult = resultOk; };
            sbCancel.Click += (s, e) => { DialogResult = resultCancel; };
        }

        public DialogResult ShowDialog(IWin32Window owner, Control content, string caption, DialogResult[] buttons)
        {
            Text = caption;
            this.content = content;

            Size = content.Size;
            Resize += (s, e) =>
            {
                content.Size = Size;
            };

            if (buttons != null)
            {
                sbOk.Visible = buttons.Contains(DialogResult.OK) || buttons.Contains(DialogResult.Yes);
                sbCancel.Visible = buttons.Contains(DialogResult.Cancel) || buttons.Contains(DialogResult.No);

                sbOk.Text = buttons.Contains(DialogResult.Yes) ? "Yes" : "OK";
                sbCancel.Text = buttons.Contains(DialogResult.No) ? "No" : "Cancel";
            }

            Controls.Add(content);
            return ShowDialog(owner);
        }

        public Control Content { get { return content; } }
    }
}
