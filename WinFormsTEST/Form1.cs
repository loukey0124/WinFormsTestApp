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
    }
} 