using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
{
	public class IOU : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A crumpled up slip of paper with the letters I.O.U scribbled on one side.");
		}

		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 19;
			item.useStyle = 3;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
		}
	}
}