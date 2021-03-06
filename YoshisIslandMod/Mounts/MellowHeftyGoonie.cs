using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts
{
	public class MellowHeftyGoonie : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = 1;
			mountData.buff = mod.BuffType("MellowHeftyGoonie");
			mountData.heightBoost = 30;
			mountData.fallDamage = 5f;
			mountData.usesHover = true;
			mountData.runSpeed = 10f;
			mountData.dashSpeed = 10f;
			mountData.flightTimeMax = 180;
			mountData.fatigueMax = 180;
			mountData.jumpHeight = 6;
			mountData.acceleration = 0.18f;
			mountData.jumpSpeed = 5f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 10;
			mountData.constantJump = true;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 12;
			mountData.bodyFrame = 3;
			mountData.yOffset = 11;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 10;
			mountData.standingFrameDelay = 5;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 10;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 10;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 1;
			mountData.inAirFrameCount = 10;
			mountData.inAirFrameDelay = 0;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 10;
			mountData.idleFrameDelay = 0;
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