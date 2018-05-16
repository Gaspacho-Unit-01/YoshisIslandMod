using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class Goonie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goonie");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 60;
			npc.damage = 6;
			npc.defense = 1;
			npc.lifeMax = 15;
			//npc.scale = 1.55f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 1, 3);
			npc.knockBackResist = 0.20f;
			npc.aiStyle = 2;
			aiType = NPCID.FlyingFish;
			animationType = NPCID.FlyingFish;
  	    }

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y - 5, mod.NPCType("FlightlessGoonie"));          
            }
	
        }
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.8f;
		}
		
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SackoSeed"), Main.rand.Next(1, 1));
		}
	}
}