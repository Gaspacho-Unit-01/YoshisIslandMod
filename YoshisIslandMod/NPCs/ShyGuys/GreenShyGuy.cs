using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class GreenShyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Shy Guy");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 0, 30);
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