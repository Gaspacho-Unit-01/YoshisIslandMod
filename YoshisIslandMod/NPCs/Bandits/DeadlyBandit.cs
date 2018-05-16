using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.Bandits
{
	public class DeadlyBandit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deadly Bandit");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 50;
			npc.damage = 100;
			npc.defense = 5;
			npc.lifeMax = 350;
			//npc.scale = 1.89f ;
			npc.HitSound = SoundID.NPCHit48;
			npc.DeathSound = SoundID.NPCDeath50;
			npc.value = Item.buyPrice(0, 10, 3, 32);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.Fritz;
			animationType = NPCID.PossessedArmor;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.expertMode)
            {
			    return SpawnCondition.SolarEclipse.Chance * 0.1f;
            }

            else
            {
                return SpawnCondition.SolarEclipse.Chance * 0f;
            }
		}
	}
}