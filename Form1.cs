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
                int[] result;
                result = new int[2];
                Calculator calculator = new Calculator(int.Parse(textBox1.Text), int.Parse(textBox3.Text), int.Parse(textBox2.Text), int.Parse(textBox4.Text));
                if (comboBox1.Text == "+")
                {
                    result = calculator.Summ();
                    textBox5.Text = result[0].ToString();
                    textBox6.Text = result[1].ToString();
                    if (textBox6.Text == "0")
                    {
                        MessageBox.Show("Делить на ноль нельзя! Введите другие данные");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }

                }
                else if (comboBox1.Text == "-")
                {
                    result = calculator.Subtraction();
                    textBox5.Text = result[0].ToString();
                    textBox6.Text = result[1].ToString();
                    if (textBox6.Text == "0")
                    {
                        MessageBox.Show("Делить на ноль нельзя! Введите другие данные");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                else if (comboBox1.Text == "*")
                {
                    result = calculator.Multiplication();
                    textBox5.Text = result[0].ToString();
                    textBox6.Text = result[1].ToString();
                    if (textBox6.Text == "0")
                    {
                        MessageBox.Show("Делить на ноль нельзя! Введите другие данные");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
                else if (comboBox1.Text == "/")
                {
                    result = calculator.Division();
                    textBox5.Text = result[0].ToString();
                    textBox6.Text = result[1].ToString();
                    if (textBox6.Text == "0")
                    {
                        MessageBox.Show("Делить на ноль нельзя! Введите другие данные");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Проверьте корректность введенных данных");
            }
            
        }

    }
}
