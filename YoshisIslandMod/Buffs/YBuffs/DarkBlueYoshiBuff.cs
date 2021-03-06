﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs.YBuffs
{
    public class DarkBlueYoshiBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Dark Blue Yoshi");
            Description.SetDefault("Hup!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("DarkBlueYoshi"), player);
            player.buffTime[buffIndex] = 10;
            player.noFallDmg = true;
            player.accFlipper = true;
            player.doubleJumpUnicorn = true;
            player.spikedBoots = 1;
            player.dash = 20;
        }
    }
}
