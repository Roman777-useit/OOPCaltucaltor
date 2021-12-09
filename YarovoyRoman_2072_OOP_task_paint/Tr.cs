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
                new System.Drawing.Point(x, y), new System.Drawing.Point(x + (point.PointEndX - y) / 2, y - 50), new System.Drawing.Point(point.PointEndX, y) 
            };
            gr.DrawPolygon(new Pen(Color.DarkGoldenrod), point1);


        }
        public override void Move(Graphics gr, int pointX, int pointY)
        {
            int height = Math.Abs(point.PointEndY - point.PointStartY);
            int width = Math.Abs(point.PointEndX - point.PointStartX);
            x = pointX;
            y = pointY;

            PointF[] point1 = {
                new System.Drawing.Point(x, y), new System.Drawing.Point(x + width / 2, y - 50), new System.Drawing.Point(x+width, y)
            };
            gr.DrawPolygon(new Pen(Color.DarkGoldenrod), point1);
        }
    }
}
