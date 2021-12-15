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
        Wagon wagon1;
        Wagon wagon2;
        Wagon wagon3;
        Points point;
        public Train(int PointStartX, int PointEndX, int PointStartY, int PointEndY)
        {
            point.PointStartX = PointStartX;
            point.PointEndX = PointEndX;
            point.PointStartY = PointStartY;
            point.PointEndY = PointEndY;


        }
        public override void Draw(Graphics gr)
        {
            int width = Math.Abs(point.PointEndX - point.PointStartX);
            int height = Math.Abs(point.PointEndY - point.PointStartY);
            wagon1= new Wagon(point.PointStartX, point.PointEndX-width*2/3, point.PointStartY, point.PointEndY);
            wagon2 = new Wagon(point.PointEndX-width*2/3, point.PointEndX - width*1/3, point.PointStartY, point.PointEndY);
            wagon3 = new Wagon(point.PointEndX-width*1/3, point.PointEndX, point.PointStartY, point.PointEndY);
            wagon1.Draw(gr);
            wagon2.Draw(gr);
            wagon3.Draw(gr);
        }
        public override Figure Move(int pointX, int pointEndX, int pointY, int pointEndY)
        {

            return new Train(pointX, pointEndX, pointY, pointEndY);

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new Train(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);

            if ((pointX <= point.PointEndX) && (pointX >= point.PointStartX) && ((pointY <= point.PointEndY) && (pointY >= point.PointStartY)))
            {
                IsPointsInside1 = true;
            }
            else
            {
                IsPointsInside1 = false;
            }
            if (IsPointsInside1 == true)
            {
                return figure;

            }
            else
            {
                return null;
            }




        }
    }
}
