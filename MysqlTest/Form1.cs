using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MysqlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char c = 'A';

            cB_select.Items.Clear();

            while (c <= 'Z')
            {
                cB_select.Items.Add(c);
                c++;
            }
            cB_select.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            int port = 3306;
            string database = "world";
            string uid = "root";
            string pwd = "qwer";
            string connStr = string.Format($"Server = {host}; Port = {port}; Database = {database}; Uid = {uid}; Pwd = {pwd}");

            lv_data.Items.Clear();

            using (MySqlConnection Connection = new MySqlConnection(connStr))
            {
                try
                {
                    //string search = cB_select.Text;
                    //Connection.Open();
                    //string sql = "SELECT * FROM country";
                    //MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    //MySqlDataReader table = cmd.ExecuteReader();

                    //while (table.Read())
                    //{
                    //    if (table["code"].ToString().IndexOf(search, 0, table["code"].ToString().Length) == 0)
                    //    {
                    //        string[] item = { table["code"].ToString(), table["name"].ToString(), string.Format($"{table["population"], 0:N0} 명") };
                    //        ListViewItem listViewItem = new ListViewItem(item);
                    //        lv_data.Items.Add(listViewItem);
                    //    }
                    //}
                    Connection.Open();
                    string sql = string.Format("SELECT * FROM country where code like CONCAT('{0}','%')", cB_select.Text);
                    MySqlCommand cmd = new MySqlCommand(sql, Connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        lv_data.Items.Add(
                            new ListViewItem(
                                new string[] {
                                    string.Format("{0, -4}", table["code"]),
                                    string.Format("{0, -20}", table["name"]),
                                    string.Format("{0, 25:N0}명", table["population"]),
                                }
                            )
                        );
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR");
                }
            }

        }

        private void lv_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_modify.Text = ((ListView)sender).FocusedItem.SubItems[0].Text;
        }
    }
}
