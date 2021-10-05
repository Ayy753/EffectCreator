using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmMain : Form {

        private ReadOnlyCollection<EffectGroup> effectGroups;

        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox();
        }

        private void PopulateEffectGroupListBox() {
            effectGroups = EffectParser.GetEffectGroups();

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

        private void btnOpenEffectGroup_Click(object sender, EventArgs e) {
            EffectGroup selectedEffectGroup = null;

            foreach (EffectGroup effectGroup in effectGroups) {
                if (effectGroup.Name == lbEffectGroups.SelectedItem.ToString()) {
                    selectedEffectGroup = effectGroup;
                }
            }

            if (selectedEffectGroup != null) {
                frmEffectGroup newEFfectGroupForm = new frmEffectGroup(selectedEffectGroup);
                newEFfectGroupForm.ShowDialog();
            }
        }
    }
}
