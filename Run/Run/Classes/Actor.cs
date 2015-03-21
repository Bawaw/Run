using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Run
{
    class Actor
    {
        public static List<Actor> Actors;

        protected Texture2D texture;
        protected Vector2 position;

        public Vector2 Position 
        {
            get{ return position; } 
            set{ position = value; } 
        }

        static Actor()
        { 
            Actors = new List<Actor>();
        }

        public Actor(Texture2D texture)
        {
            this.texture = texture;
            Actors.Add(this);
        }

        public virtual void Update(GameTime gameTime) {}

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, position, Color.White);
        }

    }
}
