using ReLogic.OS;
using Terraria;
using Terraria.ModLoader;

namespace AutoSeedCopy
{
    public class AutoSeedCopyWorldGen : ModSystem
    {
        public override void PreWorldGen()
        {
            int worldSize = GetWorldSizeID(Main.maxTilesX, Main.maxTilesY);
            int evilType = WorldGen.WorldGenParam_Evil + 1;
            int gameMode = Main.GameMode + 1;
            int seed = WorldGen._lastSeed;
            string fullSeedsText = $"{worldSize}.{gameMode}.{evilType}.{seed}";
            Platform.Get<IClipboard>().Value = fullSeedsText;
        }

        private static int GetWorldSizeID(in int worldSizeX, in int worldSizeY)
        {
            if (worldSizeX == 4200 && worldSizeY == 1200)
            {
                return 1;
            }
            if (worldSizeX == 6400 && worldSizeY == 1800)
            {
                return 2;
            }
            if (worldSizeX == 8400 && worldSizeY == 2400)
            {
                return 3;
            }
            return 0;
        }
    }
}
