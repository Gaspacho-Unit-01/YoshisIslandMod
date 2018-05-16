using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class InfiniteBoomerangBrosBoomerang : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 120;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.noUseGraphic = true;
			item.maxStack = 1;
			item.consumable = false;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("InfiniteBoomerangBrosBoomerang");
			item.shootSpeed = 9f;
			item.useStyle = 2;
			item.knockBack = 1;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Boomerang Flower");
			Tooltip.SetDefault("");
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PowerStar", 1);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}