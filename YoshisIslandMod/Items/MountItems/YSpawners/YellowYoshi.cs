using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MountItems.YSpawners
{
	public class YellowYoshi : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Yoshi Egg");
			Tooltip.SetDefault("A trusty friend till the very end!");
			// ticksperframe, frameCount
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 6));
			ItemID.Sets.AnimatesAsSoul[item.type] = false;
			ItemID.Sets.ItemIconPulse[item.type] = false;
			ItemID.Sets.ItemNoGravity[item.type] = false;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 1;
			item.useStyle = 1;
			item.value = Item.sellPrice(0, 0, 30, 0);
			item.rare = 12;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/YSound1");
			item.noMelee = true;
			item.mountType = mod.MountType("YellowYoshi");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "YellowFruit", 10);
            recipe.AddTile(TileID.LivingLoom);				
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}