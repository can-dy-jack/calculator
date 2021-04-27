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
    public partial class FrmScience : Form
    {
        double num, result;
        string op;
        bool re = false; // 是否+-/*运算
        bool red = false; // 是否运算结束
        bool point = true;
        public FrmScience()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "0";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (lblInter.Text.IndexOf("0") != 0)
                {
                    lblInter.Text += "0";
                }
                if (re)
                {
                    lblInter.Text = "0";
                    re = false;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "1";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "1";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "1";
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "2";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "2";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "2";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "3";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "3";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "3";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "4";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "4";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "4";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "5";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "5";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "5";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "6";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "6";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "6";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "7";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "7";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "7";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "8";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "8";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "8";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = "9";
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += "9";
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += "9";
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double lblnum = double.Parse(lblInter.Text);
            switch (op)
            {
                case "+":
                    result = num + lblnum;
                    lblTop.Text += " " + lblInter.Text + " =";
                    lblInter.Text = result.ToString();
                    red = true;
                    break;
                case "-":
                    result = num - lblnum;
                    lblTop.Text += " " + lblInter.Text + " =";
                    lblInter.Text = result.ToString();
                    red = true;
                    break;
                case "*":
                    result = num * lblnum;
                    lblTop.Text += " " + lblInter.Text + " =";
                    lblInter.Text = result.ToString();
                    red = true;
                    break;
                case "/":
                    if (lblnum != 0)
                    {
                        result = num / lblnum;
                        lblTop.Text += " " + lblInter.Text + " =";
                        lblInter.Text = result.ToString();
                    }
                    else
                    {
                        lblInter.Text = "除数不能为零!";
                    }
                    red = true;
                    break;
                default: break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            op = "+";
            re = true;
            num = double.Parse(lblInter.Text);
            lblTop.Text = lblInter.Text + " +";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            op = "-";
            re = true;
            num = double.Parse(lblInter.Text);
            lblTop.Text = lblInter.Text + " -";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            op = "*";
            re = true;
            num = double.Parse(lblInter.Text);
            lblTop.Text = lblInter.Text + " ×";
        }

        private void btnExcept_Click(object sender, EventArgs e)
        {
            op = "/";
            re = true;
            num = double.Parse(lblInter.Text);
            lblTop.Text = lblInter.Text + " ÷";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            point = false;
            lblInter.Text += ".";
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            FrmCalculator.fc.Show();
            this.Hide();
        }

        private void FrmScience_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEqual_MouseEnter(object sender, EventArgs e)
        {
            btnEqual.BackColor = Color.Gold;
        }

        private void btnEqual_MouseLeave(object sender, EventArgs e)
        {
            btnEqual.BackColor = Color.Khaki;
        }

        private void btnRoot2_Click(object sender, EventArgs e)
        {
            lblTop.Text = " sqrt(" + lblInter.Text + ")";
            double n = double.Parse(lblInter.Text);
            lblInter.Text = (Math.Sqrt(n)).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            lblTop.Text = " sqr(" + lblInter.Text + ")";
            double n = double.Parse(lblInter.Text);
            lblInter.Text = (n * n).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblTop.Text.Contains("="))
            {
                lblTop.Text = "";
            }
            else if (lblInter.Text.Length > 0 && !lblTop.Text.Contains("="))
            {
                lblInter.Text = lblInter.Text.Remove(lblInter.Text.Length - 1, 1);
            }
            if (lblInter.Text.Length == 0)
            {
                lblInter.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTop.Text = "";
            lblInter.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblInter.Text = "0";
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = Math.PI.ToString();
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += Math.PI.ToString();
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += Math.PI.ToString();
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double num = double.Parse(lblInter.Text);
            if (num == 0)
            {
                lblInter.Text = "除数不能为零";
                red = true;
            }
            else
            {
                lblTop.Text = "1/" + lblInter.Text;
                lblInter.Text = (1 / num).ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (lblTop.Text == "0" || lblTop.Text == "")
            {
                lblInter.Text = "0";
                lblTop.Text = "0";
            }
            else
            {
                double n = double.Parse(lblInter.Text);
                lblInter.Text = (n / 100).ToString();
            }
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (lblInter.Text != "0")
            {
                double num = double.Parse(lblInter.Text);
                num = -num;
                lblInter.Text = num.ToString();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (red)
            {
                lblInter.Text = Math.E.ToString();
                lblTop.Text = "";
                red = false;
            }
            else
            {
                if (point && (re || lblInter.Text.IndexOf("0") == 0))
                {
                    lblInter.Text = "";
                    lblInter.Text += Math.E.ToString();
                    re = false;
                    point = true;
                }
                else
                {
                    lblInter.Text += Math.E.ToString();
                }
            }
        }

    }
}
