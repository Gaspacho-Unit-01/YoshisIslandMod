using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs
{
	public class VanilliyanBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Vanilliyan");
			Description.SetDefault("The legendary Vanilliyan is adventuring with you!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.dash = 20;
			player.doubleJumpUnicorn = true;
			player.buffTime[buffIndex] = 18000;
			YoshiPlayer modPlayer = (YoshiPlayer)player.GetModPlayer(mod, "YoshiPlayer");
			modPlayer.examplePet = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[mod.ProjectileType("Vanilliyan")] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("Vanilliyan"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}