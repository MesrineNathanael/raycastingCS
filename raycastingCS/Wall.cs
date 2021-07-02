using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raycastingCS
{
    class Wall
    {
        Rectangle wall;
        public Wall(Point p, int width, int heigth)
        {
            wall = new Rectangle(p.X + 10, p.Y + 10, width, heigth);
        }
        public Rectangle getWall()
        {
            return this.wall;
        }
        
    }
}
