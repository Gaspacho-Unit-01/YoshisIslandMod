using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Seeds
{
	public class GreenSeeds : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Green Seeds");
			Tooltip.SetDefault("Use these at a Living Loom to make something special!");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.maxStack = 50;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = 500;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Seed, 1);	
			recipe.AddIngredient(ItemID.GreenDye, 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}