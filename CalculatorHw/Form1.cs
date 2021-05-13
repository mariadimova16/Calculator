using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorHw
{
    public partial class Form1 : Form
    {
        double total = 0;
        int clickPoint = 0;
        string op = "";
        bool clickOp = false; 
        double lastNum; 
        public Form1()
        {
            InitializeComponent();
        }

        private void infoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void but7_Click(object sender, EventArgs e)
        {
            if(clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "7";
                clickOp = false;
            } 
            else
            {
                infoBox.Text += "7"; 
            }
            
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "8";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "9";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "9";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "4";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "5";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "5";
            }
        }

        
        private void but6_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "6";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "6";
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "1";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "2";
                clickOp = false;
            }
            else
            {
                infoBox.Text += "2";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "3";
                clickOp = false; 
            }
            else
                infoBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clickOp || infoBox.Text == "0")
            {
                infoBox.Text = "0";
                clickOp = false;
            }
            else
                infoBox.Text += "0";
        }

        private void butDec_Click(object sender, EventArgs e)
        {
           
            if(clickPoint < 1)
            infoBox.Text += ",";

            clickPoint++;
        }
        bool plusClick = false; 
        private void butPlus_Click(object sender, EventArgs e)
        {

            op = "+";
            plusClick = true;   
            clickOp = true;
            lastNum = Double.Parse(infoBox.Text);
            infoBox.Text = "";
            clickPoint = 0;
           
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            op = "-";
            clickOp = true;
            lastNum = Double.Parse(infoBox.Text);
            infoBox.Text = "";
            clickPoint = 0;
        }

        private void butMult_Click(object sender, EventArgs e)
        {
            op = "X";
            clickOp = true;
            lastNum = Double.Parse(infoBox.Text);
            infoBox.Text = "";
            clickPoint = 0;
        }

        private void butDev_Click(object sender, EventArgs e)
        {
            op = "/";
            clickOp = true;
            lastNum = Double.Parse(infoBox.Text);
            infoBox.Text = "";
            clickPoint = 0;

        }

        private void butClearAll_Click(object sender, EventArgs e)
        {
            op = "c"; 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    total = lastNum + Double.Parse(infoBox.Text);
                    infoBox.Text = total.ToString(); 
                    break;

                case "-":
                    total = lastNum - Double.Parse(infoBox.Text);
                    infoBox.Text = total.ToString();
                    break;

                case "X":
                    total = lastNum * Double.Parse(infoBox.Text);
                    infoBox.Text = total.ToString();
                    break;

                case "/":
                    total = lastNum / Double.Parse(infoBox.Text);
                    infoBox.Text = total.ToString();
                    break;

                case "sqrt":
                    total = Math.Sqrt(lastNum);
                    infoBox.Text = total.ToString();
                    break;

                case "m+":
                    m += Double.Parse(infoBox.Text);
                    infoBox.Text = "0";
                    break;

                case "m-":
                    m += Double.Parse(infoBox.Text);
                    infoBox.Text = "0";
                    break;

                case "mc":
                    m = 0;
                    infoBox.Text = "0";
                    break;

                case "mr":
                    infoBox.Text = m.ToString();
                    break;

                case "ac":

                    infoBox.Text = "0";
                    op = lastOp; 
                    break;

                case "c":
                    total = 0;
                    lastNum = 0;
                    clickPoint = 0;
                    infoBox.Clear();
                    break; 

            }
        }

        private void butSqrt_Click(object sender, EventArgs e)
        {
            op = "sqrt";
            lastNum = Double.Parse(infoBox.Text);
        }
        string lastOp = ""; 
        private void butClearCur_Click(object sender, EventArgs e)
        {

            lastOp = op; 
            op = "ac";
        }

        double m = 0; 
        private void butMplus_Click(object sender, EventArgs e)
        {
            op = "m+";
           
        }

        private void butMminus_Click(object sender, EventArgs e)
        {
            op = "m-";
            
        }

        private void butMC_Click(object sender, EventArgs e)
        {
            op = "mc"; 
        }

        private void butMR_Click(object sender, EventArgs e)
        {
            op = "mr"; 
        }
    }
}
