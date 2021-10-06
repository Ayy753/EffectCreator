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
    public partial class ucDamageOverTime : UserControl {
        public ucDamageOverTime(DamageOverTime damageOverTime) {
            InitializeComponent();
            PopulateForm(damageOverTime);
        }

        private void PopulateForm(DamageOverTime damageOverTime) {
            numDuration.Value = (decimal)damageOverTime.Duration;
            numPotency.Value = (decimal)damageOverTime.Potency;
            cbDamageType.SelectedItem = damageOverTime.Type.ToString();
        }
    }
}
