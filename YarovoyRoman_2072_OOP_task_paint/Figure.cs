using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task_paint
{
     abstract class Figure
    {

        public virtual void Draw(Graphics gr, int[] points) {
        
        }
    }
}
