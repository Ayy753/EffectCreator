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
        
        public ucStatMod(StatMod statMod) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            PopulateForm(statMod);
        }

        private void PopulateForm(StatMod statMod) {
            txtEffectType.Text = "StatMod";
            txtEffectName.Text = statMod.Name;
            cbStatType.SelectedItem = statMod.StatType;
        }

        public IEffect GetEffect() {
            return new StatMod(txtEffectName.Text, (float)numPotency.Value, (StatType)cbStatType.SelectedItem);
        }

        private void FieldsModified(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }
    }
}
