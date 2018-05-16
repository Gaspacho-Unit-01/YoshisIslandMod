using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items
{
	public class HintBlock : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);

			item.useTime = 25;
			item.useAnimation = 25;
            item.useStyle = 4;
			item.shoot = mod.ProjectileType("HintBlock");
			item.buffType = mod.BuffType("HintBlockBuff");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 5));
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HintBlock");
			Tooltip.SetDefault("Hello and welcome to the Yoshi's Island Mod!"
             + "\nI'm Hint Block and I'll be your guide."
             + "\nIt's dangerous to go alone, So take me with you."
             + "\nIf you give a Paint Brush or a Cog to The Guide, he'll tell you what kind of clown copters you can make."
             + "\nI heard if you give the Shady Merchant some fruit, he'll give you something nice in return! I heard it's a Yoshi."
			 + "\nLooking for weapons? Look for The Shady Weapons Dealer on hardmode to get started. He comes if you get a Red Koopa shell.");
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