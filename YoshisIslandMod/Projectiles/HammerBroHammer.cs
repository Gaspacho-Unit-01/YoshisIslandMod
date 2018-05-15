using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Projectiles
{
	public class HammerBroHammer : ModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 30;
			projectile.height = 30;
			projectile.friendly = true;
			projectile.aiStyle = 2;
			projectile.timeLeft = 4000;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hammer Bros Hammer");

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.45f;
		}
	}
}