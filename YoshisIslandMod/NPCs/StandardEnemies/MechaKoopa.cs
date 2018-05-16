using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class MechaKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mecha Koopa Chomper");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 35;
			npc.height = 26;
			npc.damage = 75;
			npc.defense = 0;
			npc.lifeMax = 60;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 1, 32, 70);
			npc.knockBackResist = 2f;
			npc.aiStyle = 41;
			aiType = NPCID.ChatteringTeethBomb;
			animationType = NPCID.ChatteringTeethBomb;
	    }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
            }

            else
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0f;
            }
		}
	}
}