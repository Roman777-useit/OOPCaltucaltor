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


            try
            {
                Rational rational1 = new Rational(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                Rational rational2 = new Rational(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                switch (comboBox1.Text)
                {
                    case "+":

                        Rational rational = rational1 + rational2;
                        label1.Text = rational.Reduction().ToString();
                        break;

                    case "-":
                        rational = rational1 - rational2;
                        label1.Text = rational.Reduction().ToString();
                        break;

                    case "*":
                        rational = rational1 * rational2;
                        label1.Text = rational.Reduction().ToString();
                        break;

                    case "/":
                        rational = rational1 / rational2;
                        label1.Text = rational.Reduction().ToString();
                        break;
                }
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back && e.KeyData != Keys.Tab && e.KeyData != Keys.Enter && e.KeyData != Keys.Space)
            {
                try
                {
                    Convert.ToDouble(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите число");
                    textBox1.Text = "";
                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back && e.KeyData != Keys.Tab && e.KeyData != Keys.Enter && e.KeyData != Keys.Space)
            {
                try
                {
                    Convert.ToDouble(textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите число");
                    textBox2.Text = "";
                }
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back && e.KeyData != Keys.Tab && e.KeyData != Keys.Enter && e.KeyData != Keys.Space)
            {
                try
                {
                    Convert.ToDouble(textBox3.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите число");
                    textBox3.Text = "";
                }
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back && e.KeyData != Keys.Tab && e.KeyData != Keys.Enter && e.KeyData != Keys.Space)
            {
                try
                {
                    Convert.ToDouble(textBox4.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите число");
                    textBox4.Text = "";
                }
            }
        }
    }

}

