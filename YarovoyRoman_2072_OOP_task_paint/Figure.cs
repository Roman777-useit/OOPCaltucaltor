using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
     abstract class Figure:IFigure
    {
        int x, y;
        public virtual void Draw(Graphics gr) {
        
        }
        public virtual void Move(Figure figure, GetPoint getPoint) {
        
        }
    }
}
