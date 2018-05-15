using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts.ClownCopters
{
	public class OrangeBabyClownCopter : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 102;
			mountData.buff = mod.BuffType("OrangeBabyClownCopter");
			mountData.heightBoost = 20;
			mountData.flightTimeMax = 100;
			mountData.fatigueMax = 100;
			mountData.fallDamage = 30f;
			mountData.usesHover = false;
			mountData.runSpeed = 30f;
			mountData.dashSpeed = 30f;
			mountData.acceleration = 0.16f;
			mountData.jumpHeight = 16;
			mountData.jumpSpeed = 6f;
			mountData.blockExtraJumps = false;
			mountData.constantJump = true;
			mountData.totalFrames = 6;
			int[] array = new int[mountData.totalFrames];
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				array[num2] = 16;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 10;
			mountData.bodyFrame = 3;
			mountData.yOffset = 12;
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