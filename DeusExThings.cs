using Terraria.ModLoader;



namespace DeusExThings
{
	class DeusExThings : Mod
    {
        public DeusExThings()
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
