using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Projectiles
{
	public class Vanilliyan : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vanilliyan The Creator");
			Main.projFrames[projectile.type] = 5;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			YoshiPlayer modPlayer = player.GetModPlayer<YoshiPlayer>(mod);
			if (player.dead)
			{
				modPlayer.examplePet = false;
			}
			if (modPlayer.examplePet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}