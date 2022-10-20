using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Computer_Science_end_project
{
    class Projectile : Charachter
    {
        private Vector2 movement;       
        private bool isremoved;
        private int damage;
 
        public Vector2 Movement { get => movement; set => movement = value; }
        public bool Isremoved { get => isremoved; set => isremoved = value; }
       
        public Projectile(Player player, Vector2 Movement)
        {
            Vector2 positionsetter = new Vector2(player.Location.X + 16, player.Location.Y + 16);            
            Location = positionsetter;
            movement = Movement;
            damage = 50;
        }

        public override void loadcontent(ContentManager content, string name)
        {
            _Texture = content.Load<Texture2D>(@name);
        }

        public void update(GameTime gameTime)
        {
            _HitBox = new Rectangle((int)Location.X, (int)Location.Y, 16, 16);
            Location = Location + movement * 5;
        }

        public void Collisions(Enemies enemies)
        {
            foreach (Enemy enemy in enemies._Enemies)
            {
                if (_HitBox.Intersects(enemy._HitBox))
                {
                    enemy.Health = enemy.Health - damage;
                }
            }
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            if (Location.X < 2*WindowWidthdiv3 && Location.X > 0 && Location.Y < WindowHeight && Location.Y > 0)
            {
                spriteBatch.Draw(_Texture, Location, new Rectangle(0, 0, 100, 100), Color.White, 0, new Vector2(0, 0), 1, SpriteEffects.None, 0);
            }
            else
            {
                Isremoved = true;
            }

        }


    }
}