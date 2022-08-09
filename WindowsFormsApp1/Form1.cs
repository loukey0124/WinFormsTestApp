using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_name.Text == "" || tB_age.Text == "" || tB_job.Text == "")
                MessageBox.Show("값을 모두 입력하세요");
            else
            {
                LView.Items.Add(new ListViewItem(new String[] { tB_name.Text, tB_age.Text, tB_job.Text }));
                tB_name.Clear();
                tB_age.Clear();
                tB_job.Clear();
            }
        }

        private void LView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LView.FocusedItem.Index;

            tB_name.Text = LView.Items[index].SubItems[0].Text;
            tB_age.Text = LView.Items[index].SubItems[1].Text;
            tB_job.Text = LView.Items[index].SubItems[2].Text;
            tB_name.Enabled = false;
        }
    }
}
