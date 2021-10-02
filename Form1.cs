using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                
                Calculator rational1 = new Calculator(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                Calculator rational2 = new Calculator(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                    switch (comboBox1.Text) {
                    case"+":

                    Calculator rational = rational1 + rational2;
                    label1.Text = rational.Evklid(rational).ToString();
                    break;

                    case "-":
                     rational = rational1 - rational2;
                    label1.Text = rational.Evklid(rational).ToString();
                    break;

                    case "*":
                     rational = rational1 * rational2;
                    label1.Text = rational.Evklid(rational).ToString();
                    break;

                    case "/":
                     rational = rational1 / rational2;
                    label1.Text = rational.Evklid(rational).ToString();
                    break;
            }
                
                    

                
                
            
          
            
        }

    }
}
