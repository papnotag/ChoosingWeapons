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
        public static Dictionary<string, Texture2D> gunTextures = new Dictionary<string, Texture2D>();
        public static void addGunTexture(params string[] texture)
        {
            for(int i = 0; i < texture.Length; i++) gunTextures.Add(texture[i], Globals.Content.Load<Texture2D>(texture[i]));
        }
    }
}
