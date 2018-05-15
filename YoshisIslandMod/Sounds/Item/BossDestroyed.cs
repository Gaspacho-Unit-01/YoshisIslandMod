using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Sounds.Item
{
    public class BossDestroyed : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            soundInstance = sound.CreateInstance();
            soundInstance.Volume = volume * .6f;
            soundInstance.Pan = pan;
            soundInstance.Pitch = 0f;
            return soundInstance;
        }
    }
}