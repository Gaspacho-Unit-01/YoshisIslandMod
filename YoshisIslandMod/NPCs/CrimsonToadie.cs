using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs
{
	public class CrimsonToadie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toadie");
			Main.npcFrameCount[npc.type] = 11;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 40;
			npc.damage = 40;
			npc.defense = 5;
			npc.lifeMax = 40;
			npc.HitSound = SoundID.NPCHit18;
			npc.DeathSound = SoundID.NPCDeath21;
			npc.value = Item.buyPrice(0, 0, 4, 40);
			npc.knockBackResist = 0f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.expertMode)
            {
			    return SpawnCondition.Crimson.Chance * 0.3f;
            }

            else
            {
                return SpawnCondition.Crimson.Chance * 0f;
            }
		}
	}
}