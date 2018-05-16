using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class SpikedBallChain : ModItem
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
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.value = Item.sellPrice(0, 0, 60, 0);
			item.knockBack = 8.5F;
			item.damage = 60;
			item.autoReuse = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("SpikedBallChain");
			item.shootSpeed = 20.9F;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiked Ball Chain");
			Tooltip.SetDefault("It's almost too big to use on the ground!");
		}

	}
}