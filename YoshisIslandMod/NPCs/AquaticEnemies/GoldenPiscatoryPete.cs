using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class GoldenPiscatoryPete : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Piscatory Pete");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 26;
			npc.damage = 10;
			npc.defense = 40;
			npc.noGravity = true;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 0);
			npc.knockBackResist = 0.15f;
			npc.aiStyle = 16;

            if (Main.expertMode)
            {
                aiType = NPCID.Piranha;
            }

            else
            {
                aiType = NPCID.Goldfish;
            }
            
			animationType = NPCID.Goldfish; // he has goldfish frames so use goldfish frames
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
	}
}