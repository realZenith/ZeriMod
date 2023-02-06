using R2API;
using System;

namespace ZeriMod.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Zeri
            string prefix = HenryPlugin.DEVELOPER_PREFIX + "_ZERI_";

            string desc = "Henry is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, searching for a new identity.";
            string outroFailure = "..and so he vanished, forever a blank slate.";

            LanguageAPI.Add(prefix + "NAME", "Zeri");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "The Spark of Zaun");
            LanguageAPI.Add(prefix + "LORE", "sample");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Living Battery");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Zeri gains Move Speed whenever she receives a shield. When she damages an enemy shield she absorbs its energy, shielding herself.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Burst Fire");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Zeri's Attacks are treated as Abilities and Burst Fire is treated as an Attack. Moving and casting Burst Fire stores up energy in Zeri's Sparkpack. When fully charged her next Attack will slow and deal bonus damage. Burst Fire shoots a burst of 7 rounds that deal attack damage to the first enemy hit. She will vault and grind over any terrain she touches.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "Ultrashock Laser");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Zeri fires an electric pulse that slows and damages the first enemy hit. If the pulse hits a wall it expands into a long range laser.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Spark Surge");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Zeri dashes a short distance and energizes her next 3 shots of Burst Fire, causing them to pierce through enemies. She will vault and grind over any terrain she touches.");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "Lightning Crash");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Zeri discharges a nova of electricity and overcharges herself, gaining increased damage and stacking Move Speed that refreshes and gets stronger every time she hits an enemy champion. While overcharged, Burst fire becomes a faster triple shot that chains lightning between enemies.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Henry: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Henry, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Henry: Mastery");
            #endregion
            #endregion
        }
    }
}