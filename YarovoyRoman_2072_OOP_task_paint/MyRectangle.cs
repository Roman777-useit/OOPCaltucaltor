using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    class MyRectangle:Figure
    {



        Points point;
        public MyRectangle(Points point)
        {
            this.point = point;
           
           
        }

        public override void Draw(Graphics gr) {
            
            x = point.PointStartX;
            y = point.PointStartY;
            Rectangle rectangle = new Rectangle();
            rectangle.X = Math.Min(x, point.PointEndX);
            rectangle.Y = Math.Min(y, point.PointEndY);
            rectangle.Height = Math.Abs(y - point.PointEndY);
            rectangle.Width = Math.Abs(x - point.PointEndX);


            gr.DrawRectangle(new Pen(Color.Black,5),rectangle );
            
            
        }
        public override void Move(Graphics gr,int pointX,int pointY)
        {
            
            Rectangle rectangle = new Rectangle();
            rectangle.X = pointX;
            rectangle.Y = pointY;
            rectangle.Height = Math.Abs(point.PointStartY - point.PointEndY);
            rectangle.Width = Math.Abs(point.PointStartX - point.PointEndX);
            gr.DrawRectangle(new Pen(Color.Black,5), rectangle);

        }

    }
}
