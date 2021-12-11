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

        public WagonCoal(Points point) : base(point)
        {
            
            tr = new Tr(point);

        }

        public override void Draw(Graphics gr)
        {

            base.Draw(gr);
            tr.Draw(gr);
            


        }
        public override void Move(int pointX, int pointY)
        {
            base.Move(pointX, pointY);
            tr.Move(pointX, pointY);
        }


    }
}
