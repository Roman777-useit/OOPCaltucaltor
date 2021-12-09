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
        public  Figure IsPointInside(int pointX,int pointY, Points point)
        {
            
            bool IsPointsInside1 = false;
            foreach (Figure figure in figures) {
                if ((pointX < point.PointEndX) && (pointX > point.PointStartX) && ((pointY < point.PointEndY) && (pointY > point.PointStartY)))
                {
                    IsPointsInside1 = true;
                }
                else {
                    IsPointsInside1 = false;
                }
                if (IsPointsInside1 == true)
                {
                    return figure;
                }
            }
 
         return null;
        }

    }
}
