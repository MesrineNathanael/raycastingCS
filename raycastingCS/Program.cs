using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace raycastingCS
{
    class Program
    {
        static Form1 screen;
        static int fps = 0;
        static int time = 0;
        static int pause = 5;
        static void Main()
        {
            Point p;
            
            screen = new Form1();
            screen.Show();
            
            Graphics draw = screen.CreateGraphics();
            SolidBrush bWhite = new SolidBrush(Color.White);
            SolidBrush bBlack = new SolidBrush(Color.Black);
            Rectangle rec = new Rectangle(0, 0, 1280, 720);
            
            while (true)
            {
                fps++;
                time += pause;
                p = new Point(Cursor.Position.X, Cursor.Position.Y);



                RectangleF recf = new RectangleF(p, new SizeF(20, 20));
                
                Rectangle roundedRectangle = Rectangle.Round(recf);
                draw.FillEllipse(bWhite, roundedRectangle);
                
                for (int i = 0; i <= 72; i++)
                {
                    Ray reu = new Ray(p, 1, 1280);
                    reu.RotateRectangle(draw, i*5);
                    draw.FillRectangle(bWhite, reu.getRay());

                    screen.Text = "fps : " + reu.getRay().Location.X.ToString(); ;
                }



                if (time >= 1000)
                {
                    
                    //screen.Text = "fps : " + fps.ToString();
                    fps = 0;
                    time = 0;
                }
                Thread.Sleep(pause);
                draw.FillRectangle(bBlack, rec);
            }

        }
    }
}
