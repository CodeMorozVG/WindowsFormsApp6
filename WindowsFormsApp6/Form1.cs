using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = textBox1.Text + "+";
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void zerro_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
           for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i]== '*')
                {
                    num1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                    num2 = Convert.ToDouble(textBox1.Text.Substring(i+1));
                    resault(textBox1.Text[i], num1, num2);
                }
                if (textBox1.Text[i] == '-')
                {
                    num1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                    num2 = Convert.ToDouble(textBox1.Text.Substring(i + 1));
                    resault(textBox1.Text[i], num1, num2);
                }
                if (textBox1.Text[i] == '/')
                {
                    num1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                    num2 = Convert.ToDouble(textBox1.Text.Substring(i + 1));
                    resault(textBox1.Text[i], num1, num2);
                }
                if (textBox1.Text[i] == '^')
                {
                    num1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                    num2 = Convert.ToDouble(textBox1.Text.Substring(i + 1));
                    resault(textBox1.Text[i], num1, num2);
                }
                if (textBox1.Text[i] == '+')
                {
                    num1 = Convert.ToDouble(textBox1.Text.Substring(0, i));
                    num2 = Convert.ToDouble(textBox1.Text.Substring(i + 1));
                    resault(textBox1.Text[i], num1, num2);
                }
                
            }
            
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "(";
            }
            else
            {
                textBox1.Text = textBox1.Text + "(";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ")";
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "-";
            }
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
             textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
        
      private void resault (char s,double numb1,double numb2)
        {
            switch (s)
            {
                case ('+'):
                    textBox1.Text = (numb1 + numb2).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (numb1 - numb2).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (numb1 * numb2 + numb2).ToString();
                    break;
                
                case ('/'):
                    if (numb2 == 0)
                    {
                        textBox1.Text = ("Ты дурак на 0 делить нельзя ! ИДИ учи МАТЕМАТИКУ! ");
                        break;
                    }


                    else
                    {
                        textBox1.Text = (numb1 / numb2).ToString();
                        break;
                    }
                    break;



            }
        } 
    }
}
