using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class BrownFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Brown Fruit");
			Tooltip.SetDefault("With one bite, you feel all of your taste buds dancing with joy.");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
			item.height = 30;
			item.useTime = 80;
			item.healLife = 30;
			item.buffType = BuffID.Sunflower;
			item.buffTime = 300;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 80;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BrownSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}