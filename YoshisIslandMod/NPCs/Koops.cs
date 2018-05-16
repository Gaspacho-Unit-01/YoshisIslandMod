using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace YoshisIslandMod.NPCs
{
    [AutoloadHead]
    public class Koops : ModNPC
    {
        public int Number = 0;


        public string Texture
        {
            get
            {
                return "YoshiMod/NPCs/Koops";
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
            name = "Koops";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Defender");
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
            npc.height = 45;
            npc.aiStyle = 7;
            npc.damage = 30;
            npc.defense = 200;
            npc.lifeMax = 250;
			//npc.scale = 0.89f ;
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
                        if (player.inventory[j].type == mod.ItemType("GreenKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("RedKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("GreyKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("DarkKoopaShell"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("HintBlock"))
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
                    return "Koops";
                default:
                    return "Koops";
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
                return "Um... Hi there.";
                Number = 0;
            }

            else
            {
                switch (Main.rand.Next(9))
                {
                    case 0:
                        return "Um... Hi there, folks.";
                    case 1:
                        return "I... I heard Mario was going to be here. You don't mind if... If I wait here for him, with you... do you?";
                    case 2:
                        return "This place kind of reminds me of my home...";
                    case 3:
                        return "I... Man, this is embarrassing... See, everyone always says I'm a crybaby... A weakling. But if I can help you defeat Moon Lord... Well, I won't be those things. I'll be strong, like my dad.";
                    case 4:
                        return "Um... Excuse me! Err... Can... Can I help you?";
                    case 5:
                        return "Hey... I sell all kinds of shells... I-I find them around the island... I'll... I'll sell them to you for low prices.";
                    case 6:
                        return "This place is pretty scary... Can I just stay inside and hide under the bed...?";
                    case 7:
                        return "You kind of remind me of Mario... I mean... you look a little weird but you're brave...";
                    default:
                        return "Umm... How to begin? M-My name's...Koops. I heard you're traveling the island to defeat M-Moonlord... So, anyway, I, uh... I have a favor to ask... I-I changed my mind, I'll ask it later...";
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

            
            shop.item[nextSlot].SetDefaults(mod.ItemType("GreenKoopaShell"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("RedKoopaShell"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("OrangeKoopaShell"));
            nextSlot++;
			
			shop.item[nextSlot].SetDefaults(mod.ItemType("GreyKoopaShell"));
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
            damage = 30;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 25;
            randExtraCooldown = 25;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.WoodenArrowFriendly;
            attackDelay = 3;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}