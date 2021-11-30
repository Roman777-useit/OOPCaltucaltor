using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class MyRectangle:Figure
    {

        int PointStartX;
        int PointStartY;
        int PointEndX;
        int PointEndY;

        public MyRectangle(Form1.GetPoint getPoints)
        {
            PointStartX = getPoints.PointStartX;
            PointStartY = getPoints.PointStartY;
            PointEndX = getPoints.PointEndX;
            PointEndY = getPoints.PointEndY;
        }

        public override void Draw(Graphics gr) {
            //points[0] = PointStart.X;
            //points[1] = PointStart.Y;
            //points[2] = PointEnd.X;
            //points[3] = PointEnd.Y;

            
            Rectangle rectangle = new Rectangle();
            rectangle.X = Math.Min(PointStartX, PointEndX);
            rectangle.Y = Math.Min(PointStartY, PointEndY);
            rectangle.Height = Math.Abs(PointStartY - PointEndY);
            rectangle.Width = Math.Abs(PointStartX - PointEndX);


            gr.DrawRectangle(new Pen(Color.Black),rectangle );
            
            
        }
    }
}
