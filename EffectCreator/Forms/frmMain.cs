using EffectCreator.Forms;
using EffectCreator.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmMain : Form {
        private Dictionary<string, EffectGroup> nameToEffectGroup = new Dictionary<string, EffectGroup>();
        private string selectedRow = string.Empty;

        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox(IOHandler.OpenDefault());
            ucEffectGroup1.SetParent(this);
            ucEffectGroup1.EffectGroupModified += UcEffectGroup1_EffectGroupModified;
        }

        private void UcEffectGroup1_EffectGroupModified(object sender, EventArgs e) {
            UpdateSelectedEffectGroup();
        }

        private void PopulateEffectGroupListBox(List<EffectGroup> effectGroups) {
            selectedRow = string.Empty;
            lbEffectGroups.Items.Clear();
            nameToEffectGroup.Clear();

            foreach (EffectGroup group in effectGroups) {
                lbEffectGroups.Items.Add(group.Name);
                nameToEffectGroup.Add(group.Name, group);
            }

            if (lbEffectGroups.Items.Count > 0) {
                lbEffectGroups.SelectedIndex = 0;
            }
        }

        private void lbEffectGroups_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbEffectGroups.SelectedIndex >= 0) {
                btnDeleteEffectGroup.Enabled = true;
                selectedRow = lbEffectGroups.SelectedItem.ToString();
                EffectGroup selectedEffectGroup = nameToEffectGroup[selectedRow];
                ucEffectGroup1.LoadEffectGroup(selectedEffectGroup);
            }
            else {
                btnDeleteEffectGroup.Enabled = false;
            }
        }

        private void UpdateSelectedEffectGroup() {
            if (selectedRow != string.Empty) {
                nameToEffectGroup[selectedRow] = ucEffectGroup1.GetEffectGroup();
                Debug.WriteLine("updated effectgroup " + selectedRow);
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
            IOHandler.Save(EffectGroups());
        }

        private List<EffectGroup> EffectGroups() {
            List<EffectGroup> effectGroups = new List<EffectGroup>();

            UpdateSelectedEffectGroup();

            foreach (EffectGroup effectGroup in nameToEffectGroup.Values) {
                effectGroups.Add(effectGroup);
            }

            return effectGroups;
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            IOHandler.SaveAs(EffectGroups());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            PopulateEffectGroupListBox(IOHandler.Open());
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            PopulateEffectGroupListBox(IOHandler.NewFile());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
