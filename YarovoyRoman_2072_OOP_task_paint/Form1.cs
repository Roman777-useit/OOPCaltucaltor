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
       
        List<Figure> figures = new List<Figure>();
        protected bool IsMouseDown=false;
        protected Point PointStart;
        protected Point PointEnd;

        public struct GetPoint
        {

            public int PointStartX { get; set; }
            public int PointStartY { get; set; }
            public int PointEndX { get; set; }
            public int PointEndY { get; set; }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
           
           
            
            
            foreach (Figure figure in figures)
            {
                figure.Draw(gr);
            }
            
           
            
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            PointStart = e.Location;
            GetPoint getPoint = new GetPoint();
            getPoint.PointStartX = PointStart.X;
            getPoint.PointStartY = PointStart.Y;

        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true) {
                PointEnd = e.Location;
            }
            IsMouseDown = false;

            if (radioButton1.Checked)

            {
                Figure rectangle = new MyRectangle(new GetPoint());
                figures.Add(rectangle);
            }
            if (radioButton2.Checked)
            {
                Figure circle = new MyCircle(new GetPoint());
                figures.Add(circle);
            }
            if (radioButton3.Checked)
            {
                Figure wagon = new Wagon(new MyRectangle(new GetPoint()),new MyCircle(new GetPoint()), new GetPoint());
                figures.Add(wagon);
            }
            if (radioButton4.Checked)
            {
                Figure wagonCoal = new WagonCoal(new GetPoint());
                figures.Add(wagonCoal);
            }
            panel1.Refresh();
        }
        
        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true) {
                PointEnd = e.Location;
                GetPoint getPoint = new GetPoint();
                getPoint.PointEndX = PointEnd.X;
                getPoint.PointEndY = PointEnd.Y;
            }
            
        }

        
    }
}
