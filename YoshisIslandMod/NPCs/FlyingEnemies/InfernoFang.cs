using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.FlyingEnemies
{
	public class InfernoFang: ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Inferno Fang");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 18;
			npc.damage = 25;
			npc.defense = 4;
			npc.lifeMax = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = Item.buyPrice(0, 0, 6, 66);
			npc.knockBackResist = 0.6f;
			npc.aiStyle = 14;
			aiType = NPCID.Hellbat;
			animationType = NPCID.Hellbat;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Underworld.Chance * 0.10f; 
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RedFruit"), Main.rand.Next(1, 2));
		}
	}
}