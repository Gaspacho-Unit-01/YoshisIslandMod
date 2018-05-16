using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Bags
{
	public class SackoSeed : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sack o' Seeds");
			Tooltip.SetDefault("<right> for seeds!");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.maxStack = 300;
			item.height = 20;
			item.rare = 1;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ItemID.Seed, 3);
			player.QuickSpawnItem(ItemID.GrassSeeds, 3);
			player.QuickSpawnItem(ItemID.DaybloomSeeds, 4);
		}
	}
}