using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class GrayFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Gray Fruit");
			Tooltip.SetDefault("With one bite, your tongue turns gray and you lose all feeling in your body.");
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 80;
			item.buffType = BuffID.Ironskin;
			item.buffTime = 950;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 80;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GraySeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}