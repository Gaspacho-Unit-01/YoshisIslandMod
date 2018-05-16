using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class WaluigiGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Shy Guy");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 60;
			npc.defense = 18;
			npc.lifeMax = 600;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BossHit");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BossDestroyed");
			npc.value = Item.buyPrice(0, 5, 0, 0);
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ChaosElemental;
			animationType = NPCID.ChaosElemental;
		}
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WaluigiKey"), Main.rand.Next(1, 1));
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.Corruption.Chance * 0.1f;

		}
	}
}