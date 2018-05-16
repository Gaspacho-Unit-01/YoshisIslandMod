using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Bags
{
	public class WaluigiKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Key");
			Tooltip.SetDefault("Used to unlock Waluigi! Press <right> to use it.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.maxStack = 1;
			item.height = 20;
			item.rare = 12;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.value = Item.sellPrice(0, 15, 0, 0);
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("WaluigiHead"), Main.rand.Next(1, 1));
			player.QuickSpawnItem(mod.ItemType("WaluigiBody"), Main.rand.Next(1, 1));
			player.QuickSpawnItem(mod.ItemType("WaluigiLegs"), Main.rand.Next(1, 1));
			player.QuickSpawnItem(mod.ItemType("WaluigiHammer"), Main.rand.Next(1, 1));
		}
	}
}