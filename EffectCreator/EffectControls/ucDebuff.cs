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
    public partial class ucDebuff : UserControl {
        public ucDebuff(Debuff debuff) {
            InitializeComponent();
            PopulateForm(debuff);
        }

        private void PopulateForm(Debuff debuff) {
            numPotency.Value = (decimal)debuff.Potency;
            numDuration.Value = (decimal)debuff.Duration;
            cbResistType.SelectedItem = debuff.ResistType.ToString();
            cbStatType.SelectedItem = debuff.StatType.ToString();
            cbExpires.Checked = debuff.Expires;
        }
    }
}
