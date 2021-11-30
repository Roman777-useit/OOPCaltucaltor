using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
    class WagonCoal : Wagon
    {

        int PointStartX;
        int PointStartY;
        int PointEndX;
        int PointEndY;


        public WagonCoal(Form1.GetPoint getPoints) : base(MyRectangle, MyCircle circle, Form1.GetPoint getPoints)
        {

            PointStartX = getPoints.PointStartX;
            PointStartY = getPoints.PointStartY;
            PointEndX = getPoints.PointEndX;
            PointEndY = getPoints.PointEndY;

        }

        public override void Draw(Graphics gr)
        {

            base.Draw(gr);

            PointF[] point = { new Point(PointStartX, PointStartY), new Point(PointStartX + (PointEndX - PointStartX) / 2, PointStartY - 50), new Point(PointEndX, PointStartY) };
            gr.DrawPolygon(new Pen(Color.DarkGoldenrod), point);


        }
    }
}
