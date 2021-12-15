using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class Wagon:Figure
    {
        Figure myRectangle1;
        Figure myCircle1;
        Figure myCircle2;
        Points point;

        public Wagon(int PointStartX, int PointEndX, int PointStartY, int PointEndY)
        {
            point.PointStartX = PointStartX;
            point.PointEndX = PointEndX;
            point.PointStartY = PointStartY;
            point.PointEndY = PointEndY;


        }

        public override void Draw(Graphics gr )
        {
            int width = Math.Abs(point.PointStartX - point.PointEndX);
            int height = Math.Abs(point.PointStartY - point.PointEndY);
            myRectangle1 = new MyRectangle( point.PointStartX,  point.PointEndX,  point.PointStartY+height*1/3, point.PointEndY-height*1/3);
            myCircle1 = new MyCircle(point.PointStartX, point.PointEndX, point.PointStartY+height*2/3, point.PointEndY) ;
            myCircle2 = new MyCircle(point.PointStartX+width/2, point.PointEndX+width/2, point.PointStartY + height*2/3, point.PointEndY);
            myRectangle1.Draw(gr);
            myCircle1.Draw(gr);
            myCircle2.Draw(gr);





        }
        public override Figure Move(int pointX, int pointEndX, int pointY, int pointEndY)
        {

            int deltaX = Math.Abs(pointX - point.PointEndX);
            int deltaY = Math.Abs(pointY - point.PointEndY);
            Figure figure = new Wagon( pointX,  pointEndX,  pointY,  pointEndY);
            return figure;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new Wagon(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);

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
