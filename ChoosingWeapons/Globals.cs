using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingWeapons
{
    internal class Globals
    {
        public static int WIDTH = 1920;
        public static int HEIGHT = 1080;
        public static bool isFullScreen = true;
        public static bool isMouseVisible = false;
        public static Color BGCOLOR = Color.Black;

        public static KeyboardState kstate;
        public static void setKstate(KeyboardState state){ kstate = state; }

        public static int Time;
        public static void setTime(GameTime gt) { Time = (int)gt.ElapsedGameTime.TotalSeconds; }

        public static SpriteBatch sb;
        public static ContentManager Content;
    }
}
