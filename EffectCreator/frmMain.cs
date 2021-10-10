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
            if (lbEffectGroups.SelectedIndex >= 0) {
                EffectGroup selectedEffectGroup = GetSelectedEffectGroup();
                if (selectedEffectGroup != null) {
                    ucEffectGroup1.LoadEffectGroup(selectedEffectGroup);
                }
                else {
                    MessageBox.Show($"Error: '{lbEffectGroups.SelectedItem}' does not map to any EffectGroup object in the effects.json file");
                }
            }
        }

        private EffectGroup GetSelectedEffectGroup() {
            foreach (EffectGroup effectGroup in effectGroups) {
                if (effectGroup.Name == lbEffectGroups.SelectedItem.ToString()) {
                    return effectGroup;
                }
            }
            return null;
        }
    }
}
