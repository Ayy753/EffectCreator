using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmMain : Form {

        private List<EffectGroup> effectGroups;

        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox();
        }

        private void PopulateEffectGroupListBox() {
            effectGroups = EffectParser.GetEffectGroups();

            foreach (EffectGroup group in effectGroups) {
                lbEffectGroups.Items.Add(group.Name);
            }

            if (lbEffectGroups.Items.Count > 0) {
                lbEffectGroups.SelectedIndex = 0;
            }
        }

        private void lbEffectGroups_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbEffectGroups.SelectedIndex >= 0) {
                btnDeleteEffectGroup.Enabled = true;

                EffectGroup selectedEffectGroup = GetSelectedEffectGroup();
                if (selectedEffectGroup != null) {
                    ucEffectGroup1.LoadEffectGroup(selectedEffectGroup);
                }
                else {
                    MessageBox.Show($"Error: '{lbEffectGroups.SelectedItem}' does not map to any EffectGroup object in the effects.json file");
                }
            }
            else {
                btnDeleteEffectGroup.Enabled = false;
            }
        }

        public bool EffectGroupListContainsName(string name) {
            foreach (EffectGroup effectGroup in effectGroups) {
                if (effectGroup.Name == name) {
                    return true;
                }
            }
            return false;
        }

        private EffectGroup GetSelectedEffectGroup() {
            foreach (EffectGroup effectGroup in effectGroups) {
                if (effectGroup.Name == lbEffectGroups.SelectedItem.ToString()) {
                    return effectGroup;
                }
            }
            return null;
        }

        private void btnNewEffectGroup_Click(object sender, EventArgs e) {
            using (frmCreateEffectGroup frmCreateEffectGroup = new frmCreateEffectGroup(this)) {
                if (frmCreateEffectGroup.ShowDialog() == DialogResult.OK) {
                    CreateNewEffectGroup(frmCreateEffectGroup.EffectGroupName);
                }
            }
        }

        private void CreateNewEffectGroup(string effectGroupName) {
            EffectGroup newEffectGroup = new EffectGroup(effectGroupName, string.Empty, 1, 
                TargetType.Area, ParticleType.Blood, SoundType.arrowFire, 1, new IEffect[] { });

            effectGroups.Add(newEffectGroup);
            lbEffectGroups.Items.Add(effectGroupName);

            if (lbEffectGroups.SelectedIndex == -1) {
                lbEffectGroups.SelectedIndex = 0;
                ucEffectGroup1.Visible = true;
            }
        }

        private void btnDeleteEffectGroup_Click(object sender, EventArgs e) {
            int selectedIndex = lbEffectGroups.SelectedIndex;
            if (selectedIndex!= -1) {
                RemoveSelectedEffectGroup();

                if (selectedIndex > 0) {
                    lbEffectGroups.SelectedIndex = selectedIndex - 1;
                }
                else if (selectedIndex == 0 && lbEffectGroups.Items.Count > 0) {
                    lbEffectGroups.SelectedIndex = 0;
                }
                else {
                    ucEffectGroup1.Visible = false;
                }
            }
        }

        private void RemoveSelectedEffectGroup() {
            string selectedName = lbEffectGroups.SelectedItem.ToString();
            EffectGroup selectedEG;
            foreach (EffectGroup effectGroup in effectGroups) {
                if (effectGroup.Name == selectedName) {
                    selectedEG = effectGroup;
                    effectGroups.Remove(selectedEG);
                    lbEffectGroups.Items.Remove(selectedName);
                    break;
                }
            }
        }
    }
}
