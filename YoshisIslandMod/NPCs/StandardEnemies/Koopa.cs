using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class Koopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Koopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 55;
			npc.damage = 10;
			npc.defense = 4;
			npc.lifeMax = 15;
			//npc.scale = 1.70f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 15);
			npc.knockBackResist = 0.45f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreenKoopaShell"), Main.rand.Next(1, 2));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
		}
	}
}