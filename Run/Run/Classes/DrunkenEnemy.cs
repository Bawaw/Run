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
    class DrunkenEnemy :Enemy
    {
        private const float drunkness = 3f;
        private const float amplitude = 0.5f;
        Random random;

        public DrunkenEnemy(Texture2D texture, Actor target, float speed) : base(texture, target, speed) { random = new Random(); }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            Vector2 offset = Vector2.Zero;

            //offset.X = (float)Math.Sin(random.Next(0,1000) * drunkness) * amplitude;
            //offset.Y = (float)Math.Cos(random.Next(0,1000) *drunkness) * amplitude;

            offset.X = (float)Math.Sin(gameTime.TotalGameTime.TotalSeconds * drunkness) * amplitude;
            offset.Y = (float)Math.Cos(gameTime.TotalGameTime.TotalSeconds * drunkness) * amplitude;
            this.position += offset;

        }
    }
}
