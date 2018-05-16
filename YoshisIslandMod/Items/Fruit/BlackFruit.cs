using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class BlackFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Black Fruit");
			Tooltip.SetDefault("With one bite, your body slowly starts to fade from existence.");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
			item.height = 30;
			item.useTime = 80;
			item.useAnimation = 80;
	        item.buffType = BuffID.Invisibility;
			item.buffTime = 4000;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 12;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BlackSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}