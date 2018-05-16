using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class YellowShyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Shy Guy");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 10;
			npc.defense = 3;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 0, 70);
			npc.knockBackResist = 0.15f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.OverworldDaySlime.Chance * 0.3f;
                        }
                        else
                        {
                        return SpawnCondition.OverworldDaySlime.Chance * 0f;
                        }
		}
	}
}