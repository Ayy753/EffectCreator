namespace EffectCreator {
    public enum DamageType {
        Physical, Cold, Fire, Poison, Lightning
    }

    public enum StatType {
        Armor, ColdResist, FireResist, PoisonResist, LightningResist, Health, Speed
    }

    public enum SoundType {
        arrowHitFlesh,
        arrowHitDirt,
        arrowHitStone,
        arrowFire,
        bluntHit,
        explosionTiny,
        arrowRelease,
        gainGold,
        buff,
        gunFire
    }
    
    public enum TargetType {
        Individual, Area
    }

    public enum EffectType {
        Buff, Damage, DOT, StatMod, Debuff, Heal
    }

    public enum ParticleType {
        Explosion, Buff, Blood, Heal
    }
}
