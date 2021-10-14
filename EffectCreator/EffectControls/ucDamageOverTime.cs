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
        public event EventHandler EffectModified;
        
        public ucDamageOverTime(DamageOverTime damageOverTime) {
            InitializeComponent();
            cbDamageType.DataSource = Enum.GetValues(typeof(DamageType));
            PopulateForm(damageOverTime);
        }

        private void PopulateForm(DamageOverTime damageOverTime) {
            txtEffectType.Text = "DamageOverTime";
            txtEffectName.Text = damageOverTime.Name;
            numDuration.Value = (decimal)damageOverTime.Duration;
            numPotency.Value = (decimal)damageOverTime.Potency;
            cbDamageType.SelectedItem = damageOverTime.Type;
        }

        public IEffect GetEffect() {
            return new DamageOverTime(txtEffectName.Text, (float)numPotency.Value, (float)numDuration.Value, (DamageType)cbDamageType.SelectedItem, true);
        }

        private void FieldsModified(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }
    }
}
