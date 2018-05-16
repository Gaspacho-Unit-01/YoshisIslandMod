using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class BoomerangBrosBoomerang : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 15;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("BoomerangBrosBoomerang");
			item.shootSpeed = 5f;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = Item.buyPrice(0, 0, 80, 0);
			item.value = Item.sellPrice(0, 0, 40, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boomerang Flower");
			Tooltip.SetDefault("");
		}
	}
}