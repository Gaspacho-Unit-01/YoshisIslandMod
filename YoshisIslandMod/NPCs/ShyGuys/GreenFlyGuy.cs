using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class GreenFlyGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Fly Guy");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
		    npc.width = 25;
			npc.height = 40;
			npc.damage = 10;
			npc.defense = 2;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 3, 0);
			npc.knockBackResist = 0.10f;
			npc.aiStyle = 2;
			aiType = NPCID.FlyingFish;
			animationType = NPCID.FlyingFish;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y - 5, mod.NPCType("GreenShyGuy"));          
            }
	
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