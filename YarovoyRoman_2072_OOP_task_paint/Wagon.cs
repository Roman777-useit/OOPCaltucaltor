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

        Figure rectangle;
        Figure circle;
        int PointStartX;
        int PointStartY;
        int PointEndX;
        int PointEndY;


        public Wagon(MyRectangle rectangle,MyCircle circle, Form1.GetPoint getPoints)
        {

            this.rectangle = rectangle;
            this.circle = circle;
            
        }

        public override void Draw(Graphics gr )
        {   
            
            rectangle.Draw(gr);
            gr.DrawEllipse(new Pen(Color.Red), PointStartX, PointEndY, (PointEndX - PointStartX) / 3, (PointEndY - PointStartY) / 3);
            gr.DrawEllipse(new Pen(Color.Red), PointEndX - (PointEndX - PointStartX) / 3, PointEndY, (PointEndX - PointStartX) / 3, (PointEndY- PointStartY) / 3);



        }
        
    }
}
