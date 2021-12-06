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
        protected bool InFigure = false;
        protected Point PointStart;
        protected Point PointEnd;

  
        GetPoint getPoint = new GetPoint(0, 0, 0, 0);
        Container container = new Container();


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
            
            getPoint.PointStartX = PointStart.X;
            getPoint.PointStartY = PointStart.Y;
            
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true)
            {
                PointEnd = e.Location;
            }
            IsMouseDown = false;

            if (radioButton1.Checked)

            {
                Figure rectangle = new MyRectangle(getPoint);
                container.AddItem(rectangle);
            }
            if (radioButton2.Checked)
            {
                Figure circle = new MyCircle(getPoint);
                container.AddItem(circle);
            }
            if (radioButton3.Checked)
            {
                Figure wagon = new Wagon(new MyRectangle(getPoint) ,getPoint);
                container.AddItem(wagon);
            }
            if (radioButton4.Checked)
            {
                Figure wagonCoal = new WagonCoal(getPoint,new MyRectangle(getPoint), new MyCircle(getPoint));
                container.AddItem(wagonCoal);
            }
            if (radioButton5.Checked)
            {
               
            }
            panel1.Refresh();
            
        }
        
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true) {
                PointEnd = e.Location;
                
                getPoint.PointEndX = PointEnd.X;
                getPoint.PointEndY = PointEnd.Y;
            }
            
        }


    }
}
