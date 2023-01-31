using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_q_test
{
    public partial class Test : Form
    {
        int  answer, grade=0, opr,number1,number2,page_counter=1;
        private void text_answer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (page_counter == 11)
            {
                Next_button.Enabled = false;
                finish_button.Enabled = true;   
            }
            else if (e.KeyChar == 13)//enter ascci code aka carriage return(cr)
            {
            button1_Click(sender, e);
            }

            if (/*!char.IsControl(e.KeyChar) &&*/!char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void text_answer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            if (text_answer.Text == answer.ToString())
            {
                grade++;
            }
            MessageBox.Show("You got " + grade.ToString() + "/10", "Final score");
            Application.Exit();
        }
        char op;
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_answer.Text== answer.ToString())
            {
                grade++;
            }
            page_counter++;

            this.Controls.Clear();
            this.InitializeComponent();
            

            Random num1 = new Random();
            number1 = num1.Next(2,60);
            Random num2 = new Random();
            number2 = num2.Next(1,number1);
            Random oprator = new Random();
            opr = oprator.Next(4);
            switch (opr)
            {
                case 0:
                    op = '+';
                    answer = number1 + number2;
                    break;
                case 1:
                    op = '-';
                    answer = number1 - number2;
                   
                    break;
                case 2:
                    op = '*';
                    
                    if (number1 >12|| number2 > 12)
                    {
                        number1 = num1.Next(2,12);
                        number2 = num2.Next(1, number1);
                    }
                    answer = number1 * number2;
                    break;
                case 3:
                    op = '/';
                    while (number1 % number2 != 0)
                    {
                        number1 = num1.Next(2,20);
                        number2 = num2.Next(1, 100);
                    }
                    answer = number1 / number2;
                    break;
            }
            label_equation.Text = number1.ToString() + op.ToString() + number2.ToString();
            text_answer.Focus();
            if (page_counter==11)
            {
                Next_button.Enabled = false;
                finish_button.Enabled = true;
            }
        }
        private void Test_Load(object sender, EventArgs e)
        {
            Next_button.Text = "Start";
        }
    }
}
