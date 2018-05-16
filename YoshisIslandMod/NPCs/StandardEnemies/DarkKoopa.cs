using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class DarkKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Koopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 50;
			npc.damage = 50;
			npc.defense = 30;
			npc.lifeMax = 340;
			//npc.scale = 1.70f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 3, 6, 14);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
        }
        public override void NPCLoot()
        {
        	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkKoopaShell"), Main.rand.Next(1, 2));
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.expertMode)
            {
			    return SpawnCondition.SolarEclipse.Chance * 0.8f;
            }

            else
            {
                return SpawnCondition.SolarEclipse.Chance * 0f;
            }
		}
	}
}