using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons.KoopaShells
{
	public class RedKoopaShell : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 30;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 30;
			item.consumable = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("RedKoopaShell");
			item.shootSpeed = 10f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 0, 40);
			item.value = Item.sellPrice(0, 0, 0, 20);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Koopa Shell");
			Tooltip.SetDefault("");
		}
	}
}