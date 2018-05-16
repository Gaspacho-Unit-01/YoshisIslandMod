using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems
{
	public class HeftyGoonie : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Feather");
			Tooltip.SetDefault("Your weight and the seeds ain't helpin', buddy.");
		}

		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = 0;
			item.rare = 0;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
			item.mountType = mod.MountType("HeftyGoonie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 1);
			recipe.AddIngredient(ItemID.Worm, 3);
			recipe.AddIngredient(ItemID.GrassSeeds, 80);
			recipe.AddIngredient(ItemID.DaybloomSeeds, 100);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}