using EffectCreator.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace EffectCreator {
    public class EffectParser  {
        private const string PARTIAL_PATH = @"\Resources\effects1.json";
        private static List<EffectGroup> effectGroups;

        static EffectParser() {
            ParseEffects();
        }

        private static void ParseEffects() {
            string fullPath = Directory.GetCurrentDirectory() + PARTIAL_PATH;

            string jsonText = File.ReadAllText(fullPath);
            ParsedEffectGroup[] parsedEffectGroups = JsonConvert.DeserializeObject<Root>(jsonText).parsedEffectGroups;
            ConvertEffectGroups(parsedEffectGroups);
        }

        private static void ConvertEffectGroups(ParsedEffectGroup[] parsedEffectGroups) {
            effectGroups = new List<EffectGroup>();
            
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
                        newEffect = new Buff(parsed.Potency, duration, (StatType)parsed.StatType, (bool)parsed.Expires);
                        break;
                    case EffectType.Damage:
                        newEffect = new Damage(parsed.Potency, (DamageType)parsed.DamageType);
                        break;
                    case EffectType.DOT:
                        newEffect = new DamageOverTime(parsed.Potency, duration, (DamageType)parsed.DamageType, (bool)parsed.Expires);
                        break;
                    case EffectType.StatMod:
                        newEffect = new StatMod(parsed.Potency, (StatType)parsed.StatType);
                        break;
                    case EffectType.Debuff:
                        newEffect = new Debuff(parsed.Potency, duration, (StatType)parsed.StatType, (DamageType)parsed.ResistType, (bool)parsed.Expires);
                        break;
                    case EffectType.Heal:
                        newEffect = new Heal(parsed.Potency);
                        break;
                    default:
                        throw new IOException($"Error creating effect. The '{parsed.EffectType}' type is not currently supported");
                }
                effects.Add(newEffect);
            }
            return effects.ToArray();
        }

        public static List<EffectGroup> GetEffectGroups() {
            return effectGroups;
        }
    }
}
