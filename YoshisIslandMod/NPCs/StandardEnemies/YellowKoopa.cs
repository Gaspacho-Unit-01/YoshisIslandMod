using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class YellowKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Koopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 50;
			npc.damage = 12;
			npc.defense = 8;
			npc.lifeMax = 30;
			//npc.scale = 1.70f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 40);
			npc.knockBackResist = 0.25f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OrangeKoopaShell"), Main.rand.Next(1, 2));
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDayDesert.Chance * 0.10f;

		}
	}
}