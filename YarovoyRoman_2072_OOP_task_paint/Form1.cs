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

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics gr = panel1.CreateGraphics();
            //MyRectangle myRectangle = new MyRectangle(10, 10, 200, 100);
            //myRectangle.Draw(gr);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            Figure rectangle = new MyRectangle();
            Figure circle = new MyCircle();
            Figure wagon = new Wagon();
            figures.Add(rectangle);
            figures.Add(circle);
            figures.Add(wagon);
            foreach (Figure figure in figures)
            {
                figure.Draw(gr, GetPoint(), comboBox1.SelectedIndex);
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
        protected Rectangle GetPoint() {
            Rectangle rectangle = new Rectangle();
            rectangle.X = Math.Min(PointStart.X,PointEnd.X);
            rectangle.Y = Math.Min(PointStart.Y, PointEnd.Y);
            rectangle.Height = Math.Abs(PointStart.Y - PointEnd.Y);
            rectangle.Width = Math.Abs(PointStart.X - PointEnd.X);
            return rectangle;
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
