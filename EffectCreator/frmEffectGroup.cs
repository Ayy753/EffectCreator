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

            if (effect is Damage damage) {
                control = new ucDamage(damage);
            }
            else if (effect is DamageOverTime damageOverTime) {
                control = new ucDamageOverTime(damageOverTime);
            }
            else if (effect is Buff buff) {
                control = new ucBuff(buff);
            }
            else if (effect is StatMod statMod) {
                control = new ucStatMod(statMod);
            }
            else if (effect is Debuff debuff) {
                control = new ucDebuff(debuff);
            }
            else {
                control = new ucHeal((Heal)effect);
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
