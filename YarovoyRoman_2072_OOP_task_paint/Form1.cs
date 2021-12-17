using System;
using System.Drawing;
using System.Windows.Forms;

namespace task_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

 
        protected bool IsMouseDown=false;
        protected bool IsBelong = false;
        protected Point PointStart;
        protected Point PointEnd;
        Container container = new Container();
        Figure figureMove;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();

            foreach (Figure figure in container)
            {
                figure.Draw(gr); 
            }
            


        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            
                IsMouseDown = true;
                PointStart = e.Location;
                PointStart.X=e.X;
                PointStart.Y=e.Y;
            if (radioMove.Checked)
            {
                foreach (Figure figure in container)
                {
                    if (figure.IsPointInside(e.X, e.Y) == true)
                    {
                        IsBelong = true;
                        figureMove = figure;
                        break;
                    }
                }
            }




        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
                if (IsMouseDown == true)
                {
                    PointEnd = e.Location;
                    PointEnd.X=e.X;
                    PointEnd.Y=e.Y;
                }
                IsMouseDown = false;






            if (figureRectangle.Checked)
            { 

                if (PointStart.X < PointEnd.X) {
                    Figure rectangle = new MyRectangle(PointStart.X, PointStart.Y,Math.Abs(PointStart.Y-PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(rectangle);
                }
                else if (PointStart.X > PointEnd.X) {
                    Figure rectangle = new MyRectangle(PointEnd.X, PointEnd.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(rectangle);
                }
                
            }
            if (figureCircle.Checked)
            {
                if (PointStart.X < PointEnd.X)
                {
                    Figure circle = new MyCircle(PointStart.X, PointStart.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(circle);
                }
                else if (PointStart.X > PointEnd.X)
                {
                    Figure circle = new MyCircle(PointEnd.X, PointEnd.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(circle);
                }
            }
            if (figureWagon.Checked)
            {
                if (PointStart.X < PointEnd.X)
                {
                    Figure wagon = new Wagon(PointStart.X, PointStart.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(wagon);
                }
                else if (PointStart.X > PointEnd.X)
                {
                    Figure wagon = new Wagon(PointEnd.X, PointEnd.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(wagon);
                }
            }
            if (figureWagonCoal.Checked)
            {
                if (PointStart.X < PointEnd.X)
                {
                    Figure wagonCoal = new WagonCoal(PointStart.X, PointStart.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(wagonCoal);
                }
                else if (PointStart.X > PointEnd.X)
                {
                    Figure wagonCoal = new WagonCoal(PointEnd.X, PointEnd.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(wagonCoal);
                }
            }

            if (figureTrain.Checked)
            {
                if (PointStart.X < PointEnd.X)
                {
                    Figure train = new Train(PointStart.X, PointStart.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(train);
                }
                else if (PointStart.X > PointEnd.X)
                {
                    Figure train = new Train(PointEnd.X, PointEnd.Y, Math.Abs(PointStart.Y - PointEnd.Y), Math.Abs(PointStart.X - PointEnd.X));
                    container.AddItem(train);
                }
            }
            if (radioMove.Checked)
            {
                if (IsBelong == true)
                {
                    figureMove.Move(e.X, e.Y);
                }



            }
            if (radioRemove.Checked)
            {

                container.Reset();
            }
          
            panel1.Refresh();
           
        }

        
    }
}
