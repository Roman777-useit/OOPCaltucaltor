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
        public bool IsMouseDown=false;
        public Point PointStart;
        public Point PointEnd;



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
           
           
            
            
            foreach (Figure figure in figures)
            {
                figure.Draw(gr, GetPoint());
            }
            
           
            
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            PointStart = e.Location;
            
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true) {
                PointEnd = e.Location;
            }
            IsMouseDown = false;
 

        }
        protected int[] GetPoint() {
            //Rectangle rectangle = new Rectangle();
            //rectangle.X = Math.Min(PointStart.X, PointEnd.X);
            //rectangle.Y = Math.Min(PointStart.Y, PointEnd.Y);
            //rectangle.Height = Math.Abs(PointStart.Y - PointEnd.Y);
            //rectangle.Width = Math.Abs(PointStart.X - PointEnd.X);
            int [] points = new int[4];
            points[0] = PointStart.X;
            points[1] = PointStart.Y;
            points[2] = PointEnd.X;
            points[3] = PointEnd.Y;

            return points;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true) {
                PointEnd = e.Location;
            }
            panel1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Figure rectangle = new MyRectangle();
            if (figures.Count > 0)
            {
                figures.Clear();
            }
            figures.Add(rectangle);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Figure circle = new MyCircle();
            if (figures.Count > 0)
            {
                figures.Clear();
            }
            figures.Add(circle);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Figure wagon = new Wagon();
            if (figures.Count>0)
            {
                figures.Clear();
            }
             figures.Add(wagon); 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            Figure wagonCoal = new WagonCoal();
            if (figures.Count > 0)
            {
                figures.Clear();
            }
            figures.Add(wagonCoal);



        }
    }
}
