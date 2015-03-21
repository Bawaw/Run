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
    class Enemy : Actor
    {
        private float speed;
        private Actor target;

        public Enemy(Texture2D texture, Actor target, float speed) : base(texture)
        {
            this.target = target;
            this.speed = speed;
        }

        public override void Update(GameTime gameTime)
        {
            if (target == null)
                return;
            Vector2 direction = Vector2.Normalize(target.Position - this.position);
            position += direction* speed;

        }
    }
}
