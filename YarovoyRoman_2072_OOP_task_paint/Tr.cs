using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class Tr:Figure
    {
        Points point;

        public Tr(Points point)
        {
            this.point = point;
        }

        public override void Draw(Graphics gr)
        {
            x = point.PointStartX;
            y = point.PointStartY;
            
            PointF[] point1 = { 
                new System.Drawing.Point(x, y), new System.Drawing.Point(x + (point.PointEndX - x) / 2, y - 50), new System.Drawing.Point(point.PointEndX, y) 
            };
            gr.DrawPolygon(new Pen(Color.DarkGoldenrod), point1);


        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;


        }
    }
}
