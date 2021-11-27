using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class WagonCoal:Wagon
    {
        int[] points;


        public WagonCoal(int[] points):base(points)
        {
            this.points = points;
            
        }

        public override void Draw(Graphics gr)
        {
            //points[0] = PointStart.X;
            //points[1] = PointStart.Y;
            //points[2] = PointEnd.X;
            //points[3] = PointEnd.Y;
            base.Draw(gr);
            Rectangle rectangle = new Rectangle();
            rectangle.X = Math.Min(points[0], points[2]);
            rectangle.Y = Math.Min(points[1], points[3]);
            rectangle.Height = Math.Abs(points[1] - points[3]);
            rectangle.Width = Math.Abs(points[0] - points[2]);
            PointF[] point = { new Point(points[0], points[1]), new Point(points[0] + rectangle.Width / 2, points[1] - 50), new Point(points[2], points[1]) };
            gr.DrawPolygon(new Pen(Color.DarkGoldenrod),point);

            
        }
    }
}
