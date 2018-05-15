using Terraria.ModLoader;

namespace YoshisIslandMod
{
	class YoshisIslandMod : Mod
	{
		public YoshisIslandMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
