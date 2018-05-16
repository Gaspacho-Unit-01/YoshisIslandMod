using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons.KoopaShells
{
	public class BlueKoopaShell : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 60;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 30;
			item.consumable = true;
			item.useTime = 25;
			item.useAnimation = 25;
			item.shoot = mod.ProjectileType("BlueKoopaShell");
			item.shootSpeed = 12f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 0, 40);
			item.value = Item.sellPrice(0, 0, 0, 40);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noMelee = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Shell");
			Tooltip.SetDefault("Chases after your foes!");
		}
	}
}