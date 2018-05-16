using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace YoshisIslandMod.NPCs
{
    [AutoloadHead]
    public class WeaponsDealer : ModNPC
    {
        public int Number = 0;


        public string Texture
        {
            get
            {
                return "YoshiMod/NPCs/WeaponsDealer";
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
            name = "WeaponsDealer";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shady Weapons Dealer");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 8;
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
            npc.width = 28;
            npc.height = 38;
            npc.aiStyle = 7;
            npc.damage = 80;
            npc.defense = 200;
            npc.lifeMax = 250;
			npc.scale = 1.90f ;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
			npc.buffImmune[BuffID.Ichor] = true;
		}

		public override void OnHitPlayer(Player player, int damage, bool crit)
		{
			if (Main.rand.Next(3) == 0)
			{
				player.AddBuff(BuffID.Ichor, 450, true);
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
                        if (player.inventory[j].type == mod.ItemType("RedKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("DarkKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("PowerStar"))
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
                    return "Koopster";
                case 1:
                    return "Don Koopa";
                case 2:
                    return "Kooptonio";
				case 3:
                    return "Shell Face";	
					
                default:
                    return "Koopster";
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
                return "Well if it ain't my favorite customer. What can I do for ya?";
                Number = 0;
            }

            else
            {
                switch (Main.rand.Next(9))
                {
                    case 0:
                        return "Hey, you. Yeah, you with the funny looking face. I can make yous an offer yous can't refuse.";
                    case 1:
                        return "Where do I get all these weapons? You ask a lotta questions, pal. Keep it up and I'll hafta introduce you to my little friend.";
                    case 2:
                        return "There ain't no such thing as good money or bad money. It's just money, kid. You buyin' or what?";
                    case 3:
                        return "I don't know nothin' bout no Waluigi character, pal.";
                    case 4:
                        return "I darn well threw my back out tryinna swing one of them there flails. Who the hell designs these things, luigi's grandma?";
                    case 5:
                        return "Waluigi.. Waluigi.. Waluigi.. ain't ringing a bell.";
                    case 6:
                        return "I’ll tell ya what, if that Koops fella wants a bit ‘a’ respect ‘round here, he needs ditch that dingy old hoodie. Nothin’ says “the real deal” like a black’n’white Tux!";
                    case 7:
                        return "I gots Chain Chomps, I gots bob-ombs, I gots all kinds of stuff that'll make your enemies real dead, real fast.";
					case 8:
                        return "You got a Yoshi? Ey, do us all a favor and keep the muzzle on that stinkin' walking green garbage can, I just got this suit back from the dry cleaners.";
                    default:
                        return "This is some quality hardware I'm packin’ here, kid. Take advantage while supplies last. Ya never know when you'll find ya self in a sticky situation.. could happen any time, anyplace.";
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
			button2 = "Bribe";
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
            else
            {
                for (int k = 0; k < 255; k++)
                {
                    Player player = Main.player[k];
                    if (player.active)
                    {
                        for (int j = 0; j < player.inventory.Length ; j++)
                        {

                            if (player.inventory[j].type == mod.ItemType("GoldenCoin"))
                            {
                               
                             player.inventory[j].stack--;

                             j = 3000;
                             Main.npcChatText = "Alright, come close and keep ya voice down. You ain't hear this from me but, I heard yous can find that Waluigi fella in expert mode in that there corruption biome. Yous gotta fight some dumb shy guy with a funny hat and Waluigi should come out. Yous might need one of my.. state of the art weapons to defeat that thing. That's all I know, now scram. I gots things to do.";
                             Number++;
                             player.QuickSpawnItem(mod.ItemType("KoopstersNoteWaluigi"));
                              break;  
                            }
							
                            else
                            {
                                Main.npcChatText = "Non parlo senza soldi, capito? If yous too stupid to get that, I ain't talkin' without some cash.";
                                Number = 0;
                            }
                        }
                    }
                }
            }
        }
		
        public override void SetupShop(Chest shop, ref int nextSlot)
        {

            
            shop.item[nextSlot].SetDefaults(mod.ItemType("HammerBroHammer"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("BoomerangBrosBoomerang"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("RedSpikedBall"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("RedSpikedBallChain"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("SpikedBallChain"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("ChainChompChomper"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("BlueKoopaShell"));
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
            damage = 70;
            knockback = 1f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 20;
            randExtraCooldown = 20;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Bullet;
            attackDelay = 2;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 14f;
            randomOffset = 2f;
        }
    }
}