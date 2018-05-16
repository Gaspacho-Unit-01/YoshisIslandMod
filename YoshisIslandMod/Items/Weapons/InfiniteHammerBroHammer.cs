using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class InfiniteHammerBroHammer : ModItem
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
			item.shoot = mod.ProjectileType("InfiniteHammerBroHammer");
			item.shootSpeed = 10f;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 14;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Hammer Flower");
			Tooltip.SetDefault("So uh.. where do you keep all of these hammers anyway?");
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