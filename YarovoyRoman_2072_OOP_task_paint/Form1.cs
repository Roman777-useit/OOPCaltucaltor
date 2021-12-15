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
        Points point = new Points(0, 0, 0, 0,0,0,0,0);
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


            if (!radioMove.Checked)
            {
                IsMouseDown = true;
                PointStart = e.Location;
                point.PointStartX = PointStart.X;
                point.PointStartY = PointStart.Y;
            }
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
            if (!radioMove.Checked)
            {
                if (IsMouseDown == true)
                {
                    PointEnd = e.Location;
                    point.PointEndX = PointEnd.X;
                    point.PointEndY = PointEnd.Y;
                }
                IsMouseDown = false;

              
            }



            if (radioButton1.Checked)

            {
                Figure rectangle = new MyRectangle( point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
                container.AddItem(rectangle);
            }
            if (radioButton2.Checked)
            {
                Figure circle = new MyCircle(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
                container.AddItem(circle);
            }
            if (radioButton3.Checked)
            {
                Figure wagon = new Wagon(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
                container.AddItem(wagon);
            }
            if (radioButton4.Checked)
            {
                Figure wagonCoal = new WagonCoal(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
                container.AddItem(wagonCoal);
            }
            if (radioMove.Checked)
            {
                point.PointMoveStartX = e.X;
                point.PointMoveStartY = e.Y;
                point.PointMoveEndX = point.PointMoveStartX + Math.Abs(point.PointStartX - point.PointEndX);
                point.PointMoveEndY = point.PointMoveStartY + Math.Abs(point.PointStartY - point.PointEndY);

                if (figureMove != null) {
                    container.Reset(figureMove);
                    container.AddItem(figureMove.Move(point.PointMoveStartX, point.PointMoveEndX, point.PointMoveStartY, point.PointMoveEndY));
                   
                }


                
                
            }

            if (radioButton6.Checked)
            {
                Figure train = new Train(point.PointStartX, point.PointEndX, point.PointStartY, point.PointEndY);
                container.AddItem(train);
            }
            if (radioRemove.Checked)
            {
                   
                if (figureMove != null)
                { 
                    container.Reset(figureMove);
                }
            }
          
            panel1.Refresh();
           
        }

        
    }
}
