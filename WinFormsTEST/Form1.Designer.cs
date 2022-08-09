namespace WinFormsTEST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Contain = new System.Windows.Forms.Label();
            this.Contain_Text = new System.Windows.Forms.Label();
            this.Substring = new System.Windows.Forms.Label();
            this.Substring_Text = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnExcute = new System.Windows.Forms.Button();
            this.chkTest1 = new System.Windows.Forms.CheckBox();
            this.chkListTest1 = new System.Windows.Forms.CheckedListBox();
            this.cmbTest1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(550, 125);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(150, 25);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "초기화";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Contain
            // 
            this.Contain.AutoSize = true;
            this.Contain.Location = new System.Drawing.Point(49, 106);
            this.Contain.Name = "Contain";
            this.Contain.Size = new System.Drawing.Size(49, 15);
            this.Contain.TabIndex = 2;
            this.Contain.Text = "Contain";
            // 
            // Contain_Text
            // 
            this.Contain_Text.AutoSize = true;
            this.Contain_Text.Location = new System.Drawing.Point(118, 106);
            this.Contain_Text.Name = "Contain_Text";
            this.Contain_Text.Size = new System.Drawing.Size(12, 15);
            this.Contain_Text.TabIndex = 3;
            this.Contain_Text.Text = "-";
            // 
            // Substring
            // 
            this.Substring.AutoSize = true;
            this.Substring.Location = new System.Drawing.Point(175, 106);
            this.Substring.Name = "Substring";
            this.Substring.Size = new System.Drawing.Size(58, 30);
            this.Substring.TabIndex = 5;
            this.Substring.Text = "Substring\r\n(3,5)";
            // 
            // Substring_Text
            // 
            this.Substring_Text.AutoSize = true;
            this.Substring_Text.Location = new System.Drawing.Point(244, 106);
            this.Substring_Text.Name = "Substring_Text";
            this.Substring_Text.Size = new System.Drawing.Size(12, 15);
            this.Substring_Text.TabIndex = 4;
            this.Substring_Text.Text = "-";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(182, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(164, 32);
            this.Title.TabIndex = 6;
            this.Title.Text = "WinForm Test";
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(550, 50);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(150, 50);
            this.btnExcute.TabIndex = 7;
            this.btnExcute.Text = "(button)\r\n실행";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // chkTest1
            // 
            this.chkTest1.AutoSize = true;
            this.chkTest1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkTest1.Location = new System.Drawing.Point(410, 253);
            this.chkTest1.Name = "chkTest1";
            this.chkTest1.Size = new System.Drawing.Size(85, 19);
            this.chkTest1.TabIndex = 8;
            this.chkTest1.Text = "체크선택 1";
            this.chkTest1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTest1.UseVisualStyleBackColor = false;
            this.chkTest1.CheckedChanged += new System.EventHandler(this.chkTest1_CheckedChanged);
            this.chkTest1.Click += new System.EventHandler(this.chkTest1_Click);
            // 
            // chkListTest1
            // 
            this.chkListTest1.FormattingEnabled = true;
            this.chkListTest1.Items.AddRange(new object[] {
            "테스트1",
            "테스트2",
            "테스트3"});
            this.chkListTest1.Location = new System.Drawing.Point(588, 253);
            this.chkListTest1.Name = "chkListTest1";
            this.chkListTest1.Size = new System.Drawing.Size(69, 94);
            this.chkListTest1.TabIndex = 9;
            this.chkListTest1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListTest1_ItemCheck);
            this.chkListTest1.SelectedIndexChanged += new System.EventHandler(this.chkListTest1_SelectedIndexChanged);
            // 
            // cmbTest1
            // 
            this.cmbTest1.FormattingEnabled = true;
            this.cmbTest1.Items.AddRange(new object[] {
            "항목1",
            "항목2",
            "항목3"});
            this.cmbTest1.Location = new System.Drawing.Point(259, 316);
            this.cmbTest1.Name = "cmbTest1";
            this.cmbTest1.Size = new System.Drawing.Size(121, 23);
            this.cmbTest1.TabIndex = 10;
            this.cmbTest1.SelectedIndexChanged += new System.EventHandler(this.cmbTest1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(249, 384);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(83, 351);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 12;
            this.Calc.Text = "계산기";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbTest1);
            this.Controls.Add(this.chkListTest1);
            this.Controls.Add(this.chkTest1);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Substring);
            this.Controls.Add(this.Substring_Text);
            this.Controls.Add(this.Contain_Text);
            this.Controls.Add(this.Contain);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button Reset;
        private Label Contain;
        private Label Contain_Text;
        private Label Substring;
        private Label Substring_Text;
        private Label Title;
        private Button btnExcute;
        private CheckBox chkTest1;
        private CheckedListBox chkListTest1;
        private ComboBox cmbTest1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Calc;
    }
}