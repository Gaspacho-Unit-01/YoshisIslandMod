using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class PinkFatGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Fat Guy");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.width = 45;
			npc.height = 60;
			npc.damage = 20;
			npc.defense = 40;
			npc.lifeMax = 400;
			npc.boss = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 10, 0, 0);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.OverworldHallow.Chance * 0f;
                        }
                        else
                        {
                        return SpawnCondition.OverworldHallow.Chance * 0f;
                        }
		}
	}
}