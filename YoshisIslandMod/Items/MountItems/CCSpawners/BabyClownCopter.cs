using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class BabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baby Clown Copter");
			Tooltip.SetDefault("Bowsers first clown copter!");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = Item.buyPrice(0, 34, 0, 0);
			item.value = Item.sellPrice(0, 14, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item12;
			item.noMelee = true;
			item.mountType = mod.MountType("BabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.GreenPaint, 40);
			recipe.AddIngredient(ItemID.RedPaint, 40);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.IronBar, 300);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}