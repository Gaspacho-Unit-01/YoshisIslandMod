using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Projectiles
{
	public class InfiniteBoomerangBrosBoomerang : ModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 20;
			projectile.height = 17;
			projectile.friendly = true;
			projectile.aiStyle = 3;
			projectile.timeLeft = 4000;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Boomerang Bro's Boomerang");

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}