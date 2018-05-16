using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class BlueFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Blue Fruit");
			Tooltip.SetDefault("With one bite, you start to feel something growing on your neck.");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
			item.height = 30;
			item.useTime = 60;
			item.useAnimation = 60;
	        item.buffType = BuffID.Gills;
			item.buffTime = 12000;
			item.consumable = true;
			item.autoReuse = true; 
			item.maxStack = 30;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BlueSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}