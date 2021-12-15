using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace task_paint
{
    class MyCircle : Figure
    {

        Points point;


        public MyCircle(int PointStartX, int PointEndX, int PointStartY, int PointEndY)
        {
            point.PointStartX = PointStartX;
            point.PointEndX = PointEndX;
            point.PointStartY = PointStartY;
            point.PointEndY = PointEndY;


        }

        public override void Draw(Graphics gr) {
        x = point.PointStartX;
        y = point.PointStartY;
        Rectangle rectangle = new Rectangle();
        rectangle.X = Math.Min(x, point.PointEndX);
        rectangle.Y = Math.Min(y, point.PointEndY);
        rectangle.Height = Math.Abs(y - point.PointEndY)/2;
        rectangle.Width = Math.Abs(x - point.PointEndX)/2;


        gr.DrawEllipse(new Pen(Color.Black,5), rectangle);
            
           
        }
        public override Figure Move(int pointX, int pointY,int pointEndX, int pointEndY)
        {
            int deltaX = Math.Abs(pointX - point.PointEndX);
            int deltaY = Math.Abs(pointY - point.PointEndY);
            Figure figure = new MyCircle( pointX,  pointY,  pointEndX,  pointEndY);
            return figure;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new MyCircle(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);

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
