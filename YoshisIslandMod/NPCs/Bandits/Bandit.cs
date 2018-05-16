using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.Bandits
{
	public class Bandit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bandit");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 50;
			npc.damage = 15;
			npc.defense = 5;
			npc.lifeMax = 40;
			//npc.scale = .87f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 30);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.PossessedArmor;
			animationType = NPCID.PossessedArmor;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
		}
	}
}