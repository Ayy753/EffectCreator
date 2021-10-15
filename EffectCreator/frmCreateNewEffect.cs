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
using static EffectCreator.RowValidator;

namespace EffectCreator {
    public partial class frmCreateNewEffect : Form {
        public EffectType EffectType { get; private set; }
        public string EffectName { get; private set; }

        private ucEffectGroup parent;

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
            EffectName = txtEffectName.Text;
            ValidationError validationError = ValidateName(EffectName, parent.RowKeys());

            //  Prevent submission if validation error
            if (validationError != ValidationError.None) {
                DisplayNameErrorMessage(validationError, EffectName);
                DialogResult = DialogResult.None;
            }
        }
    }
}
