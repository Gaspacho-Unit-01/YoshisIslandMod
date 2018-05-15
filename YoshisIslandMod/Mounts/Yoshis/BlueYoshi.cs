using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoshisIslandMod.Mounts.Yoshis // change to mod name
{
    

    public class BlueYoshi : ModMountData // change to file name
    {
        

        public override void SetDefaults()
        {
            mountData.spawnDust = DustID.Smoke;
            mountData.buff = mod.BuffType("BlueYoshiBuff"); //change to relevent name
            mountData.heightBoost = 19;          //how high is the mount from the ground
            mountData.fallDamage = 0f;
            mountData.runSpeed = 6f;
            mountData.dashSpeed = 9f;
            //mountData.abilityChargeMax = 40;
            //mountData.abilityCooldown = 20;
            //mountData.abilityDuration = 0;
            //mountData.flightTimeMax = 1;
            mountData.fatigueMax = 0;
            mountData.jumpHeight = 5;
            mountData.acceleration = 0.3f;
            mountData.jumpSpeed = 14f;
            mountData.blockExtraJumps = false;
            mountData.totalFrames = 30;            //mount frame/animation
            mountData.constantJump = true;
            int[] array = new int[mountData.totalFrames];
            for (int l = 0; l < array.Length; l++)
            {
                array[l] = 18;
            }
            array[1] = 16;
            array[2] = 16;
            array[3] = 16;
            array[4] = 16;
            array[5] = 16;
            array[6] = 16;

            mountData.playerYOffsets = array;
            mountData.xOffset = 15;
            mountData.yOffset = 1;          //how high is the mount from the player
            mountData.bodyFrame = 3;          //player frame when it's on the mount
            mountData.playerHeadOffset = 20;
            mountData.standingFrameCount = 7;
            mountData.standingFrameDelay = 8;
            mountData.standingFrameStart = 9;
            mountData.runningFrameCount = 6;
            mountData.runningFrameDelay = 10;
            mountData.runningFrameStart = 0;
            mountData.dashingFrameCount = 8;
            mountData.dashingFrameDelay = 25;
            mountData.dashingFrameStart = 22;
            mountData.flyingFrameCount = 1;
            mountData.flyingFrameDelay = 12;
            mountData.flyingFrameStart = 21;
            mountData.inAirFrameCount = 1;
            mountData.inAirFrameDelay = 12;
            mountData.inAirFrameStart = 20;
            mountData.idleFrameCount = 4;
            mountData.idleFrameDelay = 10;
            mountData.idleFrameStart = 16;
            mountData.idleFrameLoop = false;
            mountData.swimFrameCount = 8;
            mountData.swimFrameDelay = 25;
            mountData.swimFrameStart = 22;
            if (Main.netMode != 2)
            {
                mountData.textureWidth = mountData.frontTexture.Width;
                mountData.textureHeight = mountData.frontTexture.Height;
            }

        }


        public virtual bool UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
        {
            return true;
        }


        //public override void UpdateEffects(Player player)
        //{
        //    if (Math.Abs(player.velocity.X) > 4f)
        //    {
        //        Rectangle rect = player.getRect();
        //        Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, DustID.Confetti);
        //    }
        //}
    }
}