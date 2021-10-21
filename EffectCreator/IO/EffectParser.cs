using EffectCreator.IO;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EffectCreator {
    public static class EffectParser  {

        public static List<EffectGroup> ParseEffectGroups(Root jsonRoot) {
            return ConvertEffectGroups(jsonRoot.parsedEffectGroups);
        }

        private static List<EffectGroup> ConvertEffectGroups(ParsedEffectGroup[] parsedEffectGroups) {
            List<EffectGroup> effectGroups = new List<EffectGroup>();
            
            foreach (ParsedEffectGroup parsed in parsedEffectGroups) {
                IEffect[] effects = ConvertEffects(parsed.Effects);

                float radius = parsed.TargetType == TargetType.Area ? (float)parsed.Radius : 1;
                effectGroups.Add(new EffectGroup(parsed.Name, parsed.Description, radius, parsed.TargetType, parsed.ParticleName, parsed.Sound, parsed.Cooldown, effects));
            }
            return effectGroups;
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
    }
}
