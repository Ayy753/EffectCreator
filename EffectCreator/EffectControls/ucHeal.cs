using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectCreator.EffectControls {
    public partial class ucHeal : UserControl, IEffectUserControl {
        public event EventHandler EffectModified;
        
        public ucHeal(Heal heal) {
            InitializeComponent();
            PopulateForm(heal);
        }

        private void PopulateForm(Heal heal) {
            numPotency.Value = (decimal)heal.Potency;
        }

        public IEffect GetEffect() {
            return new Heal((float)numPotency.Value);
        }

        private void FieldsModified(object sender, EventArgs e) {
            EffectModified?.Invoke(this, EventArgs.Empty);
        }
    }
}
