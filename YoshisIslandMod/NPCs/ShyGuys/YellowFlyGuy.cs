using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class YellowFlyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Fly Guy");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 40;
			npc.damage = 15;
			npc.defense = 3;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 5, 0);
			npc.knockBackResist = 0.8f;
			npc.aiStyle = 2;
			aiType = NPCID.FlyingFish;
			animationType = NPCID.FlyingFish;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y - 5, mod.NPCType("YellowShyGuy"));          
            }
	
        }
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
                        }
                        else
                        {
                        return SpawnCondition.OverworldDaySlime.Chance * 0f;
                        }
		}
	}
}