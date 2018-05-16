using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class ClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Clown Copter");
			Tooltip.SetDefault("A basic Clown Copter made for someone human sized!");
		}

		public override void SetDefaults()
		{
			item.width = 70;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 8, 0, 0);
			item.value = Item.sellPrice(0, 4, 1, 13);
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.noMelee = true;
			item.mountType = mod.MountType("ClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.RedPaint, 5);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.GreenPaint, 30);
			recipe.AddIngredient(ItemID.YellowPaint, 30);
			recipe.AddIngredient(ItemID.IronBar, 150);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}