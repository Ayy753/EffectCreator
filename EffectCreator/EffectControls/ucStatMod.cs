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
    public partial class ucStatMod : UserControl {
        public ucStatMod(StatMod statMod) {
            InitializeComponent();
            PopulateForm(statMod);
        }

        private void PopulateForm(StatMod statMod) {
            cbStatType.SelectedItem = statMod.StatType.ToString();
        }
    }
}
