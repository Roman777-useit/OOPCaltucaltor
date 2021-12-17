using System.Drawing;

namespace task_paint
{
    class Wagon : Figure
    {
        Figure myRectangle1;
        Figure myCircle1;
        Figure myCircle2;
        int height, width;
        public Wagon(int PointStartX, int PointStartY, int height, int width)
        {

            x = PointStartX;
            y = PointStartY;
            this.height = height;
            this.width = width;

        }

        public override void Draw(Graphics gr)
        {

            myRectangle1 = new MyRectangle(x, y, height, width);
            myCircle1 = new MyCircle(x, y + height, height / 2, width / 2);
            myCircle2 = new MyCircle(x + width / 2, y + height, height / 2, width / 2);
            myRectangle1.Draw(gr);
            myCircle1.Draw(gr);
            myCircle2.Draw(gr);





        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new Wagon(x, y, height, width);

            if ((pointX <= x + width) && (pointX >= x) && ((pointY <= (y + height) + height / 2) && (pointY >= y)))
            {
                IsPointsInside1 = true;
            }
            else
            {
                IsPointsInside1 = false;
            }
            if (IsPointsInside1 == true)
            {
                return figure;

            }
            else
            {
                return null;
            }




        }
    }
}
