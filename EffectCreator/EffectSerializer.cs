using EffectCreator.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace EffectCreator {
    public static class EffectSerializer {
        private const string PARTIAL_PATH = @"\Resources\effects1.json";

        public static void SaveEffectGroups(List<EffectGroup> effectGroups) {
            string fullPath = Directory.GetCurrentDirectory() + PARTIAL_PATH;

            Root root = new Root();
            List<ParsedEffectGroup> parsedEffectGroups = new List<ParsedEffectGroup>();

            foreach (EffectGroup effectGroup in effectGroups) {
                ParsedEffectGroup serializedEffectGroup = SerializeEffectGroup(effectGroup);
                parsedEffectGroups.Add(serializedEffectGroup);
            }
            root.parsedEffectGroups = parsedEffectGroups.ToArray();

            string contents = JsonConvert.SerializeObject(root, Formatting.Indented);

            StreamWriter writer = new StreamWriter(fullPath, false);
            writer.Write(contents);
            writer.Close();
        }

        private static ParsedEffectGroup SerializeEffectGroup(EffectGroup effectGroup) {
            ParsedEffectGroup serializeEffectGroup = new ParsedEffectGroup();
            ParsedEffect[] serializedEffects = SerializeEffects(effectGroup.Effects);

            serializeEffectGroup.Cooldown = effectGroup.Cooldown;
            serializeEffectGroup.Description = effectGroup.Description;
            serializeEffectGroup.Effects = serializedEffects;
            serializeEffectGroup.Name = effectGroup.Name;
            serializeEffectGroup.ParticleName = effectGroup.ParticleName;
            serializeEffectGroup.Sound = effectGroup.SoundType;
            serializeEffectGroup.TargetType = effectGroup.Type;

            if (serializeEffectGroup.TargetType == TargetType.Area) {
                serializeEffectGroup.Radius = effectGroup.Radius;
            }
            else {
                serializeEffectGroup.Radius = null;
            }

            return serializeEffectGroup;
        }

        private static ParsedEffect[] SerializeEffects(IEffect[] effects) {
            List<ParsedEffect> parsedEffects = new List<ParsedEffect>();

            foreach (IEffect effect in effects) {
                parsedEffects.Add(ConvertEffect(effect));
            }

            return parsedEffects.ToArray();
        }

        private static ParsedEffect ConvertEffect(IEffect effect) {
            ParsedEffect parsedEffect = new ParsedEffect();
            parsedEffect.Name = effect.Name;
            parsedEffect.Potency = effect.Potency;

            //  Compose IEffect properties
            if (effect is IStatusEffect statusEffect) {
                parsedEffect.Expires = statusEffect.Expires;
                
                if (!statusEffect.Expires) {
                    parsedEffect.Duration = null;
                }
                else {
                    parsedEffect.Duration = statusEffect.Duration;
                }
            }
            if (effect is IDamage damage) {
                parsedEffect.DamageType = damage.Type;
            }
            if (effect is IStatMod statmod) {
                parsedEffect.StatType = statmod.StatType;
            }

            //  Set Implementation properties
            if (effect is Buff buff) {
                parsedEffect.EffectType = EffectType.Buff;
                parsedEffect.StatType = buff.StatType;
            }
            else if (effect is Damage) {
                parsedEffect.EffectType = EffectType.Damage;
            }
            else if (effect is DamageOverTime dot) {
                parsedEffect.EffectType = EffectType.DOT;
            }
            else if (effect is StatMod statMod) {
                parsedEffect.EffectType = EffectType.StatMod;
            }
            else if (effect is Debuff debuff) {
                parsedEffect.EffectType = EffectType.Debuff;
                parsedEffect.StatType = debuff.StatType;
                parsedEffect.ResistType = debuff.ResistType;
            }
            else if (effect is Heal heal) {
                parsedEffect.EffectType = EffectType.Heal;
            }

            return parsedEffect;
        }
    }
}
