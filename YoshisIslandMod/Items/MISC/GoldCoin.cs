using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.MISC
{
	public class GoldenCoin : ModItem
	{
		public override void SetStaticDefaults()
		{   
		    DisplayName.SetDefault("Golden Coin");
			Tooltip.SetDefault("A golden coin with a Yoshi scribbled on the front.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 4));
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.maxStack = 999;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.rare = 3;
			item.UseSound = SoundID.Item32;
			item.noMelee = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin, 1);	
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}