using EffectCreator.EffectControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using static EffectCreator.RowValidator;

namespace EffectCreator {
    public partial class ucEffectGroup : UserControl {
        private Dictionary<string, IEffect> listboxRowToEffect = new Dictionary<string, IEffect>();
        private IEffectUserControl activeEffectControl;
        private frmMain frmMain;
        private string egName;

        internal void SetParent(frmMain frmMain) {
            this.frmMain = frmMain;
        }

        private string activeRowKey;
        public bool IsModified { get; set; }

        public ucEffectGroup() {
            InitializeComponent();

            cbSoundType.DataSource = Enum.GetValues(typeof(SoundType));
            cbParticleType.DataSource = Enum.GetValues(typeof(ParticleType));
        }

        public void LoadEffectGroup(EffectGroup effectGroup) {
            egName = effectGroup.Name;
            InitializeEffectListbox(effectGroup);

            tbName.Text = effectGroup.Name;
            tbDescription.Text = effectGroup.Description;
            cbSoundType.SelectedItem = effectGroup.SoundType;
            cbParticleType.SelectedItem = effectGroup.ParticleName;
            numCooldown.Value = (decimal)effectGroup.Cooldown;
            radTargetGroup.Checked = effectGroup.Type == TargetType.Area;
            radTargetIndividual.Checked = effectGroup.Type == TargetType.Individual;
            numRadius.Value = (decimal)effectGroup.Radius;
        }

        public List<string> RowKeys() {
            return listboxRowToEffect.Keys.ToList();
        }

        private void InitializeEffectListbox(EffectGroup effectGroup) {
            lbEffects.Items.Clear();
            listboxRowToEffect.Clear();

            foreach (IEffect effect in effectGroup.Effects) {
                string rowKey = effect.Name;
                listboxRowToEffect.Add(rowKey, effect);
                lbEffects.Items.Add(rowKey);
            }

            if (lbEffects.Items.Count > 0) {
                lbEffects.SelectedIndex = 0;
            }
            else{
                RemoveExistingEffectControl();
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

        internal void UpdateRowKey(string effectName, string newName) {
            listboxRowToEffect.Remove(activeRowKey);
            listboxRowToEffect.Add(newName, activeEffectControl.GetEffect());

            int index = lbEffects.Items.IndexOf(activeRowKey);
            lbEffects.Items.RemoveAt(index);
            lbEffects.Items.Insert(index, newName);
            lbEffects.SelectedIndex = index;
            activeRowKey = newName;
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
                activeEffectControl = new ucBuff(buff, this);
            }
            else if (effect is StatMod statMod) {
                activeEffectControl = new ucStatMod(statMod);
            }
            else if (effect is Debuff debuff) {
                activeEffectControl = new ucDebuff(debuff);
            }
            else if(effect is Heal heal) {
                activeEffectControl = new ucHeal(heal);
            }
            else {
                throw new ArgumentException($"Error opening effect: Effect type '{effect.GetType()}' is not currently supported.");
            }

            AddEffectControl(activeEffectControl);
            activeEffectControl.EffectModified += ActiveEffectControl_EffectModified;
        }

        private void ActiveEffectControl_EffectModified(object sender, EventArgs e) {
            IsModified = true;
            UpdateEffect();
        }

        private void UpdateEffect() {
            string rowKey = lbEffects.SelectedItem.ToString();
            listboxRowToEffect[rowKey] = activeEffectControl.GetEffect();
        }

        private void RemoveExistingEffectControl() {
            if (splitContainer1.Panel2.Controls.Count > 0) {
                splitContainer1.Panel2.Controls.RemoveAt(0);
                activeEffectControl.EffectModified -= ActiveEffectControl_EffectModified;
                activeRowKey = string.Empty;
                activeEffectControl = null;
            }
        }

        private void AddEffectControl(IEffectUserControl control) {
            splitContainer1.Panel2.Controls.Add((Control)control);
        }

        private void btnRemoveEffect_Click(object sender, EventArgs e) {
            int selectedRowIndex = lbEffects.SelectedIndex;
            string rowKey = lbEffects.SelectedItem.ToString();
            listboxRowToEffect.Remove(rowKey);
            lbEffects.Items.RemoveAt(selectedRowIndex);

            if (selectedRowIndex > 0) {
                lbEffects.SelectedIndex = selectedRowIndex - 1;
            }
            else if (selectedRowIndex == 0 && lbEffects.Items.Count >= 1) {
                lbEffects.SelectedIndex = 0;
            }
            else if (lbEffects.Items.Count == 0) {
                RemoveExistingEffectControl();
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

        private void radTargetGroup_CheckedChanged(object sender, EventArgs e) {
            if (radTargetGroup.Checked) {
                lblRadius.Visible = true;
                numRadius.Visible = true;
            }
            else {
                lblRadius.Visible = false;
                numRadius.Visible = false;
            }
        }

        private void btnCreateNewEfect_Click(object sender, EventArgs e) {
            using (frmCreateNewEffect frmCreateNewEffect = new frmCreateNewEffect(this)) {
                if (frmCreateNewEffect.ShowDialog() == DialogResult.OK) {
                    string effectName = frmCreateNewEffect.EffectName;
                    CreateNewEffect(effectName, frmCreateNewEffect.EffectType);

                    Debug.WriteLine("Created effect in ucEffectGroup");
                }
            }
        }

        private void CreateNewEffect(string uniqueEffectName, EffectType effectType) {
            IEffect effect;
            switch (effectType) {
                case EffectType.Buff:
                    effect = new Buff(uniqueEffectName, 1, 1, StatType.Armor, true);
                    break;
                case EffectType.Damage:
                    effect = new Damage(uniqueEffectName, 1, DamageType.Cold);
                    break;
                case EffectType.DOT:
                    effect = new DamageOverTime(uniqueEffectName, 1, 1, DamageType.Cold, true);
                    break;
                case EffectType.StatMod:
                    effect = new StatMod(uniqueEffectName, 1, StatType.Armor);
                    break;
                case EffectType.Debuff:
                    effect = new Debuff(uniqueEffectName, 1, 1, StatType.Armor, DamageType.Cold, true);
                    break;
                case EffectType.Heal:
                    effect = new Heal(uniqueEffectName, 1);
                    break;
                default:
                    throw new ArgumentException($"Error: Effect type '{effectType}' not supported.");
            }

            listboxRowToEffect.Add(uniqueEffectName, effect);
            lbEffects.Items.Add(uniqueEffectName);
            lbEffects.SelectedIndex = lbEffects.Items.Count - 1;
        }

        private void EffectGroupModified(object sender, EventArgs e) {
            IsModified = true;
        }

        private void tbName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            string newName = tbName.Text;

            if (egName != newName) {
                ValidationError validationError = ValidateName(newName, frmMain.RowKeys());

                if (validationError != ValidationError.None) {
                    DisplayNameErrorMessage(validationError, newName);
                    tbName.Text = egName;
                }
                else {
                    frmMain.UpdateRowKey(egName, newName);
                    egName = newName;
                }
            }
        }
    }
}
