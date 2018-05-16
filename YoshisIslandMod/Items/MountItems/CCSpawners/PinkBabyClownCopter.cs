using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class PinkBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Baby Clown Copter");
			Tooltip.SetDefault("You can't fight crime if you ain't cute.");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(6, 46, 68, 18);
			item.value = Item.sellPrice(3, 23, 34, 14);
			item.rare = 10;
			item.UseSound = SoundID.Item12;
			item.noMelee = true;
			item.mountType = mod.MountType("PinkBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.PinkPaint, 40);
			recipe.AddIngredient(ItemID.IronBar, 120);
			recipe.AddIngredient(ItemID.OrichalcumBar, 80);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}