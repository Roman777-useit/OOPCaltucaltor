using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    class MyRectangle : Figure
    {


        
        Points point;
        public MyRectangle(int PointStartX, int PointEndX, int PointStartY, int PointEndY)
        {
          
            point.PointStartX = PointStartX;
            point.PointStartY = PointStartY;
            point.PointEndX = PointEndX;
            point.PointEndY = PointEndY;
        }
        public override void Draw(Graphics gr)
        {
            x = point.PointStartX;
            y = point.PointStartY;
            Rectangle rectangle = new Rectangle();
            rectangle.X = x;
            rectangle.Y =y;
            rectangle.Height = Math.Abs(point.PointStartY - point.PointEndY);
            rectangle.Width = Math.Abs(point.PointStartX - point.PointEndX);
            gr.DrawRectangle(new Pen(Color.Black, 5), rectangle);
        }
        public override Figure Move(int pointX, int pointEndX,int pointY,int pointEndY)
        {

            Figure figure = new MyRectangle( pointX,  pointEndX,  pointY,  pointEndY);
            
            return figure;


        }
        public override Figure IsPointInside(int pointX, int pointY)
        {
           
            bool IsPointsInside1;
            Figure figure = new MyRectangle(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
            
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
            else{ 
                return null;
                }

           


        }
    }
}
