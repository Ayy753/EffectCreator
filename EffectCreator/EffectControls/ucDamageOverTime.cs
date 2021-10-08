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
    public partial class ucDamageOverTime : UserControl, IEffectUserControl {
        public ucDamageOverTime(DamageOverTime damageOverTime) {
            InitializeComponent();
            cbDamageType.DataSource = Enum.GetValues(typeof(DamageType));
            PopulateForm(damageOverTime);
        }

        private void PopulateForm(DamageOverTime damageOverTime) {
            numDuration.Value = (decimal)damageOverTime.Duration;
            numPotency.Value = (decimal)damageOverTime.Potency;
            cbDamageType.SelectedItem = damageOverTime.Type;
        }

        public IEffect GetEffect() {
            return new DamageOverTime((float)numPotency.Value, (float)numDuration.Value, (DamageType)cbDamageType.SelectedItem, true);
        }
    }
}
