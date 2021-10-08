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
        public ucStatMod(StatMod statMod) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            PopulateForm(statMod);
        }

        private void PopulateForm(StatMod statMod) {
            cbStatType.SelectedItem = statMod.StatType;
        }

        public IEffect GetEffect() {
            return new StatMod((float)numPotency.Value, (StatType)cbStatType.SelectedItem);
        }
    }
}
