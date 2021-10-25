using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EffectCreator.RowValidator;

namespace EffectCreator.EffectControls {
    public partial class ucDebuff : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;
        private bool ready = false; 

        public ucDebuff(Debuff debuff, ucEffectGroup parent) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            cbResistType.DataSource = Enum.GetValues(typeof(DamageType));
            this.parent = parent;

            PopulateForm(debuff);
        }

        private void PopulateForm(Debuff debuff) {
            ready = false;

            txtEffectType.Text = "Debuff";
            txtEffectName.Text = debuff.Name;
            numPotency.Value = (decimal)debuff.Potency;
            cbResistType.SelectedItem = debuff.ResistType;
            cbStatType.SelectedItem = debuff.StatType;
            cbExpires.Checked = debuff.Expires;

            lblDuration.Enabled = debuff.Expires;
            numDuration.Enabled = debuff.Expires;

            if (debuff.Expires) {
                numDuration.Value = (decimal)debuff.Duration;
            }

            effectName = txtEffectName.Text;
            ready = true;
        }

        private void cbExpires_CheckedChanged(object sender, EventArgs e) {
            lblDuration.Enabled = cbExpires.Checked;
            numDuration.Enabled = cbExpires.Checked;
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        public IEffect GetEffect() {
            return new Debuff(txtEffectName.Text, (float)numPotency.Value, (float)numDuration.Value, (StatType)cbStatType.SelectedItem, (DamageType)cbResistType.SelectedItem, cbExpires.Checked);
        }

        private void FieldsModified(object sender, EventArgs e) {
            if (ready) {
                EffectModified?.Invoke(this, EventArgs.Empty);
            }
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
