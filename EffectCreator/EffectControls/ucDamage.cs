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
    public partial class ucDamage : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;

        public ucDamage(Damage damage, ucEffectGroup parent) {
            InitializeComponent();
            cbDamageType.DataSource = Enum.GetValues(typeof(DamageType));
            this.parent = parent;

            PopulateForm(damage);
        }

        private void PopulateForm(Damage damage) {
            txtEffectType.Text = "Damage";
            txtEffectName.Text = damage.Name;
            numPotency.Value = (decimal)damage.Potency;
            cbDamageType.SelectedItem = damage.Type;

            effectName = txtEffectName.Text;
        }

        public IEffect GetEffect() {
            return new Damage(txtEffectName.Text, (float)numPotency.Value, (DamageType)cbDamageType.SelectedItem);
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
                    parent.UpdateRowKey(effectName, newName);
                    effectName = newName;
                    EffectModified?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
