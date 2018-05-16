using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class PiscatoryPete : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Piscatory Pete");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 25;
			npc.damage = 5;
			npc.defense = 0;
			npc.noGravity = true;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = Item.buyPrice(0, 0, 0, 10);
			npc.knockBackResist = 0.14f;
			npc.aiStyle = 16;

            if (Main.expertMode)
            {
                aiType = NPCID.Piranha; 
            }

            else
            {
                aiType = NPCID.Goldfish;
            }

            animationType = NPCID.Goldfish;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Ocean.Chance * 0.10f;
		}
	}
}