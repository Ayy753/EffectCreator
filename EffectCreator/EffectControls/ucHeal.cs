using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EffectCreator.RowValidator;

namespace EffectCreator.EffectControls {
    public partial class ucHeal : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;
        
        public ucHeal(Heal heal, ucEffectGroup parent) {
            InitializeComponent();
            this.parent = parent;
            PopulateForm(heal);
        }

        private void PopulateForm(Heal heal) {
            txtEffectType.Text = "Heal";
            txtEffectName.Text = heal.Name;
            numPotency.Value = (decimal)heal.Potency;

            effectName = txtEffectName.Text;
        }

        public IEffect GetEffect() {
            return new Heal(txtEffectName.Text, (float)numPotency.Value);
        }

        private void FieldsModified(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        private void txtEffectName_Validating(object sender, CancelEventArgs e) {
            string newName = txtEffectName.Text;

            if (effectName != newName) {
                ValidationError validationError = ValidateName(newName, parent.RowKeys());

                if (validationError != ValidationError.None) {
                    DisplayNameErrorMessage(validationError, newName);
                    txtEffectName.Text = effectName;
                }
                else {
                    effectName = newName;
                    EffectModified?.Invoke(this, EventArgs.Empty);
                    parent.UpdateRowKey(effectName, newName);
                }
            }
        }
    }
}
