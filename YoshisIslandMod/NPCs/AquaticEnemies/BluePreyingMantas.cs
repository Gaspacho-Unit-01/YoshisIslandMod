using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.AquaticEnemies
{
	public class BluePreyingMantas : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Preying Mantas");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 26;
			npc.damage = 35;
			npc.defense = 5;
			npc.noGravity = true;
			npc.lifeMax = 35;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = Item.buyPrice(0, 0, 9, 2);
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 18;
			aiType = NPCID.PinkJellyfish;
			animationType = NPCID.PinkJellyfish;
    }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
            if (Main.expertMode)
            {
			    return SpawnCondition.Ocean.Chance * 0.4f;
            }

            else
            {
                return SpawnCondition.Ocean.Chance * 0f;
            }
		}
	}
}