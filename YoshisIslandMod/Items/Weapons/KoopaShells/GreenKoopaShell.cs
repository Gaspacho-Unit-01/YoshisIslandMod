using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Weapons.KoopaShells
{
	public class GreenKoopaShell : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 5;
			item.thrown = true;
			item.width = 20;
			item.height = 17;
			item.noUseGraphic = true;
			item.maxStack = 30;
			item.consumable = true;
			item.useTime = 25;
			item.useAnimation = 25;
			item.shoot = mod.ProjectileType("GreenKoopaShell");
			item.shootSpeed = 5f;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(0, 0, 0, 5);
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Shell");
			Tooltip.SetDefault("");
		}
	}
}