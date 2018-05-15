using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts.ClownCopters
{
	public class YellowBabyClownCopter : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 19;
			mountData.buff = mod.BuffType("YellowBabyClownCopter");
			mountData.heightBoost = 35;
			mountData.flightTimeMax = 5000;
			mountData.fatigueMax = 300000;
			mountData.fallDamage = 0f;
			mountData.usesHover = true;
			mountData.runSpeed = 10f;
			mountData.dashSpeed = 8f;
			mountData.acceleration = 0.50f;
			mountData.jumpHeight = 8;
			mountData.jumpSpeed = 8f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 6;
			int[] array = new int[mountData.totalFrames];
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				array[num2] = 16;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 10;
			mountData.bodyFrame = 3;
			mountData.yOffset = 20;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 6;
			mountData.standingFrameDelay = 8;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 6;
			mountData.runningFrameDelay = 8;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 6;
			mountData.flyingFrameDelay = 10;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 6;
			mountData.inAirFrameDelay = 10;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 6;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				mountData.textureWidth = mountData.backTexture.Width + 20;
				mountData.textureHeight = mountData.backTexture.Height;
			}
		}
	}
}