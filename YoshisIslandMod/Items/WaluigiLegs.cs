using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace YoshisIslandMod.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class WaluigiLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Leggings");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 13;
			item.defense = 15;
			item.maxStack = 1;
		}
		
		public override bool DrawLegs()
		{
			return false;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Confused] = true;
			player.statManaMax2 += 0;
			player.maxMinions++;
			
		}
	}
}