using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace topic2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectangleTexture;
        Texture2D rectangleTexture2;
        Rectangle rectangleRect;
        Rectangle rectangleRect2;
        Rectangle rectangleRect3;
        Rectangle rectangleRect4;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            rectangleRect = new Rectangle(250, 75, 300, 300);
            rectangleRect2 = new Rectangle(450, 125, 50, 50);
            rectangleRect3 = new Rectangle(300, 125, 50, 50);
            rectangleRect4 = new Rectangle(300, 275, 205, 50);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("blueoutfriday");
            rectangleTexture2 = Content.Load<Texture2D>("black");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            _spriteBatch.Begin();
            _spriteBatch.Draw(rectangleTexture, rectangleRect, Color.White);
            _spriteBatch.Draw(rectangleTexture2, rectangleRect2, Color.White);
            _spriteBatch.Draw(rectangleTexture2, rectangleRect3, Color.White);
            _spriteBatch.Draw(rectangleTexture2, rectangleRect4, Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}