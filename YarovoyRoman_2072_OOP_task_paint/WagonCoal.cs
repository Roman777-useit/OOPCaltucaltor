using System.Drawing;

namespace task_paint
{
    class WagonCoal : Wagon
    {
        int height, width;
        public WagonCoal(int PointStartX, int PointStartY, int height, int width) : base(PointStartX, PointStartY, height, width)
        {

            x = PointStartX;
            y = PointStartY;
            this.height = height;
            this.width = width;

        }

        public override void Draw(Graphics gr)
        {

            base.Draw(gr);
            gr.DrawPolygon(new Pen(Color.Black, 5), new PointF[] { new Point(x, y), new Point(x + width / 2, y - height / 2), new Point(x + width, y) });



        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;

        }
        public override Figure IsPointInside(int pointX, int pointY)
        {

            bool IsPointsInside1;
            Figure figure = new WagonCoal(x, y, height, width);

            if ((pointX <= x + width) && (pointX >= x) && ((pointY <= (y + height) + height / 2) && (pointY >= y - height / 2)))
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
