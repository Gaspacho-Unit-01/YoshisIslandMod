using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Items.Fruit
{
	public class PurpleFruit : ModItem
	{
		public override void SetStaticDefaults()
		{   DisplayName.SetDefault("Purple Fruit");
			Tooltip.SetDefault("It's soft to the touch and smells like a corrupted peach.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.useTime = 50;
			item.healLife = 120;
			item.healMana = 120;
			item.buffType = BuffID.Poisoned;
			item.buffTime = 14000;
			item.consumable = true;
			item.autoReuse = true;
			item.maxStack = 30;
			item.useAnimation = 50;
			item.useStyle = 4;
			item.value = Item.sellPrice(0, 0, 3, 0);
			item.rare = 5;
			item.UseSound = SoundID.Item2;
			item.noMelee = true;
        }

		public override bool UseItem(Player player)
		{
			const int time = 14000 * 1;
			player.AddBuff(BuffID.Poisoned, time);
			player.AddBuff(BuffID.OnFire, time);
			player.AddBuff(BuffID.Suffocation, time);
			player.AddBuff(BuffID.Burning, time);
			player.AddBuff(BuffID.Ichor, time);
			player.AddBuff(BuffID.Dazed, time);
		    player.AddBuff(BuffID.Obstructed, time);
			player.AddBuff(BuffID.Blackout, time);
			
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PurpleSeeds", 1);
			recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}