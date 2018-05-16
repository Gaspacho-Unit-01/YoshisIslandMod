using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class SpookyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spooky Guy");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;

            if (Main.expertMode)
            {
                npc.damage = 20;
                npc.defense = 7;
                npc.lifeMax = 80;
            }

            else
            {
                npc.damage = 15;
                npc.defense = 5;
                npc.lifeMax = 60;
            }

			npc.HitSound = SoundID.NPCHit18;
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
            npc.value = Item.buyPrice(0, 0, 6, 14);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.ChaosElemental;
			animationType = NPCID.ChaosElemental;
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            float a = SpawnCondition.Dungeon.Chance;
            return Main.expertMode ? a * 0.50f: a * 0.2f; ;
		}
	}
}