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
        private EffectGroup effectGroup;
        private Dictionary<string, IEffect> listboxRowToEffect;

        public frmEffectGroup() {
            InitializeComponent();
        }

        public frmEffectGroup(EffectGroup effectGroup) {
            InitializeComponent();

            listboxRowToEffect = new Dictionary<string, IEffect>();
            this.effectGroup = effectGroup;
            PopulateForm();
        }

        private void PopulateForm() {
            tbName.Text = effectGroup.Name;
            tbDescription.Text = effectGroup.Description;
            cbSoundType.SelectedItem = effectGroup.SoundType.ToString();
            numCooldown.Value = (decimal)effectGroup.Cooldown;
            radTargetGroup.Checked = effectGroup.Type == TargetType.Area;
            numRadius.Value = (decimal)effectGroup.Radius;

            foreach (IEffect effect in effectGroup.Effects) {
                string rowKey = "Effect " + lbEffects.Items.Count;
                listboxRowToEffect.Add(rowKey, effect);
                lbEffects.Items.Add(rowKey);
            }
        }

        private void lbEffects_SelectedIndexChanged(object sender, EventArgs e) {
            RemoveExistingEffectControl();

            string rowKey = lbEffects.SelectedItem.ToString();
            IEffect effect = listboxRowToEffect[rowKey];
            UserControl control;

            if (effect is Damage) {
                control = new ucDamage();
            }
            else if (effect is DamageOverTime) {
                control = new ucDamageOverTime();
            }
            else if (effect is Buff) {
                control = new ucBuff();
            }
            else if (effect is StatMod) {
                control = new ucStatMod();
            }
            else if (effect is Debuff) {
                control = new ucDebuff();
            }
            else {
                control = new ucHeal();
            }

            AddEffectControl(control);
        }

        private void RemoveExistingEffectControl() {
            if (scEffect.Panel2.Controls.Count > 0) {
                scEffect.Panel2.Controls.RemoveAt(0);
            }
        }

        private void AddEffectControl(UserControl control) {
            scEffect.Panel2.Controls.Add(control);
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
