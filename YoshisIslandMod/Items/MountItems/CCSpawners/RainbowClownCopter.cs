using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.CCSpawners
{
	public class RainbowClownCopter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Ultimate Rainbow Baby Clown Copter");
			Tooltip.SetDefault("The ultimate fusion of every baby clown copter!");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 10));
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = false;
		}

		public override void SetDefaults()
		{
			item.width = 21;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 1;
			item.useStyle = 4;
			item.value = Item.buyPrice(500, 0, 0, 0);
			item.value = Item.sellPrice(200, 22, 47, 13);
			item.rare = 12;
			item.UseSound = SoundID.Item68;
			item.noMelee = true;
			item.mountType = mod.MountType("RainbowClownCopter");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PaintRoller, 1);
			recipe.AddIngredient(ItemID.Cog, 50);
			recipe.AddIngredient(null, "BabyClownCopter", 1);
			recipe.AddIngredient(null, "AngryBabyClownCopter", 1);
			recipe.AddIngredient(null, "GreenBabyClownCopter", 1);
			recipe.AddIngredient(null, "IceBabyClownCopter", 1);
			recipe.AddIngredient(null, "PurpleBabyClownCopter", 1);
			recipe.AddIngredient(null, "YellowBabyClownCopter", 1);
			recipe.AddIngredient(null, "PowerStar", 1);
            			
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}