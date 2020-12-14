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
        Double resultValue = 0;
        String performedOperation = "";
        bool isOpearationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (tb_result.Text == "0" || (isOpearationPerformed))
                tb_result.Clear();

            isOpearationPerformed = false;

            Button button = (Button)sender;
            tb_result.Text = tb_result.Text + button.Text;
        }

        private void click_operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                button_equal.PerformClick();
                performedOperation = button.Text;
                label_co.Text = resultValue + " " + performedOperation;
                isOpearationPerformed = true;
            }

            else
            {
                performedOperation = button.Text;
                resultValue = Double.Parse(tb_result.Text);
                label_co.Text = resultValue + " " + performedOperation;
                isOpearationPerformed = true;
            }
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            tb_result.Text = "0";
            resultValue = 0;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            switch(performedOperation)
            {
                case "+":
                    tb_result.Text = (resultValue + Double.Parse(tb_result.Text)).ToString();
                    break;
                case "-":
                    tb_result.Text = (resultValue - Double.Parse(tb_result.Text)).ToString();
                    break;
                case "x":
                    tb_result.Text = (resultValue * Double.Parse(tb_result.Text)).ToString();
                    break;
                case "/":
                    tb_result.Text = (resultValue / Double.Parse(tb_result.Text)).ToString();
                    break;
                default:
                    break;

            }

            resultValue = Double.Parse(tb_result.Text);
            label_co.Text = "";
        }
    }
}
