using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal result;
        private void btn0_Click(object sender, EventArgs e)
        {
            boxInput.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            boxInput.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            boxInput.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            boxInput.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            boxInput.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            boxInput.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            boxInput.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            boxInput.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            boxInput.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            boxInput.Text += 9;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            boxInput.Text += '.';
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            boxInput.Text = "";
            label1.Text = "";
            result = 0;
            
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "+";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "+";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "+";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result += Convert.ToDecimal(boxInput.Text);
                label1.Text += boxInput.Text + "+";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "-";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "-";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "-";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result -= Convert.ToDecimal(boxInput.Text);
                label1.Text += boxInput.Text + "-";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "*";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "*";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "*";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result *= Convert.ToDecimal(boxInput.Text);
                label1.Text += boxInput.Text + "*";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "/";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "/";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "/";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result /= Convert.ToDecimal(boxInput.Text);
                label1.Text += boxInput.Text + "/";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "%";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "%";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "%";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result %= Convert.ToDecimal(boxInput.Text);
                label1.Text += boxInput.Text + "%";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "^";
                boxInput.Text = "";
            }
            else if (Decimal.TryParse(label1.Text.Last().ToString(), out _))
            {
                label1.Text += "^";
            }
            else if (boxInput.Text.Length == 0 && label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1) + "^";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                result = (decimal)Math.Pow((double)result , Convert.ToDouble(boxInput.Text));
                label1.Text += boxInput.Text + "^";
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (boxInput.Text.Length > 0 && label1.Text.Length == 0)
            {
                result = Convert.ToDecimal(boxInput.Text);
                label1.Text = boxInput.Text + "=";
                boxInput.Text = "";
            }
            else if (boxInput.Text.Length > 0 && label1.Text.Length > 0)
            {
                if (label1.Text.Last() == '+')
                {
                    result += Convert.ToDecimal(boxInput.Text);
                }
                else if(label1.Text.Last() == '-')
                {
                    result -= Convert.ToDecimal(boxInput.Text);
                }
                else if (label1.Text.Last() == '*')
                {
                    result *= Convert.ToDecimal(boxInput.Text);
                }
                else if(label1.Text.Last() == '/')
                {
                    result /= Convert.ToDecimal(boxInput.Text);
                }
                else if (label1.Text.Last() == '^')
                {
                    result = (decimal)Math.Pow((double)result, Convert.ToDouble(boxInput.Text));
                }
                else if (label1.Text.Last() == '%')
                {
                    result %= Convert.ToDecimal(boxInput.Text);
                }
                label1.Text = Convert.ToString(result);
                boxInput.Text = "";
            }
            else
            {
                //popup
            }
        }
    }
}
