using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmMain : Form {
        private Dictionary<string, EffectGroup> nameToEffectGroup;
        private string selectedRow = string.Empty;

        private bool formInitialized = false;

        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox();

            ucEffectGroup1.SetParent(this);
        }

        private void PopulateEffectGroupListBox() {
            List<EffectGroup> effectGroups = EffectParser.GetEffectGroups();
            nameToEffectGroup = new Dictionary<string, EffectGroup>();

            foreach (EffectGroup group in effectGroups) {
                lbEffectGroups.Items.Add(group.Name);
                nameToEffectGroup.Add(group.Name, group);
            }
        }

        private void lbEffectGroups_SelectedIndexChanged(object sender, EventArgs e) {
            if (formInitialized && lbEffectGroups.SelectedIndex >= 0) {
                btnDeleteEffectGroup.Enabled = true;

                UpdatePreviouslySelectedEffectGroup();
                selectedRow = lbEffectGroups.SelectedItem.ToString();

                EffectGroup selectedEffectGroup = nameToEffectGroup[selectedRow];
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

        private void UpdatePreviouslySelectedEffectGroup() {
            if (selectedRow != string.Empty) {
                nameToEffectGroup[selectedRow] = ucEffectGroup1.GetEffectGroup();
            }
        }

        public List<string> RowKeys() {
            return nameToEffectGroup.Keys.ToList();
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

            nameToEffectGroup[effectGroupName] = newEffectGroup;
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
                    selectedRow = string.Empty;
                }
            }
        }

        private void RemoveSelectedEffectGroup() {
            string selectedName = lbEffectGroups.SelectedItem.ToString();

            nameToEffectGroup.Remove(selectedName);
            lbEffectGroups.Items.Remove(selectedName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            List<EffectGroup> effectGroups = new List<EffectGroup>();

            UpdatePreviouslySelectedEffectGroup();

            foreach (EffectGroup effectGroup in nameToEffectGroup.Values) {
                effectGroups.Add(effectGroup);
            }

            EffectSerializer.SaveEffectGroups(effectGroups);
        }

        public void UpdateRowKey(string rowKey, string newName) {
            nameToEffectGroup.Remove(rowKey);
            nameToEffectGroup.Add(newName, ucEffectGroup1.GetEffectGroup());

            int index = lbEffectGroups.Items.IndexOf(rowKey);
            lbEffectGroups.Items.RemoveAt(index);
            lbEffectGroups.Items.Insert(index, newName);
            lbEffectGroups.SelectedIndex = index;
            selectedRow = newName;
        }

        private void frmMain_Load(object sender, EventArgs e) {
            formInitialized = true;

            if (lbEffectGroups.Items.Count > 0) {
                lbEffectGroups.SelectedIndex = 0;
            }
        }
    }
}
