using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class MyRectangle:Figure
    {
        int[] points;

        public MyRectangle(int[] points)
        {
            this.points = points;
        }

        public override void Draw(Graphics gr) {
            //points[0] = PointStart.X;
            //points[1] = PointStart.Y;
            //points[2] = PointEnd.X;
            //points[3] = PointEnd.Y;
            Rectangle rectangle = new Rectangle();
            rectangle.X = Math.Min(points[0], points[2]);
            rectangle.Y = Math.Min(points[1], points[3]);
            rectangle.Height = Math.Abs(points[1] - points[3]);
            rectangle.Width = Math.Abs(points[0] - points[2]);
            

            gr.DrawRectangle(new Pen(Color.Black),rectangle );
            
            
        }
    }
}
