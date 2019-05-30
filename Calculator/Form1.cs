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
        Boolean clicked;
        double Firstnumber;
        String lastvalue;
        string Operation;
        double entered;
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "1";

            }
            else if (clicked == true) 
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "1";
                   
                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                   
                    textBox1.Text = textBox1.Text + 1;
                }
            }
            else
            {

                textBox1.Text = textBox1.Text + 1;
                entered = entered + 1;


            }
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "2";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 2;
                }
            }
            else
            {
               
                    textBox1.Text = textBox1.Text + 2;
                entered = entered + 2;
                
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "3";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 3;
                }
            }
            else
            {
               
                    textBox1.Text = textBox1.Text + 3;
                entered = entered + 3;
                
            }
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "4";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 4;
                }
            }
            else
            {
              
                    textBox1.Text = textBox1.Text + 4;
                entered = entered + 4;
                
            }
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "5";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 5;
                }
            }
            else
            {
                
                    textBox1.Text = textBox1.Text + 5;
                entered = entered + 5;
                
            }
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "6";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 6;
                }
            }
            else
            {
                 textBox1.Text = textBox1.Text + 6;
                entered = entered + 6;
                
            }
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "7";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 7;
                }
            }
            else
            {
                    textBox1.Text = textBox1.Text + 7;
                entered = entered + 7;
                
            }
        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "8";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 8;
                }
            }
            else
            {
               
                    textBox1.Text = textBox1.Text + 8;
                entered = entered + 8;
                
            }
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else if (clicked == true)
            {
                if (Operation == null)
                {
                    textBox1.Text = textBox1.Text + "9";

                    //entered = Convert.ToDouble(textBox1.Text);
                }
                else
                {

                    textBox1.Text = textBox1.Text + 9;
                }
            }
            else
            {
                
                    textBox1.Text = textBox1.Text + 9;
                entered = entered+9;
                
            }
        }

        private void N0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+0;
            entered = entered+0;
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + ".";
            clicked = true;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                Operation = "+";
                clicked = false;
                //lastvalue = textBox1.Text;
            }
            else
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Firstnumber + "+";
                Operation = "+";
                lastvalue = textBox1.Text;
            }
            


        }

        private void Multi_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                Operation = "*";
                clicked = false;
                //lastvalue = textBox1.Text;
            }
            else
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Firstnumber + "*";
                Operation = "*";
                lastvalue = textBox1.Text;
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                Operation = "/";
                clicked = false;
                //lastvalue = textBox1.Text;
            }
            else
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Firstnumber + "/";
                Operation = "/";
                lastvalue = textBox1.Text;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (clicked == true)
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                Operation = "-";
                clicked = false;
                //lastvalue = textBox1.Text;
            }
            else
            {
                Firstnumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Firstnumber + "-";
                Operation = "-";
                lastvalue = textBox1.Text;
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Double SecondNumber;
            Double Output;
            
            SecondNumber = Convert.ToDouble(entered);

            if(Operation == "+")
            {
                textBox1.Text = "";
                Output = (Firstnumber + SecondNumber);
                textBox1.Text = Convert.ToString(Output);
                Firstnumber = Output;
                entered = 0;
            }
            else if(Operation == "-"){
                textBox1.Text = "";
                Output = (Firstnumber - SecondNumber);
                textBox1.Text = Convert.ToString(Output);
                Firstnumber = Output;
                entered = 0;

            }
            else if(Operation == "*")
            {
                textBox1.Text = "";
                Output = (Firstnumber * SecondNumber);
                textBox1.Text = Convert.ToString(Output);
                Firstnumber = Output;
                entered = 0;
            }
            else if(Operation == "/")
            {
                if(SecondNumber != 0)      
                {
                    textBox1.Text = "";
                    Output = (Firstnumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Output);
                    Firstnumber = Output;
                    entered = 0;
                }
                else
                {
                    textBox1.Text = "Syntax Error";
                }
            }
        }

        private void Ce_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            String str = s.Remove(s.Length - 1, 1).ToString();
            entered = 0;
            textBox1.Text = str;
        }
    }
}
