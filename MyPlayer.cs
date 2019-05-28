using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;


namespace DeusExThings
{
    public class MyPlayer : ModPlayer
    {
        public float pitchVar = ((float) new Random().NextDouble());

        public override void PreUpdate()
        {
            if(player.justJumped) 
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Movement/MaleJump").WithPitchVariance(pitchVar), player.Center);
            }
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            playSound = false;
            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
        }

        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            playSound = false;
            return true;
        }

        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            int rand = new Random().Next(0, 7);
            if(damage <= 1) 
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/BodyHit").WithPitchVariance(pitchVar), player.Center);
            }
            else if(player.Male)
            {
                switch(rand)
                { 
                    case 0: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainSmall").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 1: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainMedium").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 2: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainLarge").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 3: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleCough").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 4: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleEyePain").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 5: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleGrunt").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 6: 
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleUnconscious").WithPitchVariance(pitchVar), player.Center);
                        break;
                }
            }
            else 
            {
                switch(rand % 3) 
                {
                    case 0: 
                         Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainLarge").WithPitchVariance(pitchVar), player.Center);
                         break;
                    case 1: 
                         Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainMedium").WithPitchVariance(pitchVar), player.Center);
                         break;
                    case 2: 
                         Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainSmall").WithPitchVariance(pitchVar), player.Center);
                         break;
                }
            }
        }

        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            int rand = new Random().Next(0, 2);
            if(player.Male) 
            {
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Kill/MaleDeath").WithPitchVariance(pitchVar), player.Center);
            }
            else 
            {
                switch(rand)
                { 
                    case 0:
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Kill/FemaleDeath").WithPitchVariance(pitchVar), player.Center);
                        break;
                    case 1:
                        Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Kill/FemaleUnconscious").WithPitchVariance(pitchVar), player.Center);
                        break;
                }
            }
            Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Kill/FleshHit" + (rand + 1)).WithPitchVariance(pitchVar), player.Center);
        }
    }
}
