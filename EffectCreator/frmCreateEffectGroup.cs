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
    public partial class frmCreateEffectGroup : Form {
        private frmMain parent;

        public string EffectGroupName { get; private set; }

        enum ValidationError {
            None,
            NameEmpty,
            DuplicateName
        }

        public frmCreateEffectGroup(frmMain frmMain) {
            InitializeComponent();
            parent = frmMain;
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            EffectGroupName = txtEffectName.Text;
            ValidationError validationError = ValidateName(EffectGroupName);

            //  Prevent submission if validation error
            if (validationError != ValidationError.None) {
                DisplayErrorMessage(validationError);
                DialogResult = DialogResult.None;
            }
        }

        private ValidationError ValidateName(string name) {
            if (string.IsNullOrWhiteSpace(name)) {
                return ValidationError.NameEmpty;
            }
            else if (parent.EffectGroupListContainsName(name)) {
                return ValidationError.DuplicateName;
            }
            else {
                return ValidationError.None;
            }
        }

        private void DisplayErrorMessage(ValidationError validationError) {
            if (validationError == ValidationError.NameEmpty) {
                MessageBox.Show($"The EffectGroup name cannot be empty.",
                    "EffectGroup Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validationError == ValidationError.DuplicateName) {
                MessageBox.Show($"The EffectGroup name '{EffectGroupName}' already exists for this EffectGroup, please choose another.",
                    "EffectGroup Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
