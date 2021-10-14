namespace EffectCreator {
    public struct Damage : IDamage{
        public string Name { get; private set; }
        public float Potency { get; private set; }
        public DamageType Type { get; private set; }
        public Damage(string name, float potency, DamageType damageType) {
            Name = name;
            Potency = potency;
            Type = damageType;
        }
    }

    public struct Buff : IStatusEffect, IStatMod {
        public string Name { get; private set; }
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public StatType StatType { get; private set; }
        public bool Expires { get; private set; }
        public Buff(string name, float potency, float duration, StatType statType, bool expires) {
            Name = name;
            Potency = potency;
            StatType = statType;
            Duration = duration;
            Expires = expires;
        }
    }

    public struct DamageOverTime : IStatusEffect, IDamage {
        public string Name { get; private set; }
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public DamageType Type { get; private set; }
        public bool Expires { get; private set; }

        public DamageOverTime(string name, float potency, float duration, DamageType damageType, bool expires) {
            Name = name;
            Duration = duration;
            Potency = potency;
            Type = damageType;
            Expires = expires;
        }
    }

    public struct Debuff : IStatusEffect, IStatMod {
        public string Name { get; private set; }
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public StatType StatType { get; private set; }
        public DamageType ResistType { get; private set; }
        public bool Expires { get; private set; }

        public Debuff(string name, float potency, float duration, StatType statType, DamageType resistType, bool expires) {
            Name = name;
            Potency = potency;
            StatType = statType;
            Duration = duration;
            ResistType = resistType;
            Expires = expires;
        }
    }

    public struct Heal : IEffect{
        public string Name { get; private set; }
        public float Potency { get; }

        public Heal(string name, float potency) {
            Name = name;
            Potency = potency;
        }
    }

    public struct StatMod : IStatMod{
        public string Name { get; private set; }
        public float Potency { get; }
        public StatType StatType { get; private set; }

        public StatMod(string name, float potency, StatType statType) {
            Name = name;
            Potency = potency;
            StatType = statType;
        }
    }
}
