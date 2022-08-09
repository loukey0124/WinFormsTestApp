using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Event1.Text = "(버튼 누름) 좌표 : " + e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Event1.Text = "(버튼 놓음) 좌표 : " + e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Event3.Text = e.Location.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Event2.Text = "(버튼 클릭) 좌표 : " + e.Location;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Event2.Text = "(버튼 더블클릭) 좌표 : " + e.Location;
        }
    }
}
