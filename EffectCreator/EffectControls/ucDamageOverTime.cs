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
        IEffect cachedEffect;

        public ucDamageOverTime(DamageOverTime damageOverTime) {
            InitializeComponent();
            cachedEffect = damageOverTime;
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

        private void numPotency_ValueChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        private void cbDamageType_SelectedIndexChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        private void numDuration_ValueChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        public void RevertChanges() {
            PopulateForm((DamageOverTime)cachedEffect);
        }

        public void ApplyChanges() {
            cachedEffect = GetEffect();
        }
    }
}
