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


        public MyCircle(Points point)
        {
            this.point = point;
            
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
        public override void Move(Graphics gr, int pointX, int pointY)
        {
            x = point.PointStartX;
            y = point.PointStartY;
            Rectangle rectangle = new Rectangle();
            rectangle.X = pointX;
            rectangle.Y = pointY;
            rectangle.Height = Math.Abs(y - point.PointEndY) / 2;
            rectangle.Width = Math.Abs(x - point.PointEndX) / 2;


            gr.DrawEllipse(new Pen(Color.Black, 5), rectangle);
        }
    }
}
