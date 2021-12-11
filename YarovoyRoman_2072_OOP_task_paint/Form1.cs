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
        protected Point PointMoveStart;
        protected Point PointMoveEnd;
        
        Points point = new Points(0, 0, 0, 0);
        Container container = new Container();
        Figure figureMove = null;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            
           
            
            
            foreach (Figure figure in container)
            {

                figure.Draw(gr);

                if (radioMove.Checked)
                {
                figure.Move(PointMoveEnd.X,PointMoveEnd.Y);
                }
            }
            


        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
                
            if (!radioMove.Checked&&!radioRemove.Checked) {
                IsMouseDown = true;
                PointStart = e.Location;
                point.PointStartX = PointStart.X;
                point.PointStartY = PointStart.Y;
            }
            if (radioMove.Checked) {
                IsMouseDown = true;

                PointMoveStart.X = e.X;
                PointMoveStart.Y = e.Y;

            }
            
            figureMove=figureMove.IsPointInside(e.X,e.Y);
            


        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!radioMove.Checked) {
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
                Figure rectangle = new MyRectangle(point);
                container.AddItem(rectangle);
            }
            if (radioButton2.Checked)
            {
                Figure circle = new MyCircle(point);
                container.AddItem(circle);
            }
            if (radioButton3.Checked)
            {
                Figure wagon = new Wagon(point);
                container.AddItem(wagon);
            }
            if (radioButton4.Checked)
            {
                Figure wagonCoal = new WagonCoal(point);
                container.AddItem(wagonCoal);
            }
            if (radioMove.Checked)
            {
                if (IsMouseDown == true)
                {
                    PointMoveEnd.X = e.X;
                    PointMoveEnd.Y = e.Y;

                }
                IsMouseDown = false;


                
                
            }

            if (radioButton6.Checked)
            {
                Figure train = new Train(point);
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
