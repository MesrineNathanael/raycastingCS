using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raycastingCS
{
    class Ray
    {
        Rectangle tray;
        public Ray(Point p, int width, int heigth)
        {
             tray = new Rectangle(p.X + 10, p.Y + 10, width, heigth);
        }
        public void RotateRectangle(Graphics g, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(tray.Left,tray.Top));
                //g.DrawRectangle(Pens.White, tray);
                g.Transform = m;
            }
        }
        public Rectangle getRay()
        {
            return this.tray;
        }
        public void drw(Graphics g)
        {
            g.DrawRectangle(Pens.White, tray);
        }
    }
}
