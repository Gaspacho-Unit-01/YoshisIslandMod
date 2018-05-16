using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class PinkFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Pink Fruit");
			Tooltip.SetDefault("With one bite, your entire mouth is enveloped with a sweet taste.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 80;
			item.healLife = 10;
			item.buffType = BuffID.Swiftness;
			item.buffTime = 950;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 80;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 5, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PinkSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}