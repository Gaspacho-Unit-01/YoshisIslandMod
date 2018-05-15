using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs
{
    public class WingedBlocks : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Winged Blocks");
            Description.SetDefault("");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("WingedBlocks"), player);
            player.buffTime[buffIndex] = 10;
            player.noFallDmg = true;
        }
    }
}
