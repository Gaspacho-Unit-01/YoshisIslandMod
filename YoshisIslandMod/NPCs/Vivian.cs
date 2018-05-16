using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace YoshisIslandMod.NPCs
{
    [AutoloadHead]
    public class Vivian : ModNPC
    {
        public int Number = 0;


        public string Texture
        {
            get
            {
                return "YoshiMod/NPCs/Vivian";
            }
        }

        /*
        public override string[] AltTextures
        {
            get
            {
                return new string[] { "ExampleMod/NPCs/ExamplePerson_Alt_1" };
            }
        }
        */

        public override bool Autoload(ref string name)
        {
            name = "Vivian";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helper");
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 800;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 20;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 100;
            npc.lifeMax = 250;
			npc.scale = 1.35f ;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.knockBackResist = 0.10f;
            animationType = NPCID.Guide;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.OnFire] = true;
		}

		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.rand.Next(3) == 0)
			{
				player.AddBuff(BuffID.OnFire, 450, true);
			}
		}
		
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {

            int NumFruit = 0;

            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (player.active)
                {
                    for (int j = 0; j < player.inventory.Length; j++)
                    {
                        if (player.inventory[j].type == mod.ItemType("HintBlock"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("ClownCopter"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("Yoshi"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("SackoSeed"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("GrayFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("GreenFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("LightBlueFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("OrangeFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("PinkFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("PurpleFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("RedFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("GreenSeeds"))
                        {
                            NumFruit++;
                        }
                    }
                }
            }
           
            if (NumFruit > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        
        public override bool CheckConditions(int left, int right, int top, int bottom)
        {
            return true;
        } 

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Vivian";
                default:
                    return "Vivian";
            }
        }

        public override void FindFrame(int frameHeight)
        {
            /*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
        }

        public override string GetChat()
        {

            if(Number == 1)
            {
                return "Hi, I'm Vivian! It's so nice to see you again. I can tell you all kinds of information to help you on your adventure!";
                Number = 0;
            }

            else
            {
                switch (Main.rand.Next(9))
                {
                    case 0:
                        return "Hello again! I've got something you're going to LOVE! The first Official pet for the mod! Check it out!";
                    case 1:
                        return "Here's a little something about the most recent update! The most recent update was the ''Weapons Update'' that added a LOT weapons of different things along with two new NPC's! Along with that, I also got what they call a 'Frame Rework'! Hehe. How do I look? The patch notes are so massive that I had to write them down for you. Free of charge! Here you go.";                    
                    case 2:
                        return "Have you heard about the Yoshi's Island Mod discord server? It's a place to make friends, find useful information and more! If you don't feel like going to that cool place though, you can always come talk me and I'll tell you about the highlights of each patch. I can't tell you everything though. Sometimes the patch notes are too big.";
                    case 3:
                        return "Looking for a way to get started with Clown Copters or Yoshi's? Take a Cog, a Paint Brush, a Dye OR a Seed to the guide to find out what you can make!";
                    case 4:
                        return "Psssst.... I heard the next big update is going to be the Dropped Items Update where all of the current enemies on the island get an update! Along with that, there's also rumor about a rework coming to 'The Ultimate Rainbow Baby Clown Copter' since it's outdated. Aren't you excited?!";
                    case 5:
                        return "I saw this guy in a coat once. Real shady. I heard he ONLY comes around if you've obtained any kind of fruit.";
                    case 6:
                        return "Let's see.. I take 150 Iron bars.. 15 Cogs.. a paint brush, some paint and.. Oh, hey! I didn't see you there. I was working on a clown copter. Didn't you hear? It got reworked! It's so much more fun to ride now!";
					case 7:
                        return "Vanilliyan is one of the cutest things I've seen in the mod so far! He'll follow you everywhere, literally! He's the best companion to have with you while you explore.";
                    default:
                        return "Hello! Here to ask about the most recent update to clown copters, a NPC, Yoshi's or other items in general? Then you've come to the right girl!";
                }
            }
        }

        /*
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();

			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.Next(4) == 0)
			{
				chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
			}
			chat.Add("Sometimes I feel like I'm different from everyone else here.");
			chat.Add("What's your favorite color? My favorite colors are white and black.");
			chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
			chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
			chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		*/

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = NewMethod().Value;
        }

        private static Terraria.Localization.LocalizedText NewMethod()
        {
            return Lang.inter[28];
       	}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
		}
		
        public override void SetupShop(Chest shop, ref int nextSlot)
        {

            
            shop.item[nextSlot].SetDefaults(mod.ItemType("HintBlock"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("PatchNotes"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("Vanilliyan"));
            nextSlot++;
			/*
            shop.item[nextSlot].SetDefaults(mod.ItemType("EquipMaterial"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("BossItem"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleWorkbench"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleChair"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleDoor"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleBed"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleChest"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExamplePickaxe"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleHamaxe"));
            nextSlot++;
            if (Main.LocalPlayer.GetModPlayer<ExamplePlayer>(mod).ZoneExample)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleWings"));
                nextSlot++;
            }
            if (Main.moonPhase < 2)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleSword"));
                nextSlot++;
            }
            else if (Main.moonPhase < 4)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleGun"));
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleBullet"));
                nextSlot++;
            }
            else if (Main.moonPhase < 6)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ExampleStaff"));
                nextSlot++;
            }
            else
            {
            }
            // Here is an example of how your npc can sell items from other mods.
            if (ModLoader.GetLoadedMods().Contains("SummonersAssociation"))
            {
                shop.item[nextSlot].SetDefaults(ModLoader.GetMod("SummonersAssociation").ItemType("BloodTalisman"));
                nextSlot++;
            }
            */
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 50;
            knockback = 0f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 20;
            randExtraCooldown = 20;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.ImpFireball;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}