using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool opr_pressed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            if ((Result.Text == "0")||(opr_pressed))
            {
                Result.Clear();
            }

            opr_pressed = false;
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            operation = a.Text;
            value = double.Parse(Result.Text);
            opr_pressed = true;
            equation.Text = value + "" + operation;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            switch (operation)
            {
                case "+":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (value * double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (value / double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }
    }
}
