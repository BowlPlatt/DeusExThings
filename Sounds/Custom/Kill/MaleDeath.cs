using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;
using System;

namespace DeusExThings.Sounds.Custom.Kill
{
    class MaleDeath : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            var x = new Random();
            var y = x.Next(-2, 0);

            soundInstance = sound.CreateInstance();
            soundInstance.Volume = volume;
            soundInstance.Pan = pan;
            soundInstance.Pitch = y * .5f;
            return soundInstance;
        }
    }
}
