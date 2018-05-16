using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class PinkPreyingMantas : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Preying Mantas");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 26;
			npc.damage = 30;
			npc.defense = 5;
			npc.noGravity = true;
			npc.lifeMax = 32;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = Item.buyPrice(0, 0, 4, 0);
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 18;
			aiType = NPCID.PinkJellyfish;
			animationType = NPCID.PinkJellyfish; //WARNING: this AI has hardmode attack that does alot of damage, and we do not have the frames to animate the attack this is going to be a major headache to players.
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.OverworldDaySlime.Chance * 0.3f;
            }

            else
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0f;
            }

		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}

		}
	}
}