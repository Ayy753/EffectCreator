using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmCreateNewEffect : Form {
        public EffectType EffectType { get; private set; }
        public string EffectName { get; private set; }

        private ucEffectGroup parent;

        enum ValidationError {
            None, NameEmpty, NameNotUnique
        }

        public frmCreateNewEffect(ucEffectGroup ucEffectGroup) {
            InitializeComponent();
            this.parent = ucEffectGroup;
            cbEffectType.DataSource = Enum.GetValues(typeof(EffectType));
        }

        private void cbEffectType_SelectedIndexChanged(object sender, EventArgs e) {
            EffectType = (EffectType)cbEffectType.SelectedItem;
        }

        private void txtEffectName_TextChanged(object sender, EventArgs e) {
            EffectName = txtEffectName.Text;
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            ValidationError validationError = ValidEffectName();

            //  Prevent form from submitting if there is a naming error
            if (validationError != ValidationError.None) {
                DialogResult = DialogResult.None;
                DisplayErrorDialog(validationError);
            }
        }

        private ValidationError ValidEffectName() {
            if (string.IsNullOrWhiteSpace(EffectName)) {
                return ValidationError.NameEmpty;
            }
            else if (parent.EffectListContainsName(EffectName)) {
                return ValidationError.NameNotUnique;
            }
            else {
                return ValidationError.None;
            }
        }

        private void DisplayErrorDialog(ValidationError validationError) {
            if (validationError == ValidationError.NameEmpty) {
                MessageBox.Show($"The effect name cannot be empty.",
                    "Effect Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validationError == ValidationError.NameNotUnique) {
                MessageBox.Show($"The Effect name '{EffectName}' already exists for this EffectGroup, please choose another.",
                    "Effect Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
