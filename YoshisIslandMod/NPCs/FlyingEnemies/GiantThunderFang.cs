using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class GiantThunderFang: ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Thunder Fang");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 90;
			npc.height = 69;
			npc.damage = 40;
			npc.defense = 16;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 2, 14, 8);
			npc.knockBackResist = 0.5f;
			npc.boss = true;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.OverworldDayRain.Chance * 0f;
            }

            else
            {
                return SpawnCondition.OverworldDayRain.Chance * 0f;
            }
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("YellowFruit"), Main.rand.Next(1, 15));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlueYoshi"), Main.rand.Next(1, 1));
		}
	}
}