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
        private Dictionary<string, IEffect> listboxRowToEffect;

        public frmEffectGroup() {
            InitializeComponent();
        }

        public frmEffectGroup(EffectGroup effectGroup) {
            InitializeComponent();

            listboxRowToEffect = new Dictionary<string, IEffect>();
            PopulateForm(effectGroup);

            if (lbEffects.Items.Count > 0) {
                lbEffects.SelectedIndex = 0;
            }


        }

        private void PopulateForm(EffectGroup effectGroup) {
            tbName.Text = effectGroup.Name;
            tbDescription.Text = effectGroup.Description;
            cbSoundType.SelectedItem = effectGroup.SoundType.ToString();
            cbParticleType.SelectedItem = effectGroup.ParticleName.ToString();
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

            if (lbEffects.SelectedIndex != -1) {
                string rowKey = lbEffects.SelectedItem.ToString();
                IEffect effect = listboxRowToEffect[rowKey];
                IEffectUserControl control;

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
                cbEffectType.SelectedItem = effect.GetType().Name;

                btnRemove.Enabled = true;
            }
            else {
                btnRemove.Enabled = false;
            }
        }

        private void RemoveExistingEffectControl() {
            if (scEffect.Panel2.Controls.Count > 0) {
                scEffect.Panel2.Controls.RemoveAt(0);
            }
        }

        private void AddEffectControl(IEffectUserControl control) {
            scEffect.Panel2.Controls.Add((Control)control);
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

        private void btnRemove_Click(object sender, EventArgs e) {
            int selectedRowIndex = lbEffects.SelectedIndex;
            string rowKey = lbEffects.SelectedItem.ToString();
            listboxRowToEffect.Remove(rowKey);
            lbEffects.Items.RemoveAt(selectedRowIndex);

            if (selectedRowIndex > 0) {
                lbEffects.SelectedIndex = selectedRowIndex -1;
            }
            else if (selectedRowIndex == 0 && lbEffects.Items.Count >= 1) {
                lbEffects.SelectedIndex = 0;
            }
        }

        public EffectGroup GetEffectGroup() {
            string name = tbName.Text;
            string desc = tbDescription.Text;
            float radius = (float)numRadius.Value;
            TargetType targetType = radTargetIndividual.Checked ? TargetType.Individual : TargetType.Area;
            ParticleType particleType = (ParticleType)cbParticleType.SelectedItem;
            SoundType soundType = (SoundType)cbSoundType.SelectedIndex;
            float cooldown = (float)numCooldown.Value;
            List<IEffect> effects = new List<IEffect>();

            foreach (IEffect item in listboxRowToEffect.Values) {
                effects.Add(item);
            }

            return new EffectGroup(name, desc, radius, targetType, particleType, soundType, cooldown, effects.ToArray());
        }
    }
}
