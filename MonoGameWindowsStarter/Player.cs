using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGameWindowsStarter
{
    public class Player
    {
        Game1 game;

        BoundingRectangle bounds;

        Texture2D texture;

        /// <summary>
        /// Creates a paddle
        /// </summary>
        /// <param name="game">The game this paddle belongs to</param>
        public Player(Game1 game)
        {
            this.game = game;
        }

        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("PixelCharacter");
            bounds.Width = 50;
            bounds.Height = 100;
            bounds.X = 0;
            bounds.Y = game.GraphicsDevice.Viewport.Height;
        }

        public void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                // move up
                bounds.X -= (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }


            if (keyboardState.IsKeyDown(Keys.Right))
            {
                // move down
                bounds.X += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }

           
           if (bounds.Y > game.GraphicsDevice.Viewport.Height - bounds.Height)
            {
                bounds.Y = game.GraphicsDevice.Viewport.Height - bounds.Height;
            }

            if (bounds.X < 0)
            {
                bounds.X = 0;
            }
            if (bounds.X > game.GraphicsDevice.Viewport.Width - bounds.Width)
            {
                bounds.X = game.GraphicsDevice.Viewport.Width - bounds.Width;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, bounds, Color.AntiqueWhite);
        }
    }
}