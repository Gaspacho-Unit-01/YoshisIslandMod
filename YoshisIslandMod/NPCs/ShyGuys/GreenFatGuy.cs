using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class GreenFatGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Fat Guy");
			Main.npcFrameCount[npc.type] = 12;
		}

		public override void SetDefaults()
		{
			npc.width = 45;
			npc.height = 60;
			npc.damage = 20;
			npc.defense = 10;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 10, 0);
			npc.knockBackResist = 0.10f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.hardMode)
                        {
			return SpawnCondition.SurfaceJungle.Chance * 0.3f;
                        }
                        else
                        {
                        return SpawnCondition.SurfaceJungle.Chance * 0f;
                        }
		}
	}
}