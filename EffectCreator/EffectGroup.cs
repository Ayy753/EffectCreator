using System;

namespace EffectCreator {
    public class EffectGroup : ICloneable {
        public string Name { get; }
        public string Description { get; }
        public float Radius { get; }
        public TargetType Type { get; }
        public ParticleType ParticleName { get; }
        public SoundType SoundType { get; }
        public float Cooldown { get; }
        public IEffect[] Effects { get; }

        public EffectGroup(string name, string description, float radius, TargetType type, ParticleType particleName, SoundType soundType, float cooldown, IEffect[] effects) {
            Name = name;
            Description = description;
            Radius = radius;
            Type = type;
            ParticleName = particleName;
            SoundType = soundType;
            Cooldown = cooldown;
            Effects = effects;
        }

        public object Clone() {
            IEffect[] effects = new IEffect[Effects.Length];
            string newName = Name + " - Copy";

            for (int i = 0; i < Effects.Length; i++) {
                effects[i] = (IEffect)Effects[i].Clone();
            }

            EffectGroup effectGroup = new EffectGroup(newName, Description, Radius, Type, ParticleName, SoundType, Cooldown, effects);
            return effectGroup;
        }
    }
}
