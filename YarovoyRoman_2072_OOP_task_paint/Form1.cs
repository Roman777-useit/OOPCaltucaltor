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
            
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true) {
                PointEnd = e.Location;
            }
            IsMouseDown = false;

            if (radioButton1.Checked)

            {
                Figure rectangle = new MyRectangle(GetPoint());
                figures.Add(rectangle);
            }
            if (radioButton2.Checked)
            {
                Figure circle = new MyCircle(GetPoint());
                figures.Add(circle);
            }
            if (radioButton3.Checked)
            {
                Figure wagon = new Wagon(GetPoint());
                figures.Add(wagon);
            }
            if (radioButton4.Checked)
            {
                Figure wagonCoal = new WagonCoal(GetPoint());
                figures.Add(wagonCoal);
            }
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

        
    }
}
