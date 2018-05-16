using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items
{
	public class PowerStar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Power Star");
			Tooltip.SetDefault(""
             + "\nGrants immunity to knockback."
			 + "\nGrants longer invincibility after being hit.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 8));
			ItemID.Sets.ItemIconPulse[item.type] = false;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.width = 35;
			item.height = 35;
			item.useTime = 20;
			item.useAnimation = 1;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 6, 85, 0);
			item.value = Item.sellPrice(0, 2, 34, 0);
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.accessory = true;
			item.defense = 10;
			item.rare = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.longInvince = true;
			player.noKnockback = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 300);	
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}