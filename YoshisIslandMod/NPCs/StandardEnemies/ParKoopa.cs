using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.StandardEnemies
{
	public class ParKoopa : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Park-Oopa");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 55;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 50;
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
            switch (WorldGen.genRand.Next(6)) // generates a random number 0-6 statistically making each item a 1/7 chance of spawning upon defeat.
            {
                case 0:
                    Item.NewItem(npc.getRect(), ItemID.EskimoHood, 1);
                    break;

                case 1:
                    Item.NewItem(npc.getRect(), ItemID.EskimoCoat, 1);
                    break;

                case 2:
                    Item.NewItem(npc.getRect(), ItemID.EskimoPants, 1);
                    break;

                default:
                    break;
            }
        }
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

            return Main.expertMode ? SpawnCondition.OverworldDaySnowCritter.Chance * .5f : SpawnCondition.OverworldDaySnowCritter.Chance * .5f;

            /*                    /|\
                                   |
           || For future reference | this functions exactly the same as | this. ||
                                                                        |
                                                                        |
            if (Main.hardMode)                                          |
            {                                                           |
			    return SpawnCondition.FrostLegion.Chance * 0.20f;       |
            }                                                           |
                                                               /_______ /
            else                                               \
            {
                return SpawnCondition.FrostLegion.Chance * 0.10f;
            }
            */
		}
	}
}