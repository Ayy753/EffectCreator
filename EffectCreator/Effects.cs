namespace EffectCreator {
    public struct Damage : IDamage{
        public float Potency { get; private set; }
        public DamageType Type { get; private set; }
        public Damage(float potency, DamageType damageType) {
            Potency = potency;
            Type = damageType;
        }
    }

    public struct Buff : IStatusEffect, IStatMod {
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public StatType Type { get; private set; }
        public bool Expires { get; private set; }
        public Buff(float potency, float duration, StatType statType, bool expires) {
            Potency = potency;
            Type = statType;
            Duration = duration;
            Expires = expires;
        }
    }

    public struct DamageOverTime : IStatusEffect, IDamage {
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public DamageType Type { get; private set; }
        public bool Expires { get; private set; }

        public DamageOverTime(float potency, float duration, DamageType damageType, bool expires) {
            Duration = duration;
            Potency = potency;
            Type = damageType;
            Expires = expires;
        }
    }

    public struct Debuff : IStatusEffect, IStatMod {
        public float Duration { get; private set; }
        public float Potency { get; private set; }
        public StatType Type { get; private set; }
        public DamageType ResistType { get; private set; }
        public bool Expires { get; private set; }

        public Debuff(float potency, float duration, StatType statType, DamageType resistType, bool expires) {
            Potency = potency;
            Type = statType;
            Duration = duration;
            ResistType = resistType;
            Expires = expires;
        }
    }

    public struct Heal : IEffect{
        public float Potency { get; }

        public Heal(float potency) {
            Potency = potency;
        }
    }

    public struct StatMod : IStatMod{
        public float Potency { get; }
        public StatType Type { get; private set; }

        public StatMod(float potency, StatType statType) {
            Potency = potency;
            Type = statType;
        }
    }
}
