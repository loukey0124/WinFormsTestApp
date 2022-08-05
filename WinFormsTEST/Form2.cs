using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTEST
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string reset = "";

            tb_result.Enabled = false;
            tb_result.Text = reset;
            tb_num1.Text = reset;
            tb_num2.Text = reset;
        }

        private void calculate(object sender, EventArgs e)
        {
            try
            {
                string btntext = ((Button)sender).Text;
                double num1 = double.Parse(tb_num1.Text);
                double num2 = double.Parse(tb_num2.Text);
                double result = 0;

                switch (btntext)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (0 == num2)
                        {
                            tb_result.Text = "0으로 나눌 수 없습니다.";
                            return;
                        }
                        else
                            result = num1 / num2;
                        break;
                    default:
                        break;
                }
                tb_result.Text = Convert.ToString(result);
                tb_result.Enabled = true;
            }
            catch (FormatException)
            {
                tb_result.Text = "올바른 값을 입력해주세요.";
            }
        }
        /*
private void btn_plus_Click(object sender, EventArgs e)
{

}

private void btn_minus_Click(object sender, EventArgs e)
{
   double num1 = double.Parse(tb_num1.Text);
   double num2 = double.Parse(tb_num2.Text);

   double result = num1 - num2;
   tb_result.Text = Convert.ToString(result);
   tb_result.Enabled = true;
}

private void btn_sub_Click(object sender, EventArgs e)
{
   double num1 = double.Parse(tb_num1.Text);
   double num2 = double.Parse(tb_num2.Text);

   double result = num1 * num2;
   tb_result.Text = Convert.ToString(result);
   tb_result.Enabled = true;
}

private void btn_divide_Click(object sender, EventArgs e)
{
   double num1 = double.Parse(tb_num1.Text);
   double num2 = double.Parse(tb_num2.Text);
   double result;

   if (0 == num2)
       tb_result.Text = "0으로 나눌 수 없습니다.";
   else {
       result = num1 / num2;
       tb_result.Text = Convert.ToString(result);
       tb_result.Enabled = true;
   }
}
*/
    }
}
