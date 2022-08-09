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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_add.Text != "")
            {
                checkedListBox1.Items.Add(tb_add.Text);
                tb_add.Text = "";
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(0 != checkedListBox1.Items.Count)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count - 1);
            }
        }

        private void Calc_Load(object sender, EventArgs e)
        {
            string[] itemarr = new string[] { "항목1", "항목2", "항목3", "항목4", "항목5", "항목6", "항목7", "항목8" };
            checkedListBox1.Items.Clear();
            cmb_item.Items.Clear();
            dud_test1.Items.Clear();

            foreach (string item in itemarr)
            {
                checkedListBox1.Items.Add(item);
                cmb_item.Items.Add(item);
                dud_test1.Items.Add(item);
            }
            cmb_item.SelectedIndex = 0;
            dud_test1.SelectedIndex = 0;
        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
            int itemcount = checkedListBox1.Items.Count;
            string search = tb_add.Text;

            for (int i = 0; i < itemcount - 1; i++)
            {
                if (search == checkedListBox1.Items[i].ToString())
                    checkedListBox1.Items.RemoveAt(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("");
                progressBar1.Value = 0;
                btn_start.Enabled = true;
            }
            else
                progressBar1.Value++;
                
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_start.Enabled = false;
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
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
