using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace task_paint
{
    class Container : IEnumerable,IEnumerator
    {
        private List<Figure> figures = new List<Figure>();
        

        public object Current => throw new NotImplementedException();

        public  IEnumerator GetEnumerator()
        {
           
            return figures.GetEnumerator();
            throw new NotImplementedException();
        }

        public void AddItem(Figure figure) {
            figures.Add(figure);
        
        }
        public bool MoveNext()
        {
            
            throw new NotImplementedException();
        }

        public void Reset()
        {
            
            throw new NotImplementedException();
        }
        public bool IsCoordinats(Point point) {
            bool IsBelong=false;
           
            foreach (Figure figure in figures) { 
            if((figure.x==point.X) && (figure.y == point.Y)){
                    IsBelong = true;
                }
            }
            return IsBelong;
        }
    }
}
