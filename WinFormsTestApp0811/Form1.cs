using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTestApp0811
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strings = { "123", "234", "345", "456", "567" };
            cLB1.Items.Clear();
            foreach (string s in strings)
                cLB1.Items.Add(s);
        }

        private void btn_moveRight_Click(object sender, EventArgs e)
        {
            var item = cLB1.CheckedItems;
            foreach(var i in item)
                listBox1.Items.Add(i);
        }

        private void btn_moveAllRight_Click(object sender, EventArgs e)
        {
            int index = cLB1.Items.Count;
            for (int i = 0; i < index; i++)
                listBox1.Items.Add(cLB1.Items[i].ToString());
        }

        private void btn_moveLeft_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
