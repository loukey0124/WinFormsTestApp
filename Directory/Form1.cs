using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Dir_Click(object sender, EventArgs e)
        {
            LB_Dir.Items.Clear();
            string[] dir = Directory.GetDirectories("C:\\Windows");
            foreach(string s in dir)
            {
                LB_Dir.Items.Add(s);
            }
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            LB_File.Items.Clear();
            string[] file;

            if (null == LB_Dir.SelectedItem)
                file = Directory.GetFiles("C:\\Windows");
            else
               file = Directory.GetFiles($"{LB_Dir.SelectedItem.ToString()}");

            foreach (string f in file) {
                LB_File.Items.Add(f);

                FileInfo fi = new FileInfo(f);
                string[] lvItems = { fi.Name, fi.Extension, fi.CreationTime.ToString() };
                LV_Info.Items.Add(new ListViewItem(lvItems));
            }
        }
    }
}
