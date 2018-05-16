using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class CorruptedFlopsyFish : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Flopsy Fish");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 30;
			npc.damage = 0;
			npc.defense = 1;
			npc.velocity *= 0;
			npc.noGravity = true;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = Item.buyPrice(0, 0, 0, 10);
			npc.knockBackResist = 0.0f;
			npc.aiStyle = 16;

            if (Main.expertMode)
            {
                aiType = NPCID.Piranha; // this is so he may attack
            }

            else
            {
                aiType = NPCID.Goldfish; // this is so he may attack
            }

            animationType = NPCID.Shark;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.CorruptWaterCritter.Chance * 0.10f;
		}
	}
}