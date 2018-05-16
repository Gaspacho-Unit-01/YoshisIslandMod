using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items
{
	public class TrollYoshi : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("When you picked it up, it whispered ''Get owned, Scrub.'' in your ear.");
		}

		public override void SetDefaults()
		{
			item.width = 60;
			item.height = 40;
			item.damage = 700;
			item.autoReuse = true;;
			item.useTime = 20;
			item.maxStack = 69;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.value = 0;
			item.rare = 1;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
		}
	}
}