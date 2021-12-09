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
        MyRectangle myRectangle1;
        MyCircle myCircle1;
        MyCircle myCircle2;
        Points point;
   
        public Wagon(Points point)
        {
            this.point = point;
            

        }

        public override void Draw(Graphics gr )
        {
            int width = point.PointEndX - point.PointStartX;
            int height = point.PointEndY - point.PointStartY;
            myRectangle1 = new MyRectangle(point);
            point.PointStartY = point.PointEndY;
            point.PointEndY = point.PointEndY + height;
            myCircle1 = new MyCircle(point);
            point.PointStartX = point.PointStartX + (width / 2);
            point.PointEndX = point.PointStartX + width;
            myCircle2 = new MyCircle(point);
            myRectangle1.Draw(gr);
            myCircle1.Draw(gr);
            myCircle2.Draw(gr);
          
            



        }
        public override void Move(Graphics gr, int pointX, int pointY)
        {

            int width = point.PointEndX - point.PointStartX;
            int height = point.PointEndY - point.PointStartY;
            point.PointStartX = pointX;
            point.PointStartY = pointY;
            point.PointEndX = point.PointStartX + width;
            point.PointEndY = point.PointStartY + height;
            myRectangle1 = new MyRectangle(point);
            point.PointStartY = point.PointEndY;
            point.PointEndY = point.PointEndY + height;
            myCircle1 = new MyCircle(point);
            point.PointStartX = point.PointStartX + (width / 2);
            point.PointEndX = point.PointStartX + width;
            myCircle2 = new MyCircle(point);
            myRectangle1.Draw(gr);
            myCircle1.Draw(gr);
            myCircle2.Draw(gr);

        }

    }
}
