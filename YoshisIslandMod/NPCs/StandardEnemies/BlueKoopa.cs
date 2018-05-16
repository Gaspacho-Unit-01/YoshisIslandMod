using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class BlueKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Koopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 50;
			npc.damage = 15;
			npc.defense = 6;
			npc.lifeMax = 45;
			//npc.scale = 1.70f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 60);
			npc.knockBackResist = 0.27f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
        }
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BlueKoopaShell"), Main.rand.Next(1, 2));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.expertMode)
            {
			    return SpawnCondition.OverworldMushroom.Chance * 0.5f;
            }

            else
            {
                return SpawnCondition.OverworldMushroom.Chance * 0f;
            }
		}
	}
}