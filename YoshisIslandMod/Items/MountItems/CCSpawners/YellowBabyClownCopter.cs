using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class YellowBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Baby Clown Copter");
			Tooltip.SetDefault("Show off your wealth with this solid gold clown copter!");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(10, 43, 68, 2);
			item.value = Item.sellPrice(6, 22, 47, 13);
			item.rare = 20;
			item.UseSound = SoundID.Item24;
			item.noMelee = true;
			item.mountType = mod.MountType("YellowBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.YellowPaint, 30);
			recipe.AddIngredient(ItemID.DeepYellowPaint, 40);
			recipe.AddIngredient(ItemID.GoldBar, 1000);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}