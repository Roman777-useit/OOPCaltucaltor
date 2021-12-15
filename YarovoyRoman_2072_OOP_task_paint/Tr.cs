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

        public Tr(int PointStartX, int PointEndX, int PointStartY, int PointEndY)
        {
            point.PointStartX = PointStartX;
            point.PointEndX = PointEndX;
            point.PointStartY = PointStartY;
            point.PointEndY = PointEndY;


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
        public override Figure Move(int pointX, int pointEndX, int pointY, int pointEndY)
        {
            int deltaX = Math.Abs(pointX - point.PointEndX);
            int deltaY = Math.Abs(pointY - point.PointEndY);
            Figure figure = new Tr( pointX,  pointEndX,  pointY,  pointEndY);
            return figure;


        }
    }
}
