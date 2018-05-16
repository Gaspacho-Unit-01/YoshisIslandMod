using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class RedSpikedBallChain : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.rare = 11;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 30;
			item.useTime = 30;
			item.value = Item.buyPrice(0, 12, 85, 0);
			item.value = Item.sellPrice(0, 6, 34, 0);
			item.knockBack = 3.5F;
			item.damage = 120;
			item.autoReuse = true;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("RedSpikedBallChain");
			item.shootSpeed = 18.9F;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Spiked Ball Chain");
			Tooltip.SetDefault("It's almost too big to swing on the ground.");
		}

	}
}