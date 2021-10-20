using EffectCreator.IO;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EffectCreator {
    public static class EffectParser  {
        private static List<EffectGroup> effectGroups = new List<EffectGroup>();

        private static void LoadEffectGroups() {
            effectGroups.Clear();

            try {
                Root jsonRoot = IOHandler.ParseEffects();
                ParsedEffectGroup[] parsedEffectGroups = jsonRoot.parsedEffectGroups;
                ConvertEffectGroups(parsedEffectGroups);
            }
            catch (FileNotFoundException e) {
                MessageBox.Show(e.Message + "An empty file will be created", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                effectGroups.Add(new EffectGroup("New Effect Group", "", 1, TargetType.Area, ParticleType.Blood, SoundType.arrowFire, 1, new IEffect[] { }));
            }
        }

        private static void ConvertEffectGroups(ParsedEffectGroup[] parsedEffectGroups) {
            foreach (ParsedEffectGroup parsed in parsedEffectGroups) {
                IEffect[] effects = ConvertEffects(parsed.Effects);

                float radius = parsed.TargetType == TargetType.Area ? (float)parsed.Radius : 1;
                effectGroups.Add(new EffectGroup(parsed.Name, parsed.Description, radius, parsed.TargetType, parsed.ParticleName, parsed.Sound, parsed.Cooldown, effects));
            }
        }

        private static IEffect[] ConvertEffects(ParsedEffect[] parsedEffects) {
            List<IEffect> effects = new List<IEffect>();
            
            IEffect newEffect;
            foreach (ParsedEffect parsed in parsedEffects) {

                float duration = parsed.Duration != null ? (float)(parsed.Duration) : 1;

                switch (parsed.EffectType) {
                    case EffectType.Buff:
                        newEffect = new Buff(parsed.Name, parsed.Potency, duration, (StatType)parsed.StatType, (bool)parsed.Expires);
                        break;
                    case EffectType.Damage:
                        newEffect = new Damage(parsed.Name, parsed.Potency, (DamageType)parsed.DamageType);
                        break;
                    case EffectType.DOT:
                        newEffect = new DamageOverTime(parsed.Name, parsed.Potency, duration, (DamageType)parsed.DamageType, (bool)parsed.Expires);
                        break;
                    case EffectType.StatMod:
                        newEffect = new StatMod(parsed.Name, parsed.Potency, (StatType)parsed.StatType);
                        break;
                    case EffectType.Debuff:
                        newEffect = new Debuff(parsed.Name, parsed.Potency, duration, (StatType)parsed.StatType, (DamageType)parsed.ResistType, (bool)parsed.Expires);
                        break;
                    case EffectType.Heal:
                        newEffect = new Heal(parsed.Name, parsed.Potency);
                        break;
                    default:
                        throw new IOException($"Error creating effect. The '{parsed.EffectType}' type is not currently supported");
                }
                effects.Add(newEffect);
            }
            return effects.ToArray();
        }

        public static List<EffectGroup> GetEffectGroups() {
            LoadEffectGroups();
            return effectGroups;
        }
    }
}
