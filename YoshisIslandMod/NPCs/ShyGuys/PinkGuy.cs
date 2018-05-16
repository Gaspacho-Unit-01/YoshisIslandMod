using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs.ShyGuys
{
	public class PinkGuy : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Guy");
			Main.npcFrameCount[npc.type] = 21;
		}

		public override void SetDefaults()
		{
			npc.width = 25;
			npc.height = 30;
			npc.damage = 20;
			npc.defense = 8;
			npc.lifeMax = 120;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/EnemyDie");
			npc.value = Item.buyPrice(0, 0, 10, 0);
			npc.knockBackResist = 0.15f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertGhoul;
			animationType = NPCID.DesertGhoul;
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.OverworldHallow.Chance * 0.3f;
                        }
                        else
                        {
                        return SpawnCondition.OverworldHallow.Chance * 0f;
                        }
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}