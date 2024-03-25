using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingWeapons
{
    internal class Player
    {
        int x;
        int y;
        public Texture2D texture;
        public Rectangle rect;
        int offset = 350;
        public Player(Texture2D texture = null)
        {
            Entities.PlayerCounter++;

            this.texture = texture == null ? Textures.gunTextures["Rifle"] : texture;
            x = Entities.PlayerCounter * offset;
            y = Globals.HEIGHT - this.texture.Height - 100;
            rect = new Rectangle(x, y, this.texture.Width, this.texture.Height);
        }
        public void SetTexture(Texture2D texture)
        {
            this.texture = texture;
            y = Globals.HEIGHT - this.texture.Height - 100;
            rect = new Rectangle(x, y, this.texture.Width, this.texture.Height);
        }
        public void Draw()
        {
            Globals.sb.Draw(texture, rect, Color.White);
        }
    }
}
