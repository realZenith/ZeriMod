using EntityStates;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace ZeriMod.SkillStates 
{ 
    internal class LightningCrash : GenericProjectileBaseState
    {

        public static float BaseDuration = 0.65f;
        //delay here for example and to match animation
        //ordinarily I recommend not having a delay before projectiles. makes the move feel sluggish
        public static float BaseDelayDuration = 0.35f * BaseDuration;

        public static float DamageCoefficient = 1.6f;

        private string activationSoundString;

        public override void OnEnter()
        {
            base.projectilePrefab = Modules.Projectiles.bombPrefab;
            //base.effectPrefab = Modules.Assets.SomeMuzzleEffect;
            //targetmuzzle = "muzzleThrow"

            base.attackSoundString = "HenryBombThrow";

            base.baseDuration = BaseDuration;
            base.baseDelayBeforeFiringProjectile = BaseDelayDuration;

            base.damageCoefficient = DamageCoefficient;
            //proc coefficient is set on the components of the projectile prefab
            base.force = 80f;

            //base.projectilePitchBonus = 0;
            //base.minSpread = 0;
            //base.maxSpread = 0;

            base.recoilAmplitude = 0.1f;
            base.bloom = 10;

            System.Random random = new System.Random();
            int randomVoiceQ = random.Next(1, 3);
            switch (randomVoiceQ)
            {
                case 1:
                    activationSoundString = "Play_iamlightning";
                    break;
                case 2:
                    activationSoundString = "Play_iamlightning2";
                    break;
                case 3:
                    activationSoundString = "Play_lightningfresh";
                    break;
            }


            Util.PlaySound(activationSoundString, base.gameObject);
            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }

        public override void PlayAnimation(float duration)
        {

            if (base.GetModelAnimator())
            {
                base.PlayAnimation("FullBody, Override", "Special_Attack", "ThrowBomb.playbackRate", this.duration);
            }
        }
    }
}
