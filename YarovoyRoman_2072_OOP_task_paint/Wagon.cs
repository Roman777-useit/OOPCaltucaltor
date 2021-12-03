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
        MyRectangle myRectangle;
        int PointStartX;
        int PointStartY;
        int PointEndX;
        int PointEndY;
        
        public Wagon(MyRectangle myRectangle, GetPoint getPoints)
        {
            this.myRectangle = myRectangle;
            PointStartX = getPoints.PointStartX;
            PointStartY = getPoints.PointStartY;
            PointEndX = getPoints.PointEndX;
            PointEndY = getPoints.PointEndY;
        }

        public override void Draw(Graphics gr )
        {

            myRectangle.Draw(gr);

            gr.DrawEllipse(new Pen(Color.Red), PointStartX, PointEndY, (PointEndX - PointStartX) / 3, (PointEndY - PointStartY) / 3);
            gr.DrawEllipse(new Pen(Color.Red), PointEndX - (PointEndX - PointStartX) / 3, PointEndY, (PointEndX - PointStartX) / 3, (PointEndY - PointStartY) / 3);



        }
        
    }
}
