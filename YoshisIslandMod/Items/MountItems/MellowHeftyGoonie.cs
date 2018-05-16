using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems
{
	public class MellowHeftyGoonie : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Feather");
			Tooltip.SetDefault("It's back to its senses after that beating and feeding.");
		}

		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = 800;
			item.rare = 10;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
			item.mountType = mod.MountType("MellowHeftyGoonie");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedSeeds", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}