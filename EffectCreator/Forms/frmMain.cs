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

        private bool isDirty = false;

        public frmMain() {
            InitializeComponent();
            PopulateEffectGroupListBox(IOHandler.OpenDefault());
            ucEffectGroup1.SetParent(this);
            ucEffectGroup1.EffectGroupModified += UcEffectGroup1_EffectGroupModified;
            SetDirty(false);
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

        private void UcEffectGroup1_EffectGroupModified(object sender, EventArgs e) {
            SetDirty(true);
            UpdateSelectedEffectGroup();
        }

        private void SetDirty(bool isDirty) {
            this.isDirty = isDirty;
            UpdateFormText(isDirty);
        }

        private void UpdateFormText(bool isDirty) {
            string prefix = isDirty ? "*" : string.Empty;
            this.Text = $"{prefix}{IOHandler.ActiveFileName()} - Effect Creator";
        }

        private void UpdateSelectedEffectGroup() {
            if (selectedRow != string.Empty) {
                nameToEffectGroup[selectedRow] = ucEffectGroup1.GetEffectGroup();
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

        private void btnNewEffectGroup_Click(object sender, EventArgs e) {
            using (frmCreateEffectGroup frmCreateEffectGroup = new frmCreateEffectGroup(this)) {
                if (frmCreateEffectGroup.ShowDialog() == DialogResult.OK) {
                    CreateNewEffectGroup(frmCreateEffectGroup.EffectGroupName);
                    isDirty = true;
                }
            }
        }

        private void CreateNewEffectGroup(string effectGroupName) {
            EffectGroup newEffectGroup = new EffectGroup(effectGroupName, string.Empty, 1,
                TargetType.Area, ParticleType.Blood, SoundType.arrowFire, 1, new IEffect[] { });

            nameToEffectGroup[effectGroupName] = newEffectGroup;
            lbEffectGroups.Items.Add(effectGroupName);

            ucEffectGroup1.Visible = true;
            lbEffectGroups.SelectedIndex = lbEffectGroups.Items.Count - 1;
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

                isDirty = true;
            }
        }

        private void RemoveSelectedEffectGroup() {
            string selectedName = lbEffectGroups.SelectedItem.ToString();

            nameToEffectGroup.Remove(selectedName);
            lbEffectGroups.Items.Remove(selectedName);
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            NewFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
            ForceEffectGroupValidation();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control){
                if (e.KeyCode == Keys.S) {
                    if (e.Alt)
                        SaveAs();
                    else 
                        Save();
                }
                else if (e.KeyCode == Keys.N) {
                    NewFile();
                }
                else if (e.KeyCode == Keys.O) {
                    OpenFile();
                }
                else if (e.KeyCode == Keys.X) {
                    Exit();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e) {
            e.SuppressKeyPress = false;
        }

        private void SaveAs() {
            ForceEffectGroupValidation();
            IOHandler.SaveAs(EffectGroups());
            SetDirty(false);
        }

        private void Save() {
            ForceEffectGroupValidation();
            IOHandler.Save(EffectGroups());
            SetDirty(false);
        }

        private void ForceEffectGroupValidation() {
            ucEffectGroup1.Validate();
        }

        private List<EffectGroup> EffectGroups() {
            List<EffectGroup> effectGroups = new List<EffectGroup>();

            foreach (EffectGroup effectGroup in nameToEffectGroup.Values) {
                effectGroups.Add(effectGroup);
            }
            return effectGroups;
        }

        private void NewFile() {
            if (HandleDirty()) {
                PopulateEffectGroupListBox(IOHandler.NewFile());
                SetDirty(false);
            }
        }

        private void OpenFile() {
            if (HandleDirty()) {
                List<EffectGroup> effectGroups = IOHandler.Open();
                if (effectGroups.Count > 0) {
                    PopulateEffectGroupListBox(effectGroups);
                    SetDirty(false);
                }
            }
        }

        private void Exit() {
            if (HandleDirty()) {
                Application.Exit();
            }
        }

        private bool HandleDirty() {
            if (isDirty) {
                return IOHandler.HandleDirty(EffectGroups());
            }
            else {
                return true;
            }
        }

        public List<string> RowKeys() {
            return nameToEffectGroup.Keys.ToList();
        }
    }
}
