using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons
{
	public class RedSpikedBall : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 40;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.useTime = 25;
			item.useAnimation = 25;
			item.shoot = mod.ProjectileType("RedSpikedBall");
			item.shootSpeed = 10f;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(0, 0, 0, 40);
			item.value = Item.sellPrice(0, 0, 0, 40);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Spiked Ball");
			Tooltip.SetDefault("Ye-ouch!");
		}
	}
}