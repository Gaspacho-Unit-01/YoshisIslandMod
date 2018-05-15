using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace YoshisIslandMod
{
    public class YoshiPlayer : ModPlayer
    {
        public bool examplePet = false;
        public bool exampleLightPet = false;

        public override void ResetEffects()
        {
            examplePet = false;
            exampleLightPet = false;
        }
    }
}