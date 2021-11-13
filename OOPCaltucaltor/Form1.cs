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
        protected void checkType(string text)
        {
            if (text != "")
            {
                try
                {
                    Convert.ToDouble(text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите число");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                {
                    throw new NullReferenceException();
                }
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
                MessageBox.Show("Попытка деления на ноль!");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Введите значение в поле!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            checkType(textBox1.Text);

        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            checkType(textBox2.Text);
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            checkType(textBox3.Text);
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            checkType(textBox4.Text);
        }
    }

}

