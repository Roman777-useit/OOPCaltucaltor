using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    class Container : IEnumerable
    {
        protected List<Figure> figures = new List<Figure>();


        public object Current()
        {
            return figures;
            throw new NotImplementedException();
        }
        
        public  IEnumerator GetEnumerator()
        {
           
            return figures.GetEnumerator();
     
        }

        public void AddItem(Figure figure) {
            figures.Add(figure);
        
        }
        public bool MoveNext()
        {
            
            throw new NotImplementedException();
        }

        public void Reset(Figure figure)
        {
            figures.Remove(figure);
           
        }


    }
}
