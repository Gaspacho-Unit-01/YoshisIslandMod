using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items.Accessories
{
	public class BlessingPowerStar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blessing Of The Power Stars");
			Tooltip.SetDefault("Summons the power of the stars to surround and protect you!"
			 + "\nEach Power Star emits light."
			 + "\nEach Power Star deals damage to enemies."
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
			item.value = Item.buyPrice(0, 14, 85, 0);
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.accessory = true;
			item.defense = 20;
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
			recipe.AddIngredient(null, "PowerStar", 5);	
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (Main.rand.Next(250) == 0)
			{
				if (player.ownedProjectileCounts[mod.ProjectileType("PowerStar")] <= 20)
				{
					Projectile.NewProjectile(player.position, Vector2.Zero, mod.ProjectileType("PowerStar"), 20, 0, player.whoAmI);
				}
			}
		}
	}
}