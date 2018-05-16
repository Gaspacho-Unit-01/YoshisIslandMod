using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class EnragedHeftyGoonie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enraged Hefty Goonie");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			npc.width = 54;
			npc.height = 58;
			npc.damage = 35;
			npc.defense = 0;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 20, 7);
			npc.knockBackResist = 0f;
			npc.aiStyle = 14;
			aiType = NPCID.GiantFlyingFox;
			animationType = NPCID.FlyingFish;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.OverworldDaySlime.Chance * 0f;
                        }
                        else
                        {
                        return SpawnCondition.OverworldDaySlime.Chance * 0f;
                        }
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RedSeeds"), Main.rand.Next(1, 2));
		}
	}
}