using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace YoshisIslandMod.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class WaluigiHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Cap");
			Tooltip.SetDefault("Waluigi time!");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.rare = 13;
			item.vanity = true;
			item.defense = 15;
			item.maxStack = 1;
			item.value = Item.buyPrice(0, 15, 0, 0);
	    }

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("WaluigiBody") && legs.type == mod.ItemType("WaluigiLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increases Movement speed and increases melee damage by 3%.";
			player.moveSpeed += 0.15f;
			player.meleeDamage += 0.3f;
			player.goldRing = true;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Suffocation] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[BuffID.Blackout] = true;
			player.buffImmune[BuffID.Obstructed] = true;
			player.buffImmune[BuffID.Sunflower] = true;
			player.statManaMax2 += 0;
			player.maxMinions += 1;
		}
		
		public override bool DrawHead()
		{
			return false;
		}
	}
}