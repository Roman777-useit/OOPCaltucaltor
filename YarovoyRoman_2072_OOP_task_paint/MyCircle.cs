using System.Drawing;
namespace task_paint
{
    class MyCircle : Figure
    {
        int height, width;
        public MyCircle(int PointStartX, int PointStartY, int height, int width)
        {

            x = PointStartX;
            y = PointStartY;
            this.height = height;
            this.width = width;

        }
        public override void Draw(Graphics gr)
        {

            Rectangle rectangle = new Rectangle();
            rectangle.X = x;
            rectangle.Y = y;
            rectangle.Height = height;
            rectangle.Width = width;
            gr.DrawEllipse(new Pen(Color.Black, 5), rectangle);
        }
        public override void Move(int pointX, int pointY)
        {
            x = pointX;
            y = pointY;

        }
        public override bool IsPointInside(int pointX, int pointY)
        {

           

            if ((pointX <= x + width) && (pointX >= x) && ((pointY <= y + height) && (pointY >= y)))
            {
                return true;
            }
            else
            {
                return false;
            }
            




        }




    }

}
