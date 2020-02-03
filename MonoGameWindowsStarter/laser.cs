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
    public class Laser
    {
        Player player;
        BoundingRectangle bounds;
        Texture2D texture;

        /// <summary>
        /// Creates a paddle
        /// </summary>
        /// <param name="game">The game this paddle belongs to</param>
        public Laser(Player player)
        {
            this.player = player;
        }

        public void LoadContent(ContentManager content, int x, int y)
        {
            texture = content.Load<Texture2D>("pixel");
            bounds.Width = 30;
            bounds.Height = 20;
            bounds.X = x;
            bounds.Y = y;
        }
    }
}
