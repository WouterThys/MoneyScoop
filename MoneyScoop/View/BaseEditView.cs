using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using MoneyScoop.ViewModel;
using MoneyScoop.Model;

namespace MoneyScoop.View
{
    public partial class BaseEditView : BaseRibbonControl
    {
        public BaseEditView()
        {
            InitializeComponent();
        }

        public override void InitializeLayouts()
        {
            base.InitializeLayouts();
            dataLayoutControl.Images = ic16x16;
            InitializeCodeEdit(CodeTextEdit);
            InitializeDescEdit(DescriptionTextEdit);
        }

        protected override void InitializeServices()
        {
            base.InitializeServices();
            mvvmContext.RegisterService("DialogService", DialogService.Create(this, "Dialog", () => new BaseDialogForm()));
        }

        protected virtual MVVMContextFluentAPI<TModel> InitBindings<T, TModel>()
            where TModel : BaseEditViewModel<T>
            where T : class, IBaseObject, new()
        {
            var fluent = mvvmContext.OfType<TModel>();
            fluent.SetObjectDataSourceBinding(bindingSource, m => m.Editable, m => m.UpdateCommands());
            
            fluent.BindCommand(bbiSave, m => m.Save());
            fluent.BindCommand(bbiSaveAndDone, m => m.SaveAndDone());
            fluent.BindCommand(bbiReset, m => m.Reset());
            fluent.BindCommand(bbiDelete, m => m.Delete());
            fluent.BindCommand(bbiCopy, m => m.Copy());

            return fluent;
        }

        protected void InitializeCodeEdit(TextEdit codeEdit)
        {
            codeEdit.Properties.CharacterCasing = CharacterCasing.Upper;
            codeEdit.Properties.MaxLength = 45;

            CodeLengthValidationRule codeValidationRule = new CodeLengthValidationRule
            {
                CaseSensitive = true,
                ErrorText = "Code should be at least 4 characters."
            };
            dxValidationProvider.SetValidationRule(codeEdit, codeValidationRule);
        }

        protected void InitializeDescEdit(TextEdit descEdit)
        {
            descEdit.Properties.MaxLength = 255;
        }

        public class CodeLengthValidationRule : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string code = (string)value;
                return (!string.IsNullOrEmpty(code)) && (code.Length > 3);
            }
        }
    }
}
