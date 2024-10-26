using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (TxtResult.Text == "0")
                TxtResult.Text = "";
            {
                if(number.Text == ".")
                {
                    if(!TxtResult.Text.Contains("."))
                    {
                        TxtResult.Text = TxtResult.Text + number.Text;
                    }
                }
                else
                {
                    TxtResult.Text = TxtResult.Text + number.Text;
                }
            }
        }

        private void NumberOperators(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            enterFirstValue = Convert.ToDouble(TxtResult.Text);
            op = number.Text;
            TxtResult.Text = "0";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(TxtResult.Text);
            switch(op)
            {
                case "+": TxtResult.Text = (enterFirstValue + enterSecondValue).ToString(); break;
                case "-": TxtResult.Text = (enterFirstValue - enterSecondValue).ToString(); break;
                case "*": TxtResult.Text = (enterFirstValue * enterSecondValue).ToString(); break;
                case "/": TxtResult.Text = (enterFirstValue / enterSecondValue).ToString(); break;
                case "MOD": TxtResult.Text = (enterFirstValue % enterSecondValue).ToString(); break;
                case "EXP":
                    double firstValue = Convert.ToDouble(TxtResult.Text);
                    double secondValue = enterSecondValue;
                    TxtResult.Text = Math.Exp(firstValue * Math.Log(secondValue * 4)).ToString();
                    break;

                default: break;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
            String firstEntry, secondEntry;
            firstEntry = Convert.ToString(enterFirstValue);
            secondEntry = Convert.ToString(enterSecondValue);
            firstEntry = "";
            secondEntry = "";
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text == "")
            {
                TxtResult.Text = "0";
            }
            double num = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(-1 * num);

        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if(TxtResult.Text.Length > 0)
            {
                TxtResult.Text = TxtResult.Text.Remove(TxtResult.Text.Length - 1, 1);
            }
            if(TxtResult.Text == "")
            {
                TxtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 272;
            TxtResult.Width = 237;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 541;
            TxtResult.Width = 507;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCalculator;
            exitCalculator = MessageBox.Show("Confirm if you want to exit", "Scientific calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCalculator == DialogResult.Yes) Application.Exit();
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.PI);
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnQuadrate_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(x * x);
        }

        private void BtnSinh_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnCube_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(TxtResult.Text);
            TxtResult.Text = Convert.ToString(x * x * x);
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Sin(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnCosh_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Cosh(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Cos(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnTanh_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Tanh(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Tan(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(1 / Convert.ToDouble(TxtResult.Text));
        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(Convert.ToDouble(TxtResult.Text) / 100);
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString((int)Convert.ToInt32(Convert.ToDouble(TxtResult.Text)));
        }

        private void BtnOct_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(int.Parse(TxtResult.Text), 8);
        }

        private void BtnHex_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(int.Parse(TxtResult.Text), 16);
        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            TxtResult.Text = Convert.ToString(int.Parse(TxtResult.Text), 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 272; 
            TxtResult.Width = 237; 
        }
    }
}
