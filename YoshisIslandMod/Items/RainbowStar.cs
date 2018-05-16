using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace YoshisIslandMod.Items
{
	public class RainbowStar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Legendary Rainbow Star");
			Tooltip.SetDefault("Dun Dun Da Dun Dun Da Dun Dun Dun Dun Dun Da Dun!"
             + "\nG O D M O D E A C T I V A T E");
			 Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(2, 7));
			ItemID.Sets.ItemIconPulse[item.type] = false;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.width = 35;
			item.height = 35;
			item.useTime = 20;
			item.useAnimation = 1;
			item.useStyle = 4;
			item.value = Item.buyPrice(999, 999, 999, 999);
			item.UseSound = SoundID.Item1;
			item.noMelee = true;
			item.accessory = true;
			item.defense = 9999;
			item.rare = 12;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.Confused] = true;
			player.fireWalk = true;
			player.longInvince = true;
			player.noKnockback = true;
			player.buffImmune[44] = true; //Frostburn
			player.buffImmune[46] = true; //Chilled
			player.buffImmune[47] = true; //Frozen
			player.buffImmune[20] = true; //Poisoned
			player.buffImmune[22] = true; //Darkness
			player.buffImmune[24] = true; //Fire
			player.buffImmune[23] = true; //Cursed
			player.buffImmune[30] = true; //Bleeding
			player.buffImmune[31] = true; //Confused
			player.buffImmune[32] = true; //Slowed
			player.buffImmune[33] = true; //Weak
			player.buffImmune[35] = true; //Silenced
			player.buffImmune[36] = true; //Broken Armor
			player.buffImmune[69] = true; //Ichor
			player.buffImmune[70] = true; //Venom
			player.buffImmune[80] = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (Main.rand.Next(250) == 0)
			{
				if (player.ownedProjectileCounts[mod.ProjectileType("PowerStar")] <= 4)
				{
					Projectile.NewProjectile(player.position, Vector2.Zero, mod.ProjectileType("PowerStar"), 20, 0, player.whoAmI);
				}
			}
		}
	}
}