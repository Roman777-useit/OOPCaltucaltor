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
        public virtual Figure Move(int pointX, int pointY, int pointEndX, int pointEndY) {
            return null;
        
        }
        public  virtual Figure IsPointInside(int pointX, int pointY)
        {
                    return null;

        }

    }
}
