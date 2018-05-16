using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
    {
	[AutoloadEquip(EquipType.Body)]
	public class WaluigiBody : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Overalls");
			Tooltip.SetDefault("");
		}

		public override bool DrawBody()
		{
			return false;
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 13;
			item.defense = 45;
			item.maxStack = 1;
		}
	}
}