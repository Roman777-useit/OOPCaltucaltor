using System.Drawing;

namespace task_paint
{
    abstract class Figure
    {
        public int x, y;
        public virtual void Draw(Graphics gr)
        {

        }
        public virtual void Move(int pointX, int pointY)
        {


        }
        public virtual Figure IsPointInside(int pointX, int pointY)
        {
            return null;

        }

    }
}
