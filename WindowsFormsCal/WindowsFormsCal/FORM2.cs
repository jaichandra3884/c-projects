using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCal
{
    public partial class FORM2 : Form
    {
        string ch;
        public FORM2()
        {
            InitializeComponent();
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(ch.Substring(0, 1));
            int num2 = Convert.ToInt32(ch.Substring(2, 1));
            if (ch.Substring(1, 1) == "+")
            {
                RESULT.Text = Convert.ToString(num1 + num2);
               
                ch = "";

            }
            else if (ch.Substring(1, 1) == "-")
            {
                RESULT.Text = Convert.ToString(num1 - num2);
               
                ch = "";
            }
            else if (ch.Substring(1, 1) == "*")
            {
                RESULT.Text = Convert.ToString(num1 * num2);
                
                ch = "";
            }
            else if (ch.Substring(1, 1) == "/")
            {
                RESULT.Text = Convert.ToString(num1 / num2);
               
                ch = "";
            }

            else
            {
                MessageBox.Show("error");
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            RESULT.Clear();
            ch = "";
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "+";

            ch = RESULT.Text;
        }

        private void SUBTRACT_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "-";

            ch = RESULT.Text;
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "*";

            ch = RESULT.Text;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "/";

            ch = RESULT.Text;
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "1";

            ch = RESULT.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "2";
            ch = RESULT.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "3";
            ch = RESULT.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "4";
            ch = RESULT.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "5";
            ch = RESULT.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "6";
            ch = RESULT.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "7";
            ch = RESULT.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "8";
            ch = RESULT.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "9";
            ch = RESULT.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RESULT.Text = ch + "0";
            ch = RESULT.Text;
        }
    }
}
