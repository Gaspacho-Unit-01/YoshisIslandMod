using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts.ClownCopters
{
	public class PinkBabyClownCopter : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 46;
			mountData.buff = mod.BuffType("PinkClownCopter");
			mountData.heightBoost = 30;
			mountData.fallDamage = 0f;
			mountData.usesHover = true;
			mountData.runSpeed = 10f;
			mountData.dashSpeed = 8f;
			mountData.flightTimeMax = 300000;
			mountData.fatigueMax = 300000;
			mountData.jumpHeight = 5;
			mountData.acceleration = 0.50f;
			mountData.jumpSpeed = 4f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 6;
			mountData.constantJump = false;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 14;
			mountData.bodyFrame = 3;
			mountData.yOffset = 15;
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
				mountData.textureWidth = mountData.backTexture.Width + 30;
				mountData.textureHeight = mountData.backTexture.Height;

			}
		}
	}
}