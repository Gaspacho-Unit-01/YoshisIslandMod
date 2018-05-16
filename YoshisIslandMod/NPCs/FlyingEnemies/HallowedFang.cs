using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class HallowedFang: ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sweet Fang");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 18;
			npc.damage = 10;
			npc.defense = 4;
			npc.lifeMax = 20;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 0, 30);
			npc.knockBackResist = 0.13f;
			npc.aiStyle = 14;
			aiType = NPCID.IlluminantBat;
			animationType = NPCID.IlluminantBat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			 return SpawnCondition.OverworldHallow.Chance * 0.8f;
		}

        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkFruit"), Main.rand.Next(1, 3));
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