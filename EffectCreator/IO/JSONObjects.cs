using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EffectCreator.IO {
    public class Root {
        [JsonProperty("effectGroup")]
        public ParsedEffectGroup[] parsedEffectGroups { get; set; }
    }

    public class ParsedEffectGroup {
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
        public float? Radius { get; set; }

        [JsonProperty("effects")]
        public ParsedEffect[] Effects { get; set; }

        [JsonProperty("sound type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SoundType Sound { get; set; }

        [JsonProperty("cooldown")]
        public float Cooldown { get; set; }
    }

    public class ParsedEffect {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EffectType EffectType { get; set; }

        [JsonProperty("potency")]
        public float Potency { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        [JsonProperty("damageType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DamageType? DamageType { get; set; }

        [JsonProperty("statType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public StatType? StatType { get; set; }

        [JsonProperty("resistType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public DamageType? ResistType { get; set; }

        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expires { get; set; } = true;
    }
}
