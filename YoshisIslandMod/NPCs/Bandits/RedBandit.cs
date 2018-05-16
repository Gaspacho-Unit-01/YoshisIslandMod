using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.Bandits
{
	public class RedBandit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Bandit");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 50;
			npc.damage = 22;
			npc.defense = 5;
			npc.lifeMax = 45;
			//npc.scale = .89f ;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 8, 40);
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			aiType = NPCID.PossessedArmor;
			animationType = NPCID.PossessedArmor;
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.hardMode)
            {
			    return SpawnCondition.OverworldNight.Chance * 0.4f;
            }

            else
            {
                return SpawnCondition.OverworldNight.Chance * 0.0f;
            }
		}
	}
}