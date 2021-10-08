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
    public partial class ucBuff : UserControl, IEffectUserControl {
        public ucBuff(Buff buff) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            PopulateForm(buff);
        }

        private void PopulateForm(Buff buff) {
            numPotency.Value = (decimal)buff.Potency;
            cbStatType.SelectedItem = buff.StatType;
            cbExpires.Checked = buff.Expires;

            lblDuration.Enabled = buff.Expires;
            numDuration.Enabled = buff.Expires;

            if (cbExpires.Checked) {
                numDuration.Value = (decimal)buff.Duration;
            }
        }

        private void cbExpires_CheckStateChanged(object sender, EventArgs e) {
            lblDuration.Enabled = cbExpires.Checked;
            numDuration.Enabled = cbExpires.Checked;
        }

        public IEffect GetEffect() {
            return new Buff((float)numPotency.Value, (float)numDuration.Value, (StatType)cbStatType.SelectedItem, cbExpires.Checked);
        }
    }
}
