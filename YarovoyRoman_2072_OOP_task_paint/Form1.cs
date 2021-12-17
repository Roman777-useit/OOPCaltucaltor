using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        protected Point PointStart;
        protected Point PointEnd;
        Points point = new Points(0, 0, 0, 0);
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
                point.PointStartX = PointStart.X;
                point.PointStartY = PointStart.Y;
           
            if (radioMove.Checked) {
                figureMove = null;
                foreach (Figure figure in container) {
                    if (figure.IsPointInside(e.X, e.Y) != null) {
                        figureMove = figure.IsPointInside(e.X, e.Y);
                    };
                }
                
            }
            
            


        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
           
                if (IsMouseDown == true)
                {
                    PointEnd = e.Location;
                    point.PointEndX = PointEnd.X;
                    point.PointEndY = PointEnd.Y;
                }
                IsMouseDown = false;






            if (figureRectangle.Checked)
            { 

                if (point.PointStartX < point.PointEndX) {
                    Figure rectangle = new MyRectangle(point.PointStartX, point.PointStartY,Math.Abs(point.PointStartY-point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(rectangle);
                }
                else if (point.PointStartX > point.PointEndX) {
                    Figure rectangle = new MyRectangle(point.PointEndX, point.PointEndY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(rectangle);
                }
                
            }
            if (figureCircle.Checked)
            {
                if (point.PointStartX < point.PointEndX)
                {
                    Figure circle = new MyCircle(point.PointStartX, point.PointStartY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(circle);
                }
                else if (point.PointStartX > point.PointEndX)
                {
                    Figure circle = new MyCircle(point.PointEndX, point.PointEndY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(circle);
                }
            }
            if (figureWagon.Checked)
            {
                if (point.PointStartX < point.PointEndX)
                {
                    Figure wagon = new Wagon(point.PointStartX, point.PointStartY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(wagon);
                }
                else if (point.PointStartX > point.PointEndX)
                {
                    Figure wagon = new Wagon(point.PointEndX, point.PointEndY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(wagon);
                }
            }
            if (figureWagonCoal.Checked)
            {
                if (point.PointStartX < point.PointEndX)
                {
                    Figure wagonCoal = new WagonCoal(point.PointStartX, point.PointStartY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(wagonCoal);
                }
                else if (point.PointStartX > point.PointEndX)
                {
                    Figure wagonCoal = new WagonCoal(point.PointEndX, point.PointEndY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(wagonCoal);
                }
            }
            if (radioMove.Checked)
            {
                foreach (Figure figure in container) {
                    if (figure.IsPointInside(point.PointStartX, point.PointStartY) != null) {
                        figure.Move(e.X, e.Y);
                    }
                }

                
                
            }

            if (figureTrain.Checked)
            {
                if (point.PointStartX < point.PointEndX)
                {
                    Figure train = new Train(point.PointStartX, point.PointStartY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(train);
                }
                else if (point.PointStartX > point.PointEndX)
                {
                    Figure train = new Train(point.PointEndX, point.PointEndY, Math.Abs(point.PointStartY - point.PointEndY), Math.Abs(point.PointStartX - point.PointEndX));
                    container.AddItem(train);
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
