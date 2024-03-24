using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ChoosingWeapons
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = Globals.isMouseVisible;
            _graphics.PreferredBackBufferWidth = Globals.WIDTH;
            _graphics.PreferredBackBufferHeight = Globals.HEIGHT;
            _graphics.IsFullScreen = Globals.isFullScreen;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.sb = new SpriteBatch(GraphicsDevice);
            Globals.Content = Content;

            Textures.addGunTexture("Pistol", "Rifle", "Sniper", "Knife");
            Player p = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            Player p4 = new Player();
            Entities.AddPlayer(p, p2, p3, p4);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            Globals.setKstate(Keyboard.GetState());
            Globals.setTime(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Globals.BGCOLOR);

            Globals.sb.Begin();

            Entities.DrawPlayers();

            Globals.sb.End();

            base.Draw(gameTime);
        }
    }
}