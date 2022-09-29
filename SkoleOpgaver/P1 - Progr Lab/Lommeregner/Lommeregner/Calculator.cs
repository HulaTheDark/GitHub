using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Lommeregner
{

    /*  
     * Because this is a calculator the most of the items in here are self explaning i am only writing comments on the parts i think needs them.
     */
    public partial class Calculator : Form
    {
        private decimal ValueFirst = 0.0m;
        private decimal ValueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string Operators = "+";

        public Calculator()
        {
            InitializeComponent();
        }


        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "0")
            {
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!txtBox.Text.Contains("."))
            {
                txtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if(txtBox.Text == "0")
            {
                txtBox.Text = "1";
            }
            else
            {
                txtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "2";
            }
            else
            {
                txtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "3";
            }
            else
            {
                txtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "4";
            }
            else
            {
                txtBox.Text += "4";
            }
        }

        private void Fivebtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "5";
            }
            else
            {
                txtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "6";
            }
            else
            {
                txtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "7";
            }
            else
            {
                txtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "8";
            }
            else
            {
                txtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
            {
                txtBox.Text = "9";
            }
            else
            {
                txtBox.Text += "9";
            }
        }
        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Contains("-"))
            {
               txtBox.Text = txtBox.Text.Trim('-');
            }
            else
            {
                txtBox.Text = "-" + txtBox.Text;
            }
        }
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            Operators = "-";
        }
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            Operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            Operators = "/";
        }
        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            Operators = "*";
        }
        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = decimal.Parse(txtBox.Text);
            txtBox.Clear();
            Operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            /* 
             * Makes the equations between the first and second value.
             * The result is cut to 4 decimals.
             * The TryCatch is an exception handling process which makes it possible to divide by zero.
            */

            try
            {
                switch (Operators)
                {
                    case "-":
                        ValueSecond = decimal.Parse(txtBox.Text);
                        Result = ValueFirst - ValueSecond;
                        txtBox.Text = Result.ToString("0.0000");
                        break;
                    case "+":
                        ValueSecond = decimal.Parse(txtBox.Text);
                        Result = ValueFirst + ValueSecond;
                        txtBox.Text = Result.ToString("0.0000");
                        break;
                    case "/":
                        ValueSecond = decimal.Parse(txtBox.Text);
                        Result = ValueFirst / ValueSecond;
                        txtBox.Text = Result.ToString("0.0000");
                        break;
                    case "*":
                        ValueSecond = decimal.Parse(txtBox.Text);
                        Result = ValueFirst * ValueSecond;
                        txtBox.Text = Result.ToString("0.0000");
                        break;
                    case "%":
                        ValueSecond = decimal.Parse(txtBox.Text);
                        Result = ValueFirst % ValueSecond;
                        txtBox.Text = Result.ToString();
                        break;
                }
            }
            catch (DivideByZeroException)
            {

                WriteLine("Divison of {0} by zero", ValueFirst);
            }


            /* 
             * This is the list box, it is writing the old equations so the user don´t have to remeber them
             */
            if (!string.IsNullOrWhiteSpace(txtBox.Text))
            {
                listBox1.Items.Add($"{ValueFirst:0.####} {Operators} {ValueSecond:0.####} = {Result:0.####}");
            }




        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ValueFirst = 0.0m;
            ValueSecond = 0.0m;
            txtBox.Text = "0";
        }


    }
}
