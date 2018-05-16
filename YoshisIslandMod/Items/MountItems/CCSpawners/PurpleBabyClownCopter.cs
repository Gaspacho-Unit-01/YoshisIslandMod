using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class PurpleBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Baby Clown Copter");
			Tooltip.SetDefault("Smells like poison and corruption but it has a great engine!");
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
			item.rare = 11;
			item.UseSound = SoundID.Item18;
			item.noMelee = true;
			item.mountType = mod.MountType("PurpleBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.Cog, 20);
			recipe.AddIngredient(ItemID.PurplePaint, 30);
			recipe.AddIngredient(ItemID.DeepPurplePaint, 30);
			recipe.AddIngredient(ItemID.RedPaint, 10);
			recipe.AddIngredient(ItemID.TitaniumBar, 120);
			recipe.AddIngredient(ItemID.DemoniteBar, 200);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}