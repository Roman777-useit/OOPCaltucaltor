using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class Train:Wagon
    {
        Wagon wagon2;
        Wagon wagon3;
        Points point;
        public Train(Points point):base(point)
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
        public override void Move(Graphics gr, int pointX, int pointY)
        {

            int width = point.PointEndX - point.PointStartX;
            int height = point.PointEndY - point.PointStartY;
            point.PointStartX = point.PointStartX+width;
            point.PointEndX = point.PointStartX + 2*width;
            wagon2 = new Wagon(point);
            point.PointStartX = point.PointStartX + 2 * width;
            point.PointEndX = point.PointStartX + 3*width;
            wagon3 = new Wagon(point);
            base.Draw(gr);
            wagon2.Draw(gr);
            wagon3.Draw(gr);

        }
    }
}
