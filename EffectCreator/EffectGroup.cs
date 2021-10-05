namespace EffectCreator {
    public class EffectGroup {
        public string Name { get; }
        public string Description { get; }
        public float Radius { get; }
        public TargetType Type { get; }
        public string ParticleName { get; }
        public SoundType SoundType { get; }
        public float Cooldown { get; }
        public IEffect[] Effects { get; }

        public EffectGroup(string name, string description, float radius, TargetType type, string particleName, SoundType soundType, float cooldown, IEffect[] effects) {
            Name = name;
            Description = description;
            Radius = radius;
            Type = type;
            ParticleName = particleName;
            SoundType = soundType;
            Cooldown = cooldown;
            Effects = effects;
        }
    }
}
