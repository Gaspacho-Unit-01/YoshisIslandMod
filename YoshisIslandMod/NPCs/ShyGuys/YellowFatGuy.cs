using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class YellowFatGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Fat Guy");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.width = 45;
			npc.height = 60;
			npc.damage = 25;
			npc.defense = 10;
			npc.lifeMax = 115;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			npc.knockBackResist = 0.10f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
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