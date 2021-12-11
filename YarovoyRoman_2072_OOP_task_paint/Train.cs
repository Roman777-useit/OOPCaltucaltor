using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class Train:Figure
    {
        Wagon wagon2;
        Wagon wagon3;
        Points point;
        public Train(Points point)
        {
            this.point = point;
            
        }
        public override void Draw(Graphics gr)
        {
            int width = point.PointEndX - point.PointStartX;
            int height = point.PointEndY - point.PointStartY;
            point.PointStartX = point.PointEndX;
            point.PointEndX = point.PointStartX + width;
            wagon2 = new Wagon(point);
            point.PointStartX = point.PointEndX;
            point.PointEndX = point.PointStartX + width;
            wagon3 = new Wagon(point);
            base.Draw(gr);
            wagon2.Draw(gr);
            wagon3.Draw(gr);
        }
        public override void Move(int pointX, int pointY)
        {
            point.PointStartX = pointX;
            point.PointStartY = pointY;

        }
    }
}
