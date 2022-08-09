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
    public partial class Form1 : Form
    {
        public string parentSend = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modal modal = new Modal();
            DialogResult result = modal.ShowDialog();
            MessageBox.Show($"{result}");
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmmodaldata_Click(object sender, EventArgs e)
        {
            CalcWin calModal = new CalcWin();
            calModal.Owner = this;
            parentSend = txtForm1.Text;
            DialogResult result = calModal.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                textBox1.Text = calModal.myData.dataval.ToString();
                textBox2.Text = calModal.myData.datastr;
            }
            calModal.Dispose();
        }
    }
}