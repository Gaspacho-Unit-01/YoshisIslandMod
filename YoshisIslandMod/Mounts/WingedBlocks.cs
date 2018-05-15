using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts
{
	public class WingedBlocks : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 2;
			mountData.buff = mod.BuffType("WingedBlocks");
			mountData.heightBoost = 40;
			mountData.flightTimeMax = 1000;
			mountData.fatigueMax = 999999;
			mountData.fallDamage = 0f;
			mountData.usesHover = true;
			mountData.runSpeed = 5f;
			mountData.dashSpeed = 5f;
			mountData.acceleration = 5f;
			mountData.jumpHeight = 3;
			mountData.jumpSpeed = 4f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 4;
			int[] array = new int[mountData.totalFrames];
			for (int num2 = 0; num2 < array.Length; num2++)
			{
				array[num2] = 16;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 10;
			mountData.bodyFrame = 1;
			mountData.yOffset = 17;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 4;
			mountData.standingFrameDelay = 8;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 4;
			mountData.runningFrameDelay = 8;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 4;
			mountData.flyingFrameDelay = 10;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 4;
			mountData.inAirFrameDelay = 10;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 4;
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