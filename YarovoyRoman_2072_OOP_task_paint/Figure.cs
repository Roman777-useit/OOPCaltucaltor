using System.Drawing;

namespace task_paint
{
    abstract class Figure
    {
        public int x, y;
        public abstract void Draw(Graphics gr);


        public abstract void Move(int pointX, int pointY);

        public abstract bool IsPointInside(int pointX, int pointY);


    }
}
