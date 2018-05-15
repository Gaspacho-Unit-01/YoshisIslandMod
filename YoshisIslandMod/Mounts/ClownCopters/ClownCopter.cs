using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts.ClownCopters
{
	public class ClownCopter : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 46;
			mountData.buff = mod.BuffType("ClownCopter");
			mountData.heightBoost = 35;
			mountData.fallDamage = 0f;
			mountData.usesHover = true;
			mountData.runSpeed = 8f;
			mountData.dashSpeed = 6f;
			mountData.flightTimeMax = 2000;
			mountData.fatigueMax = 9999999;
			mountData.jumpHeight = 6;
			mountData.acceleration = 5f;
			mountData.jumpSpeed = 5f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 15;
			mountData.constantJump = false;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 17;
			mountData.bodyFrame = 3;
			mountData.yOffset = 18;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 15;
			mountData.standingFrameDelay = 2;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 15;
			mountData.runningFrameDelay = 2;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 15;
			mountData.flyingFrameDelay = 2;
			mountData.flyingFrameStart = 1;
			mountData.inAirFrameCount = 15;
			mountData.inAirFrameDelay = 2;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 15;
			mountData.idleFrameDelay = 2;
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