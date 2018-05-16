using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
{
	public class KoopstersNoteWaluigi : ModItem
	{
		public override void SetStaticDefaults()
		{   
			Tooltip.SetDefault("I wrote this down for yous 'cause you ain't seem too bright."
			 + "\nYous can only find that Waluigi fella in expert mode in that there corruption biome."
			 + "\nYous might wanna set up camp 'cause that shy guy is in hiding. He owes me a lotta coins."
             + "\nYous gotta fight some dumb shy guy wit da funny hat, after he'll give you somethin' special."
			 + "\nOh yea.. Since yous one of my bestest clients, I'll give ya a little tip. He ain't no pushover."
			 + "\nYous gonna need to get prepared, if ya know what I'm sayin. He ain't take too kindly to folk like you.");
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
			item.rare = 12;
			item.accessory = true;
		}
	}
}