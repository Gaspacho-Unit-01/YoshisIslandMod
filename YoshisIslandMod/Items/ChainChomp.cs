using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items
{
	public class ChainChomp : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.useTime = 25;
			item.useAnimation = 25;
            item.useStyle = 4;
			item.shoot = mod.ProjectileType("ChainChomp");
			item.buffType = mod.BuffType("ChainChompBuff");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 4));
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unchained Chomp");
			Tooltip.SetDefault("Summons a floating Unchained Chomp."
			 + "\nSneaky Sneaky! You took a peek at the first pet for the mod!");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}