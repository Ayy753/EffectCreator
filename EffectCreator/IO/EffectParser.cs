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
                effectGroups.Add(new EffectGroup(parsed.Name, parsed.Description, parsed.Radius, parsed.TargetType, parsed.ParticleName, parsed.Sound, parsed.Cooldown, effects));
            }
        }

        private static IEffect[] ConvertEffects(ParsedEffect[] parsedEffects) {
            List<IEffect> effects = new List<IEffect>();
            
            IEffect newEffect;
            foreach (ParsedEffect parsed in parsedEffects) {
                switch (parsed.EffectType) {
                    case EffectType.Buff:
                        newEffect = new Buff(parsed.Potency, parsed.Duration, parsed.StatType, parsed.Expires);
                        break;
                    case EffectType.Damage:
                        newEffect = new Damage(parsed.Potency, parsed.DamageType);
                        break;
                    case EffectType.DOT:
                        newEffect = new DamageOverTime(parsed.Potency, parsed.Duration, parsed.DamageType, parsed.Expires);
                        break;
                    case EffectType.StatMod:
                        newEffect = new StatMod(parsed.Potency, parsed.StatType);
                        break;
                    case EffectType.Debuff:
                        newEffect = new Debuff(parsed.Potency, parsed.Duration, parsed.StatType, parsed.ResistType, parsed.Expires);
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
