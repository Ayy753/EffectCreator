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
        private IEffectUserControl activeEffectControl;
        private string activeRowKey;

        public frmEffectGroup() {
            InitializeComponent();
        }

        public frmEffectGroup(EffectGroup effectGroup) {
            InitializeComponent();

            cbSoundType.DataSource = Enum.GetValues(typeof(SoundType));
            cbParticleType.DataSource = Enum.GetValues(typeof(ParticleType));

            listboxRowToEffect = new Dictionary<string, IEffect>();
            PopulateForm(effectGroup);

            if (lbEffects.Items.Count > 0) {
                lbEffects.SelectedIndex = 0;
            }
        }

        private void PopulateForm(EffectGroup effectGroup) {
            tbName.Text = effectGroup.Name;
            tbDescription.Text = effectGroup.Description;
            cbSoundType.SelectedItem = effectGroup.SoundType;
            cbParticleType.SelectedItem = effectGroup.ParticleName;
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
            if (lbEffects.SelectedIndex != -1) {
                OpenSelectedEffect();
                btnRemove.Enabled = true;
            }
            else {
                btnRemove.Enabled = false;
            }
        }

        private void btnRevertChanges_Click(object sender, EventArgs e) {
            if (lbEffects.SelectedIndex != -1) {
                OpenSelectedEffect();
            }
        }

        private void OpenSelectedEffect() {
            RemoveExistingEffectControl();
            activeRowKey = lbEffects.SelectedItem.ToString();
            IEffect effect = listboxRowToEffect[activeRowKey];

            if (effect is Damage damage) {
                activeEffectControl = new ucDamage(damage);
            }
            else if (effect is DamageOverTime damageOverTime) {
                activeEffectControl = new ucDamageOverTime(damageOverTime);
            }
            else if (effect is Buff buff) {
                activeEffectControl = new ucBuff(buff);
            }
            else if (effect is StatMod statMod) {
                activeEffectControl = new ucStatMod(statMod);
            }
            else if (effect is Debuff debuff) {
                activeEffectControl = new ucDebuff(debuff);
            }
            else {
                activeEffectControl = new ucHeal((Heal)effect);
            }

            AddEffectControl(activeEffectControl);
            cbEffectType.SelectedItem = effect.GetType().Name;
        }

        private void RemoveExistingEffectControl() {
            if (splitContainer2.Panel1.Controls.Count > 0) {
                splitContainer2.Panel1.Controls.RemoveAt(0);
            }
        }

        private void AddEffectControl(IEffectUserControl control) {
            splitContainer2.Panel1.Controls.Add((Control)control);
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

        private void btnApplyChanges_Click(object sender, EventArgs e) {
            listboxRowToEffect[activeRowKey] = activeEffectControl.GetEffect();
        }
    }
}
