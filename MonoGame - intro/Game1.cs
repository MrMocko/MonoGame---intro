using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.CompilerServices;

namespace MonoGame___intro
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D backroundTexture;
        Texture2D godzillatexture;
        Texture2D skullTexture;
        Texture2D mechaGodzillaTexture;
        Texture2D sparksp3Texture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            this.Window.Title = "Jimmy";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            backroundTexture = Content.Load<Texture2D>("backround");
            skullTexture = Content.Load<Texture2D>("skull");
            mechaGodzillaTexture = Content.Load<Texture2D>("mecha godzilla");
            godzillatexture = Content.Load<Texture2D>("godzilla");
            sparksp3Texture = Content.Load<Texture2D>("sparksp3");
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
            GraphicsDevice.Clear(Color.MediumPurple);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backroundTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(mechaGodzillaTexture, new Vector2(250, 350), Color.White);
            _spriteBatch.Draw(godzillatexture, new Vector2(-50, 250), Color.AliceBlue);
            _spriteBatch.Draw(skullTexture, new Vector2(550, 300), Color.White);
            Random generator = new Random();
            _spriteBatch.Draw(sparksp3Texture, new Vector2(Generator.next285, 165), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
