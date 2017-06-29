using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : UserControl
    {
        double firstNumber;
        string operation;
        public Calculator()
        {
            InitializeComponent();

           

            foreach(Control c in this.Controls)
            {
                c.PreviewKeyDown += C_KeyDown;
            }

        }

       

        private void btn9_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";
            //txtResult.Text = txtResult.Text + operation;
            //MessageBox.Show(firstNumber.ToString());
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "/";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            firstNumber = 0;
            operation = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            txtResult.Text = RemoveLastChar(txtResult.Text);
        }
        public string RemoveLastChar(string fulltext)
        {
            string bkp = string.Empty;
            char[] text = fulltext.ToCharArray();
            for (int i = 0; i < text.Length - 1; i++)
            {
                bkp += text[i];
            }
            return bkp;
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            if (txtResult.Text == null)
                secondNumber = 0;
            else
                secondNumber = Convert.ToDouble(txtResult.Text);


            switch (operation)
            {
                case "+":
                    {
                        result = firstNumber + secondNumber;
                        txtResult.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    break;
                case "-":
                    {
                        result = firstNumber - secondNumber;
                        txtResult.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    break;
                case "*":
                    {
                        result = firstNumber * secondNumber;
                        txtResult.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    break;
                case "/":
                    {
                        if(secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            txtResult.Text = Convert.ToString(result);
                            firstNumber = result;
                        }
                    }
                    break;
                default:

                    break;
            }
        }

        private void C_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            if (e.KeyData == Keys.NumPad9)
            {
                btn9_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad8)
            {
                btn8_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad7)
            {
                btn7_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad6)
            {
                btn6_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad5)
            {
                btn5_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad4)
            {
                btn4_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad3)
            {
                btn3_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad2)
            {
                btn2_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad1)
            {
                btn1_Click(null, null);
            }
            else if (e.KeyData == Keys.NumPad0)
            {
                btn0_Click(null, null);
            }
            else if (e.KeyData == Keys.Add)
            {
                btnPlus_Click(null, null);
            }
            else if (e.KeyData == Keys.Subtract)
            {
                btnMinus_Click(null, null);
            }
            else if (e.KeyData == Keys.Multiply)
            {
                btnMultiply_Click(null, null);
            }
            else if (e.KeyData == Keys.Divide)
            {
                btnDivide_Click(null, null);
            }
            else if (e.KeyData == Keys.Decimal)
            {
                btnPoint_Click(null, null);
            }
            else if (e.KeyData == Keys.Delete)
            {
                btnC_Click(null, null);
            }
            else if (e.KeyData == Keys.Back)
            {
                btnBack_Click(null, null);
            }
            
            //throw new NotImplementedException();
        }

       
    }
}
