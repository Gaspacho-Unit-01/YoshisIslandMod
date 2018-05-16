using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class BumpityOmega : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bumpity");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 0;
			npc.defense = 5;
			npc.lifeMax = 45;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 0, 25);
			npc.knockBackResist = 0.12f;
			npc.aiStyle = 7;
			aiType = NPCID.Penguin;
			animationType = NPCID.Penguin;
		}

        /*
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LightBlueFruit"), Main.rand.Next(1, 3));
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.TownSnowCritter.Chance * 0.10f;

		}
        */
	}
}