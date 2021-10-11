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
    public partial class ucStatMod : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        IEffect cachedEffect;

        public ucStatMod(StatMod statMod) {
            InitializeComponent();
            cachedEffect = statMod;
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            PopulateForm(statMod);
        }

        private void PopulateForm(StatMod statMod) {
            cbStatType.SelectedItem = statMod.StatType;
        }

        public IEffect GetEffect() {
            return new StatMod((float)numPotency.Value, (StatType)cbStatType.SelectedItem);
        }

        private void numPotency_ValueChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        private void cbStatType_SelectedIndexChanged(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }

        public void RevertChanges() {
            PopulateForm((StatMod)cachedEffect);
        }

        public void ApplyChanges() {
            cachedEffect = GetEffect();
        }
    }
}
