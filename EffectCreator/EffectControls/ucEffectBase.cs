using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using static EffectCreator.RowValidator;

namespace EffectCreator.EffectControls {
    public partial class ucEffectBase : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        protected ucEffectGroup parent;
        protected string effectName;

        public ucEffectBase() {
            InitializeComponent();
        }

        public ucEffectBase(ucEffectGroup parent) {
            this.parent = parent;
            InitializeComponent();
        }

        //  Cant make control/functions abstract because VS needs to create instance of it to be displayed in the editor
        public virtual IEffect GetEffect() {
            throw new NotImplementedException();
        }

        protected virtual void FieldsModified(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        protected void txtEffectName_Validating(object sender, CancelEventArgs e) {
            string newName = txtEffectName.Text;

            if (effectName != newName) {
                ValidationError validationError = ValidateName(newName, parent.RowKeys());

                if (validationError != ValidationError.None) {
                    DisplayNameErrorMessage(validationError, newName);
                    txtEffectName.Text = effectName;
                }
                else {
                    parent.UpdateRowKey(effectName, newName);
                    effectName = newName;
                    EffectModified?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void ucEffectBase_Load(object sender, EventArgs e) {
            effectName = txtEffectName.Text;
        }
    }
}
