using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
{
	public class WingedBlocks : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Winged Blocks");
			Tooltip.SetDefault("");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(2, 3));
			ItemID.Sets.ItemIconPulse[item.type] = false;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 1;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.value = Item.sellPrice(0, 8, 1, 13);
			item.UseSound = SoundID.Item20;
			item.noMelee = true;
			item.mountType = mod.MountType("WingedBlocks");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 500);
			recipe.AddIngredient(ItemID.AngelWings, 1);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}