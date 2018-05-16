using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class DeadlyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deadly Guy");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 250;
			npc.defense = 40;
			npc.lifeMax = 800;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(2, 0, 0, 0);
			npc.knockBackResist = 0.30f;
			npc.aiStyle = 3;
			npc.boss = true;
			aiType = NPCID.Fritz;
			animationType = NPCID.Fritz;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.SolarEclipse.Chance * 0f;
                        }
                        else
                        {
                        return SpawnCondition.SolarEclipse.Chance * 0f;
                        }
		}
	}
}