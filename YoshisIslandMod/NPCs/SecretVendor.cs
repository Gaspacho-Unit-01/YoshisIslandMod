using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace YoshisIslandMod.NPCs
{
    [AutoloadHead]
    public class SecretVendor : ModNPC
    {
        public int Number = 0;


        public string Texture
        {
            get
            {
                return "YoshiMod/NPCs/SecretVendor";
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
            name = "SecretVendor";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mysterious Vendor");
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
			npc.lavaImmune = true;
            npc.width = 40;
            npc.height = 45;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 1000;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath5;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        /*public override void HitEffect(int hitDirection, double damage)
        {
            int num = npc.life > 0 ? 1 : 5;
            for (int k = 0; k < num; k++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, mod.DustType("Sparkle"));
            }
        }

///////////////////////////////////////////////// Potentially useful Code in AI style.
            {
            this.homeless = true;
            if (!Main.dayTime)
            {
              this.homeTileX = (int) (this.Center.X / 16.0);
              this.homeTileY = (int) (this.position.Y + (double) this.height + 2.0) / 16;
              if (!flag2 && (double) this.ai[0] == 0.0)
              {
                this.ai[0] = 1f;
                this.ai[1] = 200f;
              }
              flag1 = false;
            }
          }
////////////////////////////////////////////////


public static void UnspawnTravelNPC()
    {
      int number = -1;
      for (int index = 0; index < 200; ++index)
      {
        if (Main.npc[index].active && Main.npc[index].type == 368)
        {
          number = index;
          break;
        }
      }
      if (number < 0)
        return;
      int num1 = (int) (Main.npc[number].Center.X / 16.0);
      int num2 = (int) (Main.npc[number].Center.Y / 16.0);
      bool flag = true;
      Rectangle rectangle1;
      // ISSUE: explicit reference operation
      ((Rectangle) @rectangle1).\u002Ector(num1 * 16 + 8 - NPC.sWidth / 2 - NPC.safeRangeX, num2 * 16 + 8 - NPC.sHeight / 2 - NPC.safeRangeY, NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        if (Main.player[index].active)
        {
          Rectangle rectangle2;
          // ISSUE: explicit reference operation
          ((Rectangle) @rectangle2).\u002Ector((int) Main.player[index].position.X, (int) Main.player[index].position.Y, Main.player[index].width, Main.player[index].height);
          // ISSUE: explicit reference operation
          if (((Rectangle) @rectangle2).Intersects(rectangle1))
          {
            flag = false;
            break;
          }
        }
      }
      if (!flag)
        return;
      string fullName = Main.npc[number].FullName;
      if (Main.netMode == 0)
        Main.NewText(Lang.misc[35].Format((object) fullName), (byte) 50, (byte) 125, byte.MaxValue, false);
      else if (Main.netMode == 2)
        NetMessage.BroadcastChatMessage(NetworkText.FromKey(Lang.misc[35].Key, (object) Main.npc[number].GetFullNetName()), new Color(50, 125, (int) byte.MaxValue), -1);
      Main.npc[number].active = false;
      Main.npc[number].netSkip = -1;
      Main.npc[number].life = 0;
      NetMessage.SendData(23, -1, -1, (NetworkText) null, number, 0.0f, 0.0f, 0.0f, 0, 0, 0);
    }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            public static void SpawnTravelNPC()
    {
      if (Main.eclipse || !Main.dayTime || Main.invasionType > 0 && Main.invasionDelay == 0 && Main.invasionSize > 0)
        return;
      for (int index = 0; index < 200; ++index)
      {
        if (Main.npc[index].active && Main.npc[index].type == 368)
          return;
      }
      Chest.SetupTravelShop();
      NetMessage.SendTravelShop(-1);
      int[] numArray = new int[200];
      int maxValue = 0;
      for (int index = 0; index < 200; ++index)
      {
        if (Main.npc[index].active && Main.npc[index].townNPC && (Main.npc[index].type != 37 && !Main.npc[index].homeless))
        {
          numArray[maxValue] = index;
          ++maxValue;
        }
      }
      if (maxValue == 0)
        return;
      int index1 = numArray[Main.rand.Next(maxValue)];
      WorldGen.bestX = Main.npc[index1].homeTileX;
      WorldGen.bestY = Main.npc[index1].homeTileY;
      int minValue = WorldGen.bestX;
      int num1 = WorldGen.bestX;
      int bestY = WorldGen.bestY;
      for (int bestX = WorldGen.bestX; bestX > WorldGen.bestX - 10 && (WorldGen.SolidTile(bestX, bestY) || Main.tileSolidTop[(int) Main.tile[bestX, bestY].type]) && (!Main.tile[bestX, bestY - 1].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 1].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 1].type]) && ((!Main.tile[bestX, bestY - 2].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 2].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 2].type]) && (!Main.tile[bestX, bestY - 3].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 3].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 3].type])); --bestX)
        minValue = bestX;
      for (int bestX = WorldGen.bestX; bestX < WorldGen.bestX + 10 && (WorldGen.SolidTile(bestX, bestY) || Main.tileSolidTop[(int) Main.tile[bestX, bestY].type]) && (!Main.tile[bestX, bestY - 1].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 1].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 1].type]) && ((!Main.tile[bestX, bestY - 2].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 2].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 2].type]) && (!Main.tile[bestX, bestY - 3].active() || !Main.tileSolid[(int) Main.tile[bestX, bestY - 3].type] || Main.tileSolidTop[(int) Main.tile[bestX, bestY - 3].type])); ++bestX)
        num1 = bestX;
      for (int index2 = 0; index2 < 30; ++index2)
      {
        int num2 = Main.rand.Next(minValue, num1 + 1);
        if (index2 < 20)
        {
          if (num2 < WorldGen.bestX - 1 || num2 > WorldGen.bestX + 1)
          {
            WorldGen.bestX = num2;
            break;
          }
        }
        else if (num2 != WorldGen.bestX)
        {
          WorldGen.bestX = num2;
          break;
        }
      }
      int index3 = WorldGen.bestX;
      int index4 = WorldGen.bestY;
      bool flag = false;
      if (!flag && (double) index4 <= Main.worldSurface)
      {
        for (int index2 = 20; index2 < 500; ++index2)
        {
          for (int index5 = 0; index5 < 2; ++index5)
          {
            index3 = index5 != 0 ? WorldGen.bestX - index2 * 2 : WorldGen.bestX + index2 * 2;
            if (index3 > 10 && index3 < Main.maxTilesX - 10)
            {
              int num2 = WorldGen.bestY - index2;
              double num3 = (double) (WorldGen.bestY + index2);
              if (num2 < 10)
                num2 = 10;
              if (num3 > Main.worldSurface)
                num3 = Main.worldSurface;
              for (int index6 = num2; (double) index6 < num3; ++index6)
              {
                index4 = index6;
                if (Main.tile[index3, index4].nactive() && Main.tileSolid[(int) Main.tile[index3, index4].type])
                {
                  if ((int) Main.tile[index3, index4 - 3].liquid == 0 && (int) Main.tile[index3, index4 - 2].liquid == 0 && ((int) Main.tile[index3, index4 - 1].liquid == 0 && !Collision.SolidTiles(index3 - 1, index3 + 1, index4 - 3, index4 - 1)))
                  {
                    flag = true;
                    Rectangle rectangle1;
                    // ISSUE: explicit reference operation
                    ((Rectangle) @rectangle1).\u002Ector(index3 * 16 + 8 - NPC.sWidth / 2 - NPC.safeRangeX, index4 * 16 + 8 - NPC.sHeight / 2 - NPC.safeRangeY, NPC.sWidth + NPC.safeRangeX * 2, NPC.sHeight + NPC.safeRangeY * 2);
                    for (int index7 = 0; index7 < (int) byte.MaxValue; ++index7)
                    {
                      if (Main.player[index7].active)
                      {
                        Rectangle rectangle2;
                        // ISSUE: explicit reference operation
                        ((Rectangle) @rectangle2).\u002Ector((int) Main.player[index7].position.X, (int) Main.player[index7].position.Y, Main.player[index7].width, Main.player[index7].height);
                        // ISSUE: explicit reference operation
                        if (((Rectangle) @rectangle2).Intersects(rectangle1))
                        {
                          flag = false;
                          break;
                        }
                      }
                    }
                    break;
                  }
                  break;
                }
              }
            }
            if (flag)
              break;
          }
          if (flag)
            break;
        }
      }
      int index8 = NPC.NewNPC(index3 * 16, index4 * 16, 368, 1, 0.0f, 0.0f, 0.0f, 0.0f, (int) byte.MaxValue);
      Main.npc[index8].homeTileX = WorldGen.bestX;
      Main.npc[index8].homeTileY = WorldGen.bestY;
      Main.npc[index8].homeless = true;
      if (index3 < WorldGen.bestX)
        Main.npc[index8].direction = 1;
      else if (index3 > WorldGen.bestX)
        Main.npc[index8].direction = -1;
      Main.npc[index8].netUpdate = true;
      string fullName = Main.npc[index8].FullName;
      if (Main.netMode == 0)
      {
        Main.NewText(Language.GetTextValue("Announcement.HasArrived", (object) fullName), (byte) 50, (byte) 125, byte.MaxValue, false);
      }
      else
      {
        if (Main.netMode != 2)
          return;
        NetMessage.BroadcastChatMessage(NetworkText.FromKey("Announcement.HasArrived", (object) Main.npc[index8].GetFullNetName()), new Color(50, 125, (int) byte.MaxValue), -1);
      }
    }

////////////////////////////////////////////////////////////////////////////////////////////
        */


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
                        if (player.inventory[j].type == mod.ItemType("BlackFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("DarkBlueFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("BlueFruit"))
                        {
                            NumFruit++;
                        }

                        else if (player.inventory[j].type == mod.ItemType("BrownFruit"))
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

                        else if (player.inventory[j].type == mod.ItemType("YellowFruit"))
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
                    return "Not Yoshi";
                case 1:
                    return "Ihsoy";
                case 2:
                    return "Agent Y";
				case 3:
                    return "Shady Merchant";
					
                default:
                    return "Don Azure";
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
            /*
            int Painter = npc.FindFirstNPC(NPCID.Painter);
            if (Painter >= 0 && Main.npc[painter].GivenName == "Mario")
            {
                return "Mario? Oh you mean the painter? yeah I have seen him before, he seems alright";
            }
			else
			{
				return "Mario? Never met him before in my life";
			}*/

            if(Number == 1)
            {
                return "What'd ya expect? Real effort? apparently you have forgotten what game you're playing.";
                Number = 0;
            }

            else
            {
                switch (Main.rand.Next(9))
                {
                    case 0:
                        return "Hey, kid! I can make you an offer that you cannot refuse.";
                    case 1:
                        return "So I heard along the grape vine that you happened across some... strange fruit.";
                    case 2:
                        return "Don't mind me just another humble townsfolk, no rhyme nor reason to suspect anything else.";
                    case 3:
                        return "All I can tell you about the weird enemies you have been seeing lately, is that they have a pretty keen sense smell. How else do you think they got their hands on all that fruit?";
                    case 4:
                        return "Lots of trees around here, reminds me of home.";
                    case 5:
                        return "You know, ROMs are just a myth. A figment of publics imagination.";
                    case 6:
                        return "*Sniff* *Sniff* Mmmm... I smell fruit! You got some?";
                    case 7:
                        return "I'm really not this much of a conversationalist. I hardly even talk to my own friends unless the topic is fruit related.";
                    default:
                        return "Mario? Never met him before in my life.";
                        //default:
                        //return "Oof, sitting around all day has sure worked up an appetite, got any of that strange fruit?";
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
            button2 = "Strange Fruit";
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

                            if (player.inventory[j].type == mod.ItemType("BlackFruit"))
                            {
                               
                             player.inventory[j].stack--;

                             j = 3000;
                             Main.npcChatText = "Huh, A sane person would have quit before they got to this point. I applaud you for your tenacity. Here's your half arsed re-color.";
                             Number++;
                             player.QuickSpawnItem(mod.ItemType("BlackYoshi"));
                                
                            }
							
							else if (player.inventory[j].type == mod.ItemType("DarkBlueFruit"))
                            {
                                player.inventory[j].stack--;
												
                                j = 3000;
                                Main.npcChatText = "This is actually the same color as the yellow one, It's an elaborate optical illusion I have been working on.";
                                player.QuickSpawnItem(mod.ItemType("DarkBlueYoshi"));
                                Number = 0;
                            }

                            else if(player.inventory[j].type == mod.ItemType("BlueFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "What does it taste like you ask? Well it tastes like Blue of course!";
                                player.QuickSpawnItem(mod.ItemType("BlueYoshi"));
                                Number = 0;
                            }

                            else if(player.inventory[j].type == mod.ItemType("BrownFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "Ah, yes! Another great find. I hope this one didn't cause you too much trouble.";
                                player.QuickSpawnItem(mod.ItemType("BrownYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("GrayFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "Don't worry about where I get all these eggs from. It's a family secret, see.";
                                player.QuickSpawnItem(mod.ItemType("GrayYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("GreenFruit"))
                            {
                               player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "The green ones are my favorite!";
                                player.QuickSpawnItem(mod.ItemType("Yoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("LightBlueFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "Nice, Nice, Baby!";
                                player.QuickSpawnItem(mod.ItemType("LightBlueYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("OrangeFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "YAHOOO!!! ...Sorry, lost my cool there. Speak NOTHING of this.";
                                player.QuickSpawnItem(mod.ItemType("OrangeYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("PinkFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "It tastes just like Cotton Candy, if you were wondering. Here's something for your trouble.";
                                player.QuickSpawnItem(mod.ItemType("PinkYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("PurpleFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "Wise choice, friend. It doesn't taste nearly as good as it looks.";
                                player.QuickSpawnItem(mod.ItemType("PurpleYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("RedFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "You know, it's red so it makes you go faster. Universal rule, ya know. No, your not going faster because you are in searing pain or because your entire body just spontaneously combusted, but because it's red.";
                                player.QuickSpawnItem(mod.ItemType("RedYoshi"));
                                Number = 0;
                            }

                            else if (player.inventory[j].type == mod.ItemType("YellowFruit"))
                            {
                                player.inventory[j].stack--;
                                j = 3000;
                                Main.npcChatText = "It's really just an oversized lemon, nothing quite mysterious about it.";
                                player.QuickSpawnItem(mod.ItemType("YellowYoshi"));
                                Number = 0;
                            }

                            else
                            {
                                Main.npcChatText = "Come back when you got the goods.";
                                Number = 0;
                            }
                        }
                    }
                }
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {

            
            shop.item[nextSlot].SetDefaults(mod.ItemType("IOU"));
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
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.WoodenArrowFriendly;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}