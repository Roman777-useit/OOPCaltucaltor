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

        public MyRectangle()
        {

        }
        public override void Draw(Graphics gr, Rectangle rectangle, int SelectIndex) {
            
            if (SelectIndex == 0) {
                gr.DrawRectangle(new Pen(Color.Black), rectangle);
            }
            
        }
    }
}
