using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox();
        }

        private void PopulateEffectGroupListBox() {
            ReadOnlyCollection<EffectGroup> effectGroups = EffectParser.GetEffectGroups();

            foreach (EffectGroup group in effectGroups) {
                lbEffectGroups.Items.Add(group.Name);
            }
        }

        private void lbEffectGroups_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbEffectGroups.SelectedIndex >= 0)
                btnOpenEffectGroup.Enabled = true;
            else 
                btnOpenEffectGroup.Enabled = false;
        }
    }
}
