using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class CorruptedFang: ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Fang");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 18;
			npc.damage = 18;
			npc.defense = 1;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 3, 0);
			npc.knockBackResist = 0.9f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.Corruption.Chance * 0.8f;
            }

            else
            {
                return SpawnCondition.Corruption.Chance * 0.0f;
            }
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PurpleFruit"), Main.rand.Next(1, 2));
		}
	}
}