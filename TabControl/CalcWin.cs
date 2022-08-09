using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class CalcWin : Form
    {
        public MyData myData = new MyData();

        public CalcWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dataVal = int.Parse(textBox1.Text);
            //}
            //catch
            //{
            //    dataVal = 0;
            //}
            //finally
            //{
            //    datastr = textBox1.Text;
            //}
            //Close();

            if (int.TryParse(textBox1.Text, out myData.dataval))
            {
                myData.datastr = textBox1.Text;
                Close();
            }
            else
                MessageBox.Show("숫자입력");
        }

        private void CalcWin_Load(object sender, EventArgs e)
        {
            Form1 parent = (Form1)Owner;
            label1.Text = parent.parentSend;
        }
    }
}
