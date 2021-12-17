using System.Collections;
using System.Collections.Generic;

namespace task_paint
{
    class Container : IEnumerable
    {
        protected List<Figure> figures = new List<Figure>();


 
        
        public  IEnumerator GetEnumerator()
        {
           
            return figures.GetEnumerator();
     
        }

        public void AddItem(Figure figure) {
            figures.Add(figure);
        
        }


        public void Reset()
        {
            figures.Clear();
        }



    }
}
