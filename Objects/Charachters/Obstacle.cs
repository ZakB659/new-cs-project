using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computer_Science_end_project
{
    class Obstacle : Charachter
    {       
        public Obstacle(int heightConstant, int WidthConstant,int x,int y)
        {
            Location = new Vector2(x, y);

            _HitBox = new Rectangle((int)Location.X, (int)Location.Y, WidthConstant/2, heightConstant);
        }

        public override void loadcontent(ContentManager content, string name)
        {
            _Texture = content.Load<Texture2D>(@name);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_Texture, Location, Color.White);
        }
    }
}
