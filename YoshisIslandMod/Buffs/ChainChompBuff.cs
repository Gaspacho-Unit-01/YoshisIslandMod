using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs
{
	public class ChainChompBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Chain Chomp");
			Description.SetDefault("");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.noFallDmg = true;
            player.accFlipper = true;
            player.doubleJumpUnicorn = true;
            player.spikedBoots = 1;
            player.dash = 20;
			player.buffTime[buffIndex] = 18000;
			YoshiPlayer modPlayer = (YoshiPlayer)player.GetModPlayer(mod, "YoshiPlayer");
			modPlayer.examplePet = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[mod.ProjectileType("ChainChomp")] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("ChainChomp"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}