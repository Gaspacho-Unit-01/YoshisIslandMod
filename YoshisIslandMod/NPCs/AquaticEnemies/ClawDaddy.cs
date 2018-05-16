using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class ClawDaddy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ClawDaddy");
			Main.npcFrameCount[npc.type] = 18;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 25;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 20);
			npc.knockBackResist = 0.3f;
			npc.aiStyle = 3;
			aiType = NPCID.Crab;
			animationType = NPCID.Crab;
  	    }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Ocean.Chance * 0.5f;
		}
	}
}