using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Buffs.CCBuffs
{
	public class ClownCopter : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Clown Copter");
			Description.SetDefault("At your service!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(mod.MountType<Mounts.ClownCopters.ClownCopter>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}