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

namespace EffectCreator.EffectControls {
    public partial class ucStatMod : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        private ucEffectGroup parent;
        private string effectName;
        private bool ready;

        public ucStatMod(StatMod statMod, ucEffectGroup parent) {
            InitializeComponent();
            cbStatType.DataSource = Enum.GetValues(typeof(StatType));
            this.parent = parent;
            PopulateForm(statMod);
        }

        private void PopulateForm(StatMod statMod) {
            ready = false;

            txtEffectType.Text = "StatMod";
            txtEffectName.Text = statMod.Name;
            cbStatType.SelectedItem = statMod.StatType;

            effectName = txtEffectName.Text;
            ready = true;
        }

        public IEffect GetEffect() {
            return new StatMod(txtEffectName.Text, (float)numPotency.Value, (StatType)cbStatType.SelectedItem);
        }

        private void FieldsModified(object sender, EventArgs e) {
            if (ready) {
                EffectModified?.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtEffectName_Validating(object sender, CancelEventArgs e) {
            string newName = txtEffectName.Text;

            if (effectName != newName) {
                ValidationError validationError = ValidateName(newName, parent.RowKeys());

                if (validationError != ValidationError.None) {
                    DisplayNameErrorMessage(validationError, newName);
                    txtEffectName.Text = effectName;
                }
                else {
                    effectName = newName;
                    EffectModified?.Invoke(this, EventArgs.Empty);
                    parent.UpdateRowKey(effectName, newName);
                }
            }
        }
    }
}
