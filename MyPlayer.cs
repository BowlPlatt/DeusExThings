using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;


namespace DeusExThings
{
    public class MyPlayer : ModPlayer
    {
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
            var x = new Random();
            var y = x.Next(1, 12);

            if (y == 1)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/BodyHit"));
            }
            if (y == 2)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainLarge"));
            }
            if (y == 3)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainMedium"));
            }
            if (y == 4)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/FemalePainSmall"));
            }
            if (y == 5)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleCough"));
            }
            if (y == 6)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleEyePain"));
            }
            if (y == 7)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleGrunt"));
            }
            if (y == 8)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainLarge"));
            }
            if (y == 9)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainMedium"));
            }
            if (y == 10)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MalePainSmall"));
            }
            if (y == 11)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1 , -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Hit/MaleUnconscious"));
            }
        }
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            var x = new Random();
            var y = x.Next(1, 4);
            if (y == 1) 
            {
                Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Kill/MaleDeath"));
            }
            if (y == 2)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Kill/FemaleDeath"));
            }
            if (y == 3)
            {
                Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/Kill/FemaleUnconscious"));
            }
        }
    }
}
