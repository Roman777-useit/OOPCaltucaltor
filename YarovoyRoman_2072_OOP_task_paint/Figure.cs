using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
     abstract class Figure
    {
        public int x, y;
        public virtual void Draw(Graphics gr) {
        
        }
        public virtual void Move(Graphics gr, int pointX, int pointY) { 
        
        }
       
    }
}
