using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Diagnostics;
using System.IO;

namespace EffectCreator {
    public class EffectParser  {
        private const string PARTIAL_PATH = @"\Resources\effects.json";
        private ParsedEffectGroup[] parsedEffectGroups;

        public void ParseEffects() {
            string fullPath = Directory.GetCurrentDirectory() + PARTIAL_PATH;

            string jsonText = File.ReadAllText(fullPath);
            parsedEffectGroups = JsonConvert.DeserializeObject<Root>(jsonText).effectGroups;
        }

        private class Root {
            [JsonProperty("effectGroup")]
            public ParsedEffectGroup[] effectGroups { get; set; }
        }

        private class ParsedEffectGroup {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("target type")]
            [JsonConverter(typeof(StringEnumConverter))]
            public TargetType TargetType { get; set; }

            [JsonProperty("particle effect", NullValueHandling = NullValueHandling.Ignore)]
            public string ParticleName { get; set; } 

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
