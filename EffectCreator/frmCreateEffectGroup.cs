using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EffectCreator.RowValidator;

namespace EffectCreator {
    public partial class frmCreateEffectGroup : Form {
        private frmMain parent;

        public string EffectGroupName { get; private set; }

        public frmCreateEffectGroup(frmMain frmMain) {
            InitializeComponent();
            parent = frmMain;
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            EffectGroupName = txtEffectName.Text;
            ValidationError validationError = ValidateName(EffectGroupName, parent.RowKeys());

            //  Prevent submission if validation error
            if (validationError != ValidationError.None) {
                DisplayNameErrorMessage(validationError, EffectGroupName);
                DialogResult = DialogResult.None;
            }
        }
    }
}
