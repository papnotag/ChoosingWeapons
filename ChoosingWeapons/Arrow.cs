using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingWeapons
{
    internal class Arrow
    {
        int x, y;
        Rectangle rect;
        Texture2D texture;

        int currentPlayer;
        int currentTextureID;

        int LastChangedTime;


        public Arrow(int playerIndex)
        {
            Player player = Entities.Players[playerIndex];
            currentPlayer = playerIndex;

            updatePosition();
        }
        public void Update()
        {
            HandleChange();
        }
        public void Draw()
        {
            Globals.sb.Draw(texture, rect, Color.White);
        }
        public void HandleChange()
        {
            KeyboardState ks = Globals.kstate;
            if ((int)Globals.gameTime.TotalGameTime.TotalMilliseconds - LastChangedTime < 100) return;

            if (ks.IsKeyDown(Keys.Right)) moveRight();
            if (ks.IsKeyDown(Keys.Left)) moveLeft();

            currentTextureID = Textures.gunTextureFinder[Entities.Players[currentPlayer].texture.Name];

            if (ks.IsKeyDown(Keys.Up)) changeTextureUp();
            if (ks.IsKeyDown(Keys.Down)) changeTextureDown();

            Entities.Players[currentPlayer].SetTexture(Textures.gunTextures[Textures.gunTextureFinderByInt[currentTextureID]]);

            updatePosition();
            LastChangedTime = (int)Globals.gameTime.TotalGameTime.TotalMilliseconds;
        }
        private void moveRight()
        {
            int max = Entities.Players.Count;
            currentPlayer++;
            if (currentPlayer >= max) currentPlayer = 0;
        }
        private void moveLeft()
        {
            currentPlayer--;
            if (currentPlayer < 0) currentPlayer = Entities.Players.Count - 1;
        }
        private void updatePosition()
        {
            Player player = Entities.Players[currentPlayer];

            this.texture = Textures.otherTextures["Arrow"];
            x = player.rect.Center.X - (texture.Width / 2);
            y = player.rect.Y - 100;
            rect = new Rectangle(x, y, texture.Width, texture.Height);
        }

        private void changeTextureUp()
        {
            int max = Textures.gunTextureCount-1;
            currentTextureID++;
            if(currentTextureID >= max) currentTextureID = 0;
        }
        private void changeTextureDown()
        {
            int max = Textures.gunTextureCount - 1;
            currentTextureID--;
            if(currentTextureID < 0) currentTextureID = max;
        }
    }
}
