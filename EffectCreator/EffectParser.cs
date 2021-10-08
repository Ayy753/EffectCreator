using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace EffectCreator {
    public class EffectParser  {
        private const string PARTIAL_PATH = @"\Resources\effects.json";
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
                        throw new IOException($"Error creating effect: EffectType is not defined. This should never happen");
                }
                effects.Add(newEffect);
            }
            return effects.ToArray();
        }

        public static ReadOnlyCollection<EffectGroup> GetEffectGroups() {
            return effectGroups.AsReadOnly();
        }

        private class Root {
            [JsonProperty("effectGroup")]
            public ParsedEffectGroup[] parsedEffectGroups { get; set; }
        }

        private class ParsedEffectGroup {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("target type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TargetType TargetType { get; set; }

            [JsonProperty("particle effect")]
            [JsonConverter(typeof(StringEnumConverter))]
            public ParticleType ParticleName { get; set; }

            [JsonProperty("radius", NullValueHandling = NullValueHandling.Ignore)]
            public float Radius { get; set; } 

            [JsonProperty("effects")]
            public ParsedEffect[] Effects { get; set; }

            [JsonProperty("sound type")]
            public SoundType Sound { get; set; }

            [JsonProperty("cooldown")]
            public float Cooldown { get; set; }
        }

        private class ParsedEffect {
            [JsonProperty("type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public EffectType EffectType { get; set; }

            [JsonProperty("potency")]
            public float Potency { get; set; }

            [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
            public float Duration { get; set; }

            [JsonProperty("damageType", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(StringEnumConverter))]
            public DamageType DamageType { get; set; }

            [JsonProperty("statType", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(StringEnumConverter))]
            public StatType StatType { get; set; }

            [JsonProperty("resistType", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(StringEnumConverter))]
            public DamageType ResistType { get; set; }

            [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
            public bool Expires { get; set; } = true;
        }
    }
}
