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
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcute = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Label();
            this.Replace_Text = new System.Windows.Forms.Label();
            this.Length_Text = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.Label();
            this.ToLower = new System.Windows.Forms.Label();
            this.ToLower_Text = new System.Windows.Forms.Label();
            this.Equals_Text = new System.Windows.Forms.Label();
            this.Equal = new System.Windows.Forms.Label();
            this.Trim = new System.Windows.Forms.Label();
            this.Trim_Text = new System.Windows.Forms.Label();
            this.ToUpper_Text = new System.Windows.Forms.Label();
            this.ToUpper = new System.Windows.Forms.Label();
            this.Split = new System.Windows.Forms.Label();
            this.Split_Text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 23);
            this.textBox1.TabIndex = 0;
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
            this.Substring.Text = "Substring\r\n(3.5)";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(182, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "(label)WinForm_StringTest";
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
            // Replace
            // 
            this.Replace.AutoSize = true;
            this.Replace.Location = new System.Drawing.Point(49, 240);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(48, 15);
            this.Replace.TabIndex = 11;
            this.Replace.Text = "Replace";
            // 
            // Replace_Text
            // 
            this.Replace_Text.AutoSize = true;
            this.Replace_Text.Location = new System.Drawing.Point(118, 240);
            this.Replace_Text.Name = "Replace_Text";
            this.Replace_Text.Size = new System.Drawing.Size(12, 15);
            this.Replace_Text.TabIndex = 10;
            this.Replace_Text.Text = "-";
            // 
            // Length_Text
            // 
            this.Length_Text.AutoSize = true;
            this.Length_Text.Location = new System.Drawing.Point(118, 198);
            this.Length_Text.Name = "Length_Text";
            this.Length_Text.Size = new System.Drawing.Size(12, 15);
            this.Length_Text.TabIndex = 9;
            this.Length_Text.Text = "-";
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Location = new System.Drawing.Point(49, 198);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(44, 15);
            this.Length.TabIndex = 8;
            this.Length.Text = "Length";
            // 
            // ToLower
            // 
            this.ToLower.AutoSize = true;
            this.ToLower.Location = new System.Drawing.Point(175, 148);
            this.ToLower.Name = "ToLower";
            this.ToLower.Size = new System.Drawing.Size(52, 15);
            this.ToLower.TabIndex = 15;
            this.ToLower.Text = "ToLower";
            // 
            // ToLower_Text
            // 
            this.ToLower_Text.AutoSize = true;
            this.ToLower_Text.Location = new System.Drawing.Point(244, 148);
            this.ToLower_Text.Name = "ToLower_Text";
            this.ToLower_Text.Size = new System.Drawing.Size(12, 15);
            this.ToLower_Text.TabIndex = 14;
            this.ToLower_Text.Text = "-";
            // 
            // Equals_Text
            // 
            this.Equals_Text.AutoSize = true;
            this.Equals_Text.Location = new System.Drawing.Point(118, 148);
            this.Equals_Text.Name = "Equals_Text";
            this.Equals_Text.Size = new System.Drawing.Size(12, 15);
            this.Equals_Text.TabIndex = 13;
            this.Equals_Text.Text = "-";
            // 
            // Equal
            // 
            this.Equal.AutoSize = true;
            this.Equal.Location = new System.Drawing.Point(49, 148);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(41, 15);
            this.Equal.TabIndex = 12;
            this.Equal.Text = "Equals";
            // 
            // Trim
            // 
            this.Trim.AutoSize = true;
            this.Trim.Location = new System.Drawing.Point(175, 240);
            this.Trim.Name = "Trim";
            this.Trim.Size = new System.Drawing.Size(31, 15);
            this.Trim.TabIndex = 19;
            this.Trim.Text = "Trim";
            // 
            // Trim_Text
            // 
            this.Trim_Text.AutoSize = true;
            this.Trim_Text.Location = new System.Drawing.Point(244, 240);
            this.Trim_Text.Name = "Trim_Text";
            this.Trim_Text.Size = new System.Drawing.Size(12, 15);
            this.Trim_Text.TabIndex = 18;
            this.Trim_Text.Text = "-";
            // 
            // ToUpper_Text
            // 
            this.ToUpper_Text.AutoSize = true;
            this.ToUpper_Text.Location = new System.Drawing.Point(244, 198);
            this.ToUpper_Text.Name = "ToUpper_Text";
            this.ToUpper_Text.Size = new System.Drawing.Size(12, 15);
            this.ToUpper_Text.TabIndex = 17;
            this.ToUpper_Text.Text = "-";
            // 
            // ToUpper
            // 
            this.ToUpper.AutoSize = true;
            this.ToUpper.Location = new System.Drawing.Point(175, 198);
            this.ToUpper.Name = "ToUpper";
            this.ToUpper.Size = new System.Drawing.Size(52, 15);
            this.ToUpper.TabIndex = 16;
            this.ToUpper.Text = "ToUpper";
            // 
            // Split
            // 
            this.Split.AutoSize = true;
            this.Split.Location = new System.Drawing.Point(49, 282);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(31, 15);
            this.Split.TabIndex = 21;
            this.Split.Text = "Split";
            // 
            // Split_Text
            // 
            this.Split_Text.AutoSize = true;
            this.Split_Text.Location = new System.Drawing.Point(118, 282);
            this.Split_Text.Name = "Split_Text";
            this.Split_Text.Size = new System.Drawing.Size(12, 15);
            this.Split_Text.TabIndex = 20;
            this.Split_Text.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Split);
            this.Controls.Add(this.Split_Text);
            this.Controls.Add(this.Trim);
            this.Controls.Add(this.Trim_Text);
            this.Controls.Add(this.ToUpper_Text);
            this.Controls.Add(this.ToUpper);
            this.Controls.Add(this.ToLower);
            this.Controls.Add(this.ToLower_Text);
            this.Controls.Add(this.Equals_Text);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Replace_Text);
            this.Controls.Add(this.Length_Text);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.label5);
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
        private Label label5;
        private Button btnExcute;
        private Label Replace;
        private Label Replace_Text;
        private Label Length_Text;
        private Label Length;
        private Label ToLower;
        private Label ToLower_Text;
        private Label Equals_Text;
        private Label Equal;
        private Label Trim;
        private Label Trim_Text;
        private Label ToUpper_Text;
        private Label ToUpper;
        private Label Split;
        private Label Split_Text;
        private Label label1;
    }
}