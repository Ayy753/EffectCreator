using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmCreateNewEffect : Form {
        public EffectType EffectType { get; private set; }
        public string EffectName { get; private set; }
        public frmCreateNewEffect() {
            InitializeComponent();
            cbEffectType.DataSource = Enum.GetValues(typeof(EffectType));
        }

        private void cbEffectType_SelectedIndexChanged(object sender, EventArgs e) {
            EffectType = (EffectType)cbEffectType.SelectedItem;
        }

        private void txtEffectName_TextChanged(object sender, EventArgs e) {
            EffectName = txtEffectName.Text;
        }
    }
}
