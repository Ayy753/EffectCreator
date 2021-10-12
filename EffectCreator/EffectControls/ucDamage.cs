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
    public partial class ucDamage : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        
        public ucDamage(Damage damage) {
            InitializeComponent();
            cbDamageType.DataSource = Enum.GetValues(typeof(DamageType));
            PopulateForm(damage);
        }

        private void PopulateForm(Damage damage) {
            numPotency.Value = (decimal)damage.Potency;
            cbDamageType.SelectedItem = damage.Type;
        }

        public IEffect GetEffect() {
            return new Damage((float)numPotency.Value, (DamageType)cbDamageType.SelectedItem);
        }

        private void numPotency_ValueChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        private void cbDamageType_SelectedIndexChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }
    }
}
