using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace task_paint
{
    interface IFigure
    {
        void Draw(Graphics graphics);
        void Move(Figure figure,GetPoint getPoint);
        
    }
}
