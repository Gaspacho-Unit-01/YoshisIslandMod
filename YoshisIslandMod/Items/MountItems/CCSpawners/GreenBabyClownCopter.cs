using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class GreenBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forest Baby Clown Copter");
			Tooltip.SetDefault("It's good at jumping over giant hills. Not so much at flying.");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 93, 80, 26);
			item.value = Item.sellPrice(0, 60, 40, 23);
			item.rare = 2;
			item.UseSound = SoundID.Item12;
			item.noMelee = true;
			item.mountType = mod.MountType("GreenBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.Cog, 10);
			recipe.AddIngredient(ItemID.GreenPaint, 40);
			recipe.AddIngredient(ItemID.IronBar, 120);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 80);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}