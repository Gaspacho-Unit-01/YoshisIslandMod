using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class PurpleKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Koopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 50;
			npc.damage = 17;
			npc.defense = 9;
			npc.lifeMax = 50;
			//npc.scale = 1.70f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 3, 93);
			npc.knockBackResist = 0.25f;
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
            if (Main.hardMode)
            {
			    return SpawnCondition.Corruption.Chance * 0.8f;
            }

            else
            {
                return SpawnCondition.Corruption.Chance * 0f;
            }
		}
	}
}