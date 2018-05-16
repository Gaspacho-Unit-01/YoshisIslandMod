using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class GoldenFlopsyFish : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Flopsy Fish");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 30;
			npc.damage = 15;
			npc.defense = 40;
			npc.noGravity = true;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = Item.buyPrice(0, 0, 0, 0);
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 16;

            if (Main.expertMode)
            {
                aiType = NPCID.Piranha;
            }

            else
            {
                aiType = NPCID.Goldfish;
            }

            animationType = NPCID.Shark;
	    }
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldenCoin"), Main.rand.Next(1, 20));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			                return SpawnCondition.Ocean.Chance * 0.2f;
                        }

                        else
                        {
                            return SpawnCondition.Ocean.Chance * 0f;
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