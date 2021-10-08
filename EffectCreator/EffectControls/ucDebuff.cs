using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectCreator.EffectControls {
    public partial class ucDebuff : UserControl, IEffectUserControl {
        public ucDebuff(Debuff debuff) {
            InitializeComponent();
            PopulateForm(debuff);
        }

        private void PopulateForm(Debuff debuff) {
            numPotency.Value = (decimal)debuff.Potency;
            cbResistType.SelectedItem = debuff.ResistType.ToString();
            cbStatType.SelectedItem = debuff.StatType.ToString();
            cbExpires.Checked = debuff.Expires;

            lblDuration.Enabled = debuff.Expires;
            numDuration.Enabled = debuff.Expires;

            if (debuff.Expires) {
                numDuration.Value = (decimal)debuff.Duration;
            }
        }

        private void cbExpires_CheckedChanged(object sender, EventArgs e) {
            lblDuration.Enabled = cbExpires.Checked;
            numDuration.Enabled = cbExpires.Checked;
        }

        public IEffect GetEffect() {
            return new Debuff((float)numPotency.Value, (float)numDuration.Value, (StatType)cbStatType.SelectedItem, (DamageType)cbResistType.SelectedItem, cbExpires.Checked);
        }
    }
}
