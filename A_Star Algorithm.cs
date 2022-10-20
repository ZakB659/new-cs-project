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
    class A_Star_Algorithm
    {
        private int hScore;
        private int gScore;
        private int fScore;
        private int CostofMove;
        private Vector2 Location;
        private Vector2 End_Location;
        

        public List<Rectangle> Obstacle_Hitboxes { get => Obstacle_Hitboxes; set => Obstacle_Hitboxes = value; }

        public A_Star_Algorithm(Vector2 location,Vector2 Endlocation)
        {
            Location = location;
            End_Location = Endlocation;
        }

        public void Calculate_Route()
        {

        }             

        public void calculatingcost()
        {
        
        }

    }
}
