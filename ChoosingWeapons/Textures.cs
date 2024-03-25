using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingWeapons
{
    internal class Textures
    {
        public static Dictionary<string, int> gunTextureFinder = new Dictionary<string, int>();
        public static Dictionary<int, string> gunTextureFinderByInt = new Dictionary<int, string>();
        public static int gunTextureCount = 0;

        public static Dictionary<string, Texture2D> gunTextures = new Dictionary<string, Texture2D>();
        public static void LoadGunTexture(params string[] texture)
        {
            for (int i = 0; i < texture.Length; i++)
            {
                gunTextures.Add(texture[i], Globals.Content.Load<Texture2D>(texture[i]));
                gunTextureFinder.Add(texture[i], gunTextureCount);
                gunTextureFinderByInt.Add(gunTextureCount, texture[i]);
                gunTextureCount++;
            }
        }

        public static Dictionary<string, Texture2D> otherTextures = new Dictionary<string, Texture2D>();
        public static void LoadOtherTexture(params string[] texture)
        {
            for (int i = 0; i < texture.Length; i++) otherTextures.Add(texture[i], Globals.Content.Load<Texture2D>(texture[i]));
        }
    }
}
