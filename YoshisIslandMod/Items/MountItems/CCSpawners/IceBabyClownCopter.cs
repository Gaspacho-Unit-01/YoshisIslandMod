using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class IceBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozen Baby Clown Copter");
			Tooltip.SetDefault("Its frozen engine doesn't let it fly as fast but it can jump high!");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(18, 25, 75, 14);
			item.value = Item.sellPrice(6, 17, 93, 3);
			item.rare = 9;
			item.UseSound = SoundID.Item30;
			item.noMelee = true;
			item.mountType = mod.MountType("IceBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.Cog, 5);
			recipe.AddIngredient(ItemID.CyanPaint, 30);
			recipe.AddIngredient(ItemID.DeepCyanPaint, 30);
			recipe.AddIngredient(ItemID.TitaniumBar, 120);
			recipe.AddIngredient(ItemID.IceBlock, 3000);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}