using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class LightBlueFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Light Blue Fruit");
			Tooltip.SetDefault("With one bite, you feel every cell in your body freeze.");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.healMana = 100;
			item.buffType = BuffID.Chilled;
			item.buffTime = 1250;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
        }

		public override bool UseItem(Player player)
		{
			const int time = 400 * 1; 
			player.AddBuff(BuffID.Ironskin, time);
			player.AddBuff(BuffID.Frozen, time);
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LightBlueSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}