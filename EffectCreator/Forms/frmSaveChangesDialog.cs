using System;
using System.Windows.Forms;

namespace EffectCreator.Forms {
    public partial class frmSaveChangesDialog : Form {
        public frmSaveChangesDialog(string fileName) {
            InitializeComponent();
            lblSaveDialog.Text = $"Do you want to save changes to {fileName}?";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Yes;
        }

        private void btnDontSave_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.No;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
