using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class HeftyGoonie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hefty Goonie");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.width = 50;
			npc.height = 55;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.scale = 1.25f ;
			npc.value = Item.buyPrice(0, 0, 1, 13);
			npc.knockBackResist = 0.13f;
			npc.aiStyle = 2;
			aiType = NPCID.FlyingFish;
			animationType = NPCID.FlyingFish;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.OverworldDaySlime.Chance * 0.10f;
            }

            else
            {
                return SpawnCondition.OverworldDaySlime.Chance * 0f;
            }
		}

        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SackoSeed"), Main.rand.Next(1, 1));
		}
	}
}