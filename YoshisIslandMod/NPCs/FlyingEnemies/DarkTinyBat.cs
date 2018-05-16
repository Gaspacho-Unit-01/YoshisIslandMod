using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class DarkTinyBat: ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Fang");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 18;
			npc.damage = 50;
			npc.defense = 5;
			npc.lifeMax = 80;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 20, 0);
			npc.knockBackResist = 0.14f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			                return SpawnCondition.SolarEclipse.Chance * 0.5f;
                        }

                        else
                        {
                            return SpawnCondition.SolarEclipse.Chance * 0.0f;
                        }
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlackFruit"), Main.rand.Next(1, 2));
		}
	}
}