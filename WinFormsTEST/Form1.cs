namespace WinFormsTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            string inputStr = textBox1.Text;
            char findChar = 'c';
            int subIndex = 3;
            int subLen = 5;

            Contain_Text.Text = inputStr.Contains(findChar).ToString();
            if (inputStr.Length >= subLen + subIndex)
                Substring_Text.Text = inputStr.Substring(subIndex, subLen);            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Contain_Text.Text = "-";
            Substring_Text.Text = "-";
        }

        private void chkTest1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckedChange:" + chkTest1.Checked + ":" + chkTest1.CheckState);
        }

        private void chkTest1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click:" + chkTest1.Checked + ":" + chkTest1.CheckState);
            chkTest1.Checked = !chkTest1.Checked;
        }

        private void chkListTest1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("ItemCheck : " + chkListTest1.CheckedIndices.Count + " : " + chkListTest1.CheckedItems);
        }

        private void chkListTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SelectedIndexChanged : " + chkListTest1.CheckedIndices + " : " + chkListTest1.CheckedItems);
        }

        private void cmbTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("cmbTest1 Click : " + cmbTest1.SelectedItem);
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }
    }
} 