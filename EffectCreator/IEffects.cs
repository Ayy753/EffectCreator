using System;

namespace EffectCreator {
    public interface IEffect : ICloneable {
        float Potency { get; }
        string Name { get; }
    }

    public interface IStatusEffect : IEffect {
        bool Expires { get; }
        float Duration { get; }
    }

    public interface IDamage : IEffect {
        DamageType Type { get; }
    }

    public interface IStatMod : IEffect {
        StatType StatType { get; }
    }
}
