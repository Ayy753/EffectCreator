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
    public partial class ucBuff : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;

        public ucBuff(Buff buff, ucEffectGroup parent) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            this.parent = parent;
            PopulateForm(buff);
        }

        private void PopulateForm(Buff buff) {
            txtEffectType.Text = "Buff";
            txtEffectName.Text = buff.Name;
            numPotency.Value = (decimal)buff.Potency;
            cbStatType.SelectedItem = buff.StatType;
            cbExpires.Checked = buff.Expires;

            lblDuration.Enabled = buff.Expires;
            numDuration.Enabled = buff.Expires;

            if (cbExpires.Checked) {
                numDuration.Value = (decimal)buff.Duration;
            }

            effectName = txtEffectName.Text;
        }

        private void cbExpires_CheckStateChanged(object sender, EventArgs e) {
            lblDuration.Enabled = cbExpires.Checked;
            numDuration.Enabled = cbExpires.Checked;

            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        public IEffect GetEffect() {
            return new Buff(txtEffectName.Text, (float)numPotency.Value, (float)numDuration.Value, (StatType)cbStatType.SelectedItem, cbExpires.Checked);
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
