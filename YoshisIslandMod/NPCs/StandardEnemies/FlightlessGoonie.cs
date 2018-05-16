using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class FlightlessGoonie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flightless Goonie");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 23;
			npc.damage = 1;
			npc.defense = 0;
			npc.lifeMax = 40;
			//npc.scale = 1.55f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 3);
			npc.knockBackResist = 0.60f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0f;
		}
	}
}