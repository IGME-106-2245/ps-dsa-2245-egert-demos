using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HungryDog
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D crabAsset;
        private Rectangle crabRect;

        private Texture2D dogAsset;
        private Rectangle dogRect;

        private Vector2 dogDir = Vector2.Zero;
        private float dogSpeed = 250; // pixels per second

        private SpriteFont defaultFont;
        private SpriteFont titleFont;

        private Vector2 titleLoc = Vector2.Zero;
        private Vector2 infoLoc;

        private KeyboardState prevKBState;


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

            // TODO: use this.Content to load your game content here

            dogAsset = Content.Load<Texture2D>("dog");
            dogRect = new Rectangle(400, 0, dogAsset.Width/4, dogAsset.Height/4);

            crabAsset = Content.Load<Texture2D>("Crab");
            crabRect = new Rectangle(0, 250, crabAsset.Width/4, crabAsset.Height/4);

            defaultFont = Content.Load<SpriteFont>("defaultFont");
            titleFont = Content.Load<SpriteFont>("titleFont");

            float titleHeight = titleFont.MeasureString("??").Y;
            infoLoc = new Vector2(0, 1 + titleHeight);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed 
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            // TODO: Add your update logic here
            KeyboardState currKBState = Keyboard.GetState();

            // increase speed with space bar
            // is it up now but was down last frame
            if (currKBState.IsKeyUp(Keys.Space) && prevKBState.IsKeyDown(Keys.Space))
            {
                dogSpeed += 50;
            }


            // Start with direction 0
            dogDir = Vector2.Zero;

            // Change based on key presses

            if (currKBState.IsKeyDown(Keys.W))
            {
                dogDir.Y--;
            }
            if (currKBState.IsKeyDown(Keys.A))
            {
                dogDir.X--;
            }

            if (currKBState.IsKeyDown(Keys.S))
            {
                dogDir.Y++;
            }

            if (currKBState.IsKeyDown(Keys.D))
            {
                dogDir.X++;
            }

            if (dogDir != Vector2.Zero)
            {
                dogDir.Normalize();
            }

            // calc velocity
            Vector2 velocity = dogDir * dogSpeed;

            // dist travel == vel * time
            Vector2 distTraveled = velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

            dogRect.X += (int)distTraveled.X;
            dogRect.Y += (int)distTraveled.Y;

            prevKBState = currKBState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(dogAsset, dogRect, Color.White);
            _spriteBatch.Draw(crabAsset, crabRect, Color.White);

            _spriteBatch.DrawString(titleFont, "HELLO", titleLoc, Color.Black);
            _spriteBatch.DrawString(defaultFont, dogDir.X + ", " + dogDir.Y+" - "+dogSpeed, 
                infoLoc, Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
