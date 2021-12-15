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

        Tr tr;
        Points point;
        public WagonCoal(int PointStartX, int PointEndX, int PointStartY, int PointEndY) : base( PointStartX,  PointEndX,  PointStartY,  PointEndY)
        {
            
           
            point.PointStartX = PointStartX;
            point.PointEndX = PointEndX;
            point.PointStartY = PointStartY;
            point.PointEndY = PointEndY;
        }

        public override void Draw(Graphics gr)
        {
            int width = Math.Abs(point.PointStartX - point.PointEndX);
            int height = Math.Abs(point.PointStartY - point.PointEndY);
            tr = new Tr(point.PointStartX, point.PointEndX,point. PointStartY+height*1/3,point. PointEndY-height*2/3);
            base.Draw(gr);
            tr.Draw(gr);
            


        }
        public override Figure Move(int pointX, int pointY, int pointEndX, int pointEndY)
        {


            return new WagonCoal( pointX,  pointY,  pointEndX,  pointEndY);
            
        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            
            Figure figure = new WagonCoal(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
            
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
