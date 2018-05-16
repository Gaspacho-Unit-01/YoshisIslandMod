using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MISC
{
	public class PatchNotes : ModItem
	{
		public override void SetStaticDefaults()
		{   
		    DisplayName.SetDefault("Patch Notes");
			Tooltip.SetDefault("Here's a list of the most recent Patch Notes!"
			 + "\nWaluigi has been added as a playable character!"
			 + "\nKoops The Defender has been added as a Town NPC!"
             + "\nAdded MULTIPLE weapons and items!"
			 + "\nAdded a Power Star!"
			 + "\nAdded a new mount called Winged Blocks!"
			 + "\nFinally Added Deadly Guy, reworked and placed in expert mode!"
             + "\nEvery single Clown Copter in the mod got a recipe rework!"
			 + "\nAdjusted the size of ALL Koopas!"
			 + "\nUpdated Vivian The Helper."
			 + "\nRecolored Purple Yoshi and Changed the color of the bottom of Light Blue Yoshi's shoes."
             + "\nIncreased the amount of health and mana purple fruit heals you for."
			 + "\nGoonie and Hefty Goonie now only drop one Sack o Seed upon death. Hefty Goonies size was also adjusted."
			 + "\nMade multiple adjustments to all Green Shy Guys."
			 + "\nChanged the Mysterious Fruit button to Strange Fruit to make it more fitting."
             + "\nMade some adjustments to all Golden enemies and removed their coin worth upon death. Now they drop Golden Coins.");
			
		}

		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 37;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.maxStack = 1;
			item.value = Item.buyPrice(0, 0, 0, 0);
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
			item.accessory = true;
		}
	}
}