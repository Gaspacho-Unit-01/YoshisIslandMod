using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons.KoopaShells
{
	public class OrangeKoopaShell : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 10;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 30;
			item.consumable = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("OrangeKoopaShell");
			item.shootSpeed = 6f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 0, 20);
			item.value = Item.sellPrice(0, 0, 0, 10);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Shell");
			Tooltip.SetDefault("");
		}
	}
}