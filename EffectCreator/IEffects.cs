namespace EffectCreator {
    public interface IEffect {
        float Potency { get; }
    }

    public interface IStatusEffect : IEffect {
        bool Expires { get; }
        float Duration { get; }
    }

    public interface IDamage : IEffect {
        DamageType Type { get; }
    }

    public interface IStatMod : IEffect {
        StatType Type { get; }
    }
}
