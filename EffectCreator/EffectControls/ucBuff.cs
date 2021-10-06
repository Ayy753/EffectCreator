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
    public partial class ucBuff : UserControl {
        public ucBuff(Buff buff) {
            InitializeComponent();
            PopulateForm(buff);
        }

        private void PopulateForm(Buff buff) {
            numPotency.Value = (decimal)buff.Potency;
            numDuration.Value = (decimal)buff.Duration;
            cbStatType.SelectedItem = buff.Type.ToString();
            cbExpires.Checked = buff.Expires;
        }
    }
}
