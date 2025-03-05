using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MG_First_Program
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D myDog;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // System.Diagnostics.Debug.WriteLine("Hello GDAPS2!");


            // TODO: use this.Content to load your game content here

            myDog = Content.Load<Texture2D>("dog");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //System.Diagnostics.Debug.WriteLine("Hello GDAPS2!");
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PaleVioletRed);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            // _spriteBatch.Draw(myDog, new Vector2(0,0), Color.White);
             _spriteBatch.Draw(myDog, new Rectangle(0,0,100,100), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
