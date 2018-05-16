using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items
{
	public class Vanilliyan : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.useTime = 25;
			item.useAnimation = 25;
            item.useStyle = 4;
			item.useAnimation = 1;
			item.shoot = mod.ProjectileType("Vanilliyan");
			item.buffType = mod.BuffType("VanilliyanBuff");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Cream Cone");
			Tooltip.SetDefault("Summons the legendary Vanilliyan to go on adventures with you!");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
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