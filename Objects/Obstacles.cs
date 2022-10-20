using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.IO;

namespace Computer_Science_end_project
{
    class Obstacles
    {
        private List<Obstacle> obstacle_Hitboxes;
        private int WindowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        private int WindowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        private int Height_constant = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 80;
        private int Width_constant = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 64;
        

        public Obstacles()
        {
            obstacle_Hitboxes = new List<Obstacle>();
        }

        public List<Obstacle> Obstacle_Hitboxes { get => obstacle_Hitboxes; set => obstacle_Hitboxes = value; }

        public void load_obstacles()
        {
            StreamReader streamreader = new StreamReader(@"Binary Obstacle File.txt");
            string temp = streamreader.ReadToEnd();

            int u = 0;

            foreach(string Temp in temp.Split("\n"))
            {
                for (int i = 0; i < Temp.Length; i++)
                {
                    if (Temp[i] =='1')
                    {
                        Obstacle_Hitboxes.Add(new Obstacle(Height_constant, Width_constant, (u*Width_constant) + (WindowWidth/10), (i*Height_constant)+(WindowHeight/12)));
                    }
                }
                u++;
            }
        
            streamreader.Close();          
        }
    }
}
