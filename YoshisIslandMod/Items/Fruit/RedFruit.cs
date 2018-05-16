using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class RedFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Red Fruit");
			Tooltip.SetDefault("With one bite, your blood starts to boil and your entire body bursts into flames.");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
			item.height = 30;
			item.useTime = 80;
			item.healMana = 10;
			item.buffType = BuffID.OnFire;
			item.buffTime = 800;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 80;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 10, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
	    }

		public override bool UseItem(Player player)
		{
			const int time = 800 * 1;
			player.AddBuff(BuffID.Swiftness, time);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RedSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}