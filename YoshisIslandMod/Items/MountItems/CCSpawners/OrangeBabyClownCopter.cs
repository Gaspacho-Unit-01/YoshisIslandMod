using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class OrangeBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Baby Clown Copter");
			Tooltip.SetDefault("It's good at running and jumping. Not so much at flying.");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = Item.buyPrice(10, 43, 75, 0);
			item.value = Item.sellPrice(5, 27, 64, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item12;
			item.noMelee = true;
			item.mountType = mod.MountType("OrangeBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.MagicWaterDropper, 1);
			recipe.AddIngredient(ItemID.Cog, 10);
			recipe.AddIngredient(ItemID.OrangePaint, 40);
			recipe.AddIngredient(ItemID.TitaniumBar, 80);
            recipe.AddIngredient(ItemID.SandBlock, 3000);			
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}