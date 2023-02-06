using ZeriMod.SkillStates;
using ZeriMod.SkillStates.BaseStates;
using System.Collections.Generic;
using System;

namespace ZeriMod.Modules
{
    public static class States
    {
        internal static void RegisterStates()
        {
            Content.AddEntityState(typeof(BaseMeleeAttack));
            Content.AddEntityState(typeof(SlashCombo));

            Content.AddEntityState(typeof(Shoot));

            Content.AddEntityState(typeof(Roll));

            Content.AddEntityState(typeof(ThrowBomb));


            Content.AddEntityState(typeof(BurstFire));
            Content.AddEntityState(typeof(LightningCrash));

            Content.AddEntityState(typeof(SparkSurge));

            Content.AddEntityState(typeof(UltrashockLaser));

        }
    }
}