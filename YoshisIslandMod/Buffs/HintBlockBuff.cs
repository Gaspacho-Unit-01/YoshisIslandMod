using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs
{
	public class HintBlockBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hint Block");
			Description.SetDefault("You are now armed with Knowledge!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[BuffID.Confused] = true;
			player.buffTime[buffIndex] = 18000;
			YoshiPlayer modPlayer = (YoshiPlayer)player.GetModPlayer(mod, "YoshiPlayer");
			modPlayer.examplePet = true;
			bool petProjectileNotSpawned = true;
			if (player.ownedProjectileCounts[mod.ProjectileType("HintBlock")] > 0)
			{
				petProjectileNotSpawned = false;
			}
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("HintBlock"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}