using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons.KoopaShells
{
	public class DarkKoopaShell : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 140;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 999;
			item.consumable = true;
			item.useTime = 20;
			item.useAnimation = 20;
			item.shoot = mod.ProjectileType("DarkKoopaShell");
			item.shootSpeed = 10f;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.buyPrice(0, 2, 0, 40);
			item.value = Item.sellPrice(0, 1, 0, 20);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Shell");
			Tooltip.SetDefault("");
		}
	}
}