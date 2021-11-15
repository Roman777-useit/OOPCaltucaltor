using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace task_paint
{
    class MyCircle:Figure
    {

        public MyCircle()
        {

        }

        public override void Draw(Graphics gr,Rectangle rectangle,int SelectIndex) {
            if (SelectIndex == 1)
            {
               
                gr.DrawEllipse(new Pen(Color.Black), rectangle);
            }
           
        }
    }
}
