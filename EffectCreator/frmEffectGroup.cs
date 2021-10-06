using EffectCreator.EffectControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectCreator {
    public partial class frmEffectGroup : Form {
        public frmEffectGroup() {
            InitializeComponent();
        }

        public frmEffectGroup(EffectGroup effectGroup) {
            InitializeComponent();
            PopulateForm(effectGroup);
        }

        private void PopulateForm(EffectGroup effectGroup) {
            tbName.Text = effectGroup.Name;
            tbDescription.Text = effectGroup.Description;
            cbSoundType.SelectedItem = effectGroup.SoundType.ToString();
            numCooldown.Value = (decimal)effectGroup.Cooldown;
            radTargetGroup.Checked = effectGroup.Type == TargetType.Area;
            numRadius.Value = (decimal)effectGroup.Radius;

            foreach (IEffect effect in effectGroup.Effects) {
                lbEffects.Items.Add("Effect " + lbEffects.Items.Count);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ucDamage damageControl = new ucDamage();

            splitContainer1.Panel2.Controls.Add(damageControl);
        }

        private void radTargetIndividual_CheckedChanged(object sender, EventArgs e) {
            if (radTargetGroup.Checked) {
                lblRadius.Visible = true;
                numRadius.Visible = true;
            }
            else {
                lblRadius.Visible = false;
                numRadius.Visible = false;
            }
        }
    }
}
