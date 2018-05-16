using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.NPCs
{
	public class DarkStar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Star");
			Main.npcFrameCount[npc.type] = 32;
		}

		public override void SetDefaults()
		{
			npc.aiStyle = 69;
			npc.lifeMax = 500000;
			npc.damage = 80;
			npc.defense = 40;
			npc.width = 120;
			npc.height = 122;
			npc.HitSound = SoundID.NPCHit14;
			npc.DeathSound = SoundID.NPCDeath20;
			npc.value = Item.buyPrice(20, 37, 24, 99);
			npc.knockBackResist = 0.40f;
			npc.boss = true;
			npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
			npc.buffImmune[24] = true;
            music = MusicID.Boss3;
			aiType = NPCID.DukeFishron;
			animationType = NPCID.DukeFishron;
		}
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.SuperHealingPotion;
        }
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
                        if (Main.expertMode)
                        {
			return SpawnCondition.SolarEclipse.Chance * 0f;
                        }
                        else
                        {
                        return SpawnCondition.SolarEclipse.Chance * 0f;
                        }
		}
	}
}