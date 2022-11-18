using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mashin_hesab_win10
{
    public partial class Form1 : Form
    {

        float num1, hesab;
        string monster;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text+"1".ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            switch(monster){

                case "+":
                    hesab = num1 + float.Parse(txt_1.Text);
                    txt_1.Text = hesab.ToString();
                    num1 = hesab;
                    break;


                case "-":
                    hesab = num1 - float.Parse(txt_1.Text);
                    txt_1.Text = hesab.ToString();
                    num1 = hesab;
                    break;

                case "*":
                    hesab = num1 * float.Parse(txt_1.Text);
                    txt_1.Text = hesab.ToString();
                    num1 = hesab;
                    break;

                case "/":
                    hesab = num1 / float.Parse(txt_1.Text);
                    txt_1.Text = hesab.ToString();
                    num1 = hesab;
                    break;

                case "%":
                    hesab = num1 % float.Parse(txt_1.Text);
                    txt_1.Text = hesab.ToString();
                    num1 = hesab;
                    break;


                default:
                    txt_1.Text = "your not number !!!";
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            txt_1.Text = null;
            monster = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            txt_1.Text = null;
            monster = "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "2".ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "3".ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "00".ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + ".".ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "4".ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "5".ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "6".ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "7".ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "8".ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "9".ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txt_1.Text = null;
            monster = null;
            num1 = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            float num2 = num1 * num1;
            txt_1.Text = num2.ToString();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            txt_1.Text = null;
            monster = "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            txt_1.Text = null;
            monster = "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_1.Text = txt_1.Text + "0".ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txt_1.Text);
            txt_1.Text = null;
            monster = "-";
        }
    }
}
