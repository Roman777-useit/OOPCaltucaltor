using System.Drawing;

namespace task_paint
{
    class Train : Figure
    {
        Wagon wagon1;
        Wagon wagon2;
        Wagon wagon3;
        int height, width;
        public Train(int PointStartX, int PointStartY, int height, int width)
        {

            x = PointStartX;
            y = PointStartY;
            this.height = height;
            this.width = width;

        }
        public override void Draw(Graphics gr)
        {
            wagon1 = new Wagon(x, y, height, width);
            wagon2 = new Wagon(x + width, y, height, width);
            wagon3 = new Wagon(x + 2 * width, y, height, width);
            wagon1.Draw(gr);
            wagon2.Draw(gr);
            wagon3.Draw(gr);
        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new Train(x, y, height, width);

            if ((pointX <= (x + width) + width * 2) && (pointX >= y) && ((pointY <= (y + height) + height / 2) && (pointY >= y)))
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
