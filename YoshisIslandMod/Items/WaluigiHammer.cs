using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
{
	public class WaluigiHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Hammer");
			Tooltip.SetDefault("A dark hammer not for the faint of heart.");
		}

		public override void SetDefaults()
		{
			item.damage = 250;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 8;
			item.hammer = 500;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 13;
			item.crit = 3;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/WAAAAH");
			item.autoReuse = false;
			item.melee = true;
		}
	}
}