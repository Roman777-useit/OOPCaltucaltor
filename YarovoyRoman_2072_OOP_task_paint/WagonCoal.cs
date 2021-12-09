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
        public override void Move(Graphics gr, int pointX, int pointY)
        {
            base.Move(gr, pointX, pointY);
            tr.Move(gr, pointX, pointY);
        }


    }
}
