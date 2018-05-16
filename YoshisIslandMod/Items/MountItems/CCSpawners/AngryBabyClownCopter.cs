using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class AngryBabyClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Annoyed Baby Clown Copter");
			Tooltip.SetDefault("Bwa ha ha ha! Prepare to face my wrath!");
		}

		public override void SetDefaults()
		{
			item.width = 62;
			item.height = 66;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 90, 50, 6);
			item.value = Item.sellPrice(0, 60, 25, 3);
			item.rare = 10;
			item.UseSound = SoundID.Item12;
			item.noMelee = true;
			item.mountType = mod.MountType("AngryBabyClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BabyClownCopter", 1);
			recipe.AddIngredient(ItemID.Paintbrush, 1);
			recipe.AddIngredient(ItemID.GreenPaint, 20);
			recipe.AddIngredient(ItemID.RedPaint, 20);
			recipe.AddIngredient(ItemID.Cog, 15);
			recipe.AddIngredient(ItemID.AdamantiteBar, 100);
			recipe.AddIngredient(ItemID.TitaniumBar, 100);
			recipe.SetResult(this);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}