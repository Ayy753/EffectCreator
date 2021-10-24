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
    public partial class ucDamageOverTime : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;

        public ucDamageOverTime(DamageOverTime damageOverTime, ucEffectGroup parent) {
            InitializeComponent();
            cbDamageType.DataSource = Enum.GetValues(typeof(DamageType));
            this.parent = parent;

            PopulateForm(damageOverTime);
        }

        private void PopulateForm(DamageOverTime damageOverTime) {
            txtEffectType.Text = "DamageOverTime";
            txtEffectName.Text = damageOverTime.Name;
            numDuration.Value = (decimal)damageOverTime.Duration;
            numPotency.Value = (decimal)damageOverTime.Potency;
            cbDamageType.SelectedItem = damageOverTime.Type;

            effectName = txtEffectName.Text;
        }

        public IEffect GetEffect() {
            return new DamageOverTime(txtEffectName.Text, (float)numPotency.Value, (float)numDuration.Value, (DamageType)cbDamageType.SelectedItem, true);
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
