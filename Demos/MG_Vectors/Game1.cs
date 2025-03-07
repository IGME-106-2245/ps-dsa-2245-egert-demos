using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MG_Vectors
{
    public class Game1 : Game
    {
        // MG fields
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // General Info
        private const int Width = 1000;
        private const int Height = 500;

        // Ship Info
        private Texture2D shipImg;
        private Vector2 shipLoc;
        private Vector2 shipDirection;
        private float speed;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = Width;  // set this value to the desired width of your window
            _graphics.PreferredBackBufferHeight = Height;   // set this value to the desired height of your window
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            // Get the ship and setup initial location, etc.
            shipImg = Content.Load<Texture2D>("ship");
            shipLoc = new Vector2(0, Height/4 - shipImg.Height/2);
            speed = 2f;
            shipDirection = new Vector2(1, 0);
            //shipDirection.Normalize();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            // Velocity == speed * direction
            // new loc == curr loc + velocity
            shipLoc += shipDirection * speed;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(shipImg, shipLoc, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}