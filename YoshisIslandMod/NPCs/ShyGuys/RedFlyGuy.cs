using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class RedFlyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Fly Guy");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 40;
			npc.damage = 5;
			npc.defense = 1;
			npc.lifeMax = 15;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 0, 15);
			npc.knockBackResist = 0.12f;
			npc.aiStyle = 2;
			aiType = NPCID.FlyingFish;
			animationType = NPCID.FlyingFish;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y - 5, mod.NPCType("ShyGuy"));          
            }
	
        }
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.2f;

		}
	}
}