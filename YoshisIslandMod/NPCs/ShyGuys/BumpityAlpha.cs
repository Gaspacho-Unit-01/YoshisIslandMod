using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class BumpityAlpha : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bumpity");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 40;
			npc.damage = 0;
			npc.defense = 2;
			npc.lifeMax = 70;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 0, 15);
			npc.knockBackResist = 0.12f;
			npc.aiStyle = 68;
			aiType = NPCID.Duck;
			animationType = NPCID.Duck;
		}

        /*
		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
                 NPC.NewNPC((int)npc.position.X, (int)npc.position.Y - 5, mod.NPCType("BumpityOmega"));          
            }
	
        }
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            return SpawnCondition.TownSnowCritter.Chance * 0.3f; 
        }
        */
    }
}