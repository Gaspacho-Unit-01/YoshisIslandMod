using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items.Weapons
{
	public class ChainChompChomper : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 24;
			item.height = 28;
			item.rare = 11;
			item.noMelee = true;
			item.useStyle = 5;
			item.useAnimation = 30;
			item.useTime = 30;
			item.value = Item.buyPrice(0, 15, 85, 14);
			item.value = Item.sellPrice(0, 6, 27, 30);
			item.knockBack = 8.5F;
			item.damage = 120;
			item.autoReuse = true;
			item.scale = 1.1F;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType("ChainChompChomper");
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BARKBARK");
			item.shootSpeed = 25F;
			item.melee = true;
			item.channel = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chain Chomp Chomper");
			Tooltip.SetDefault("BARK BARK!");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 2));
		}

	}
}