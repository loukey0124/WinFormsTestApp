namespace WinFormsTEST
{
    partial class Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.hsb_test1 = new System.Windows.Forms.HScrollBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_step = new System.Windows.Forms.Button();
            this.dud_test1 = new System.Windows.Forms.DomainUpDown();
            this.nud_test1 = new System.Windows.Forms.NumericUpDown();
            this.dtpcik = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_test1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_result
            // 
            this.tb_result.Enabled = false;
            this.tb_result.Location = new System.Drawing.Point(60, 43);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(245, 23);
            this.tb_result.TabIndex = 0;
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(60, 105);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 23);
            this.tb_num1.TabIndex = 1;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(239, 105);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 23);
            this.tb_num2.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(12, 46);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(39, 20);
            this.result.TabIndex = 3;
            this.result.Text = "결과";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1.Location = new System.Drawing.Point(12, 105);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(32, 20);
            this.num1.TabIndex = 4;
            this.num1.Text = "값1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2.Location = new System.Drawing.Point(189, 105);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(32, 20);
            this.num2.TabIndex = 5;
            this.num2.Text = "값2";
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_plus.Location = new System.Drawing.Point(16, 162);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 75);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.calculate);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_minus.Location = new System.Drawing.Point(106, 162);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 75);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.calculate);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sub.Location = new System.Drawing.Point(196, 162);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 75);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "*";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.calculate);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Consolas", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_divide.Location = new System.Drawing.Point(286, 162);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 75);
            this.btn_divide.TabIndex = 9;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.calculate);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(311, 42);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(50, 25);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 263);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 58);
            this.checkedListBox1.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(294, 263);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(142, 263);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(146, 23);
            this.tb_add.TabIndex = 13;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(294, 292);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "삭제";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(294, 321);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(75, 23);
            this.btn_remove2.TabIndex = 15;
            this.btn_remove2.Text = "지우기";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(16, 327);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(121, 23);
            this.cmb_item.TabIndex = 16;
            // 
            // hsb_test1
            // 
            this.hsb_test1.Location = new System.Drawing.Point(16, 369);
            this.hsb_test1.Maximum = 200;
            this.hsb_test1.Name = "hsb_test1";
            this.hsb_test1.Size = new System.Drawing.Size(226, 42);
            this.hsb_test1.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 438);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(294, 438);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 19;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_step
            // 
            this.btn_step.Location = new System.Drawing.Point(294, 467);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(75, 23);
            this.btn_step.TabIndex = 20;
            this.btn_step.Text = "Step";
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // dud_test1
            // 
            this.dud_test1.Location = new System.Drawing.Point(413, 42);
            this.dud_test1.Name = "dud_test1";
            this.dud_test1.Size = new System.Drawing.Size(120, 23);
            this.dud_test1.TabIndex = 21;
            // 
            // nud_test1
            // 
            this.nud_test1.Location = new System.Drawing.Point(413, 83);
            this.nud_test1.Name = "nud_test1";
            this.nud_test1.Size = new System.Drawing.Size(120, 23);
            this.nud_test1.TabIndex = 22;
            // 
            // dtpcik
            // 
            this.dtpcik.Location = new System.Drawing.Point(377, 122);
            this.dtpcik.Name = "dtpcik";
            this.dtpcik.Size = new System.Drawing.Size(200, 23);
            this.dtpcik.TabIndex = 23;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(377, 162);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 23);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 502);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dtpcik);
            this.Controls.Add(this.nud_test1);
            this.Controls.Add(this.dud_test1);
            this.Controls.Add(this.btn_step);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.hsb_test1);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.tb_result);
            this.Name = "Calc";
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Calc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_test1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_result;
        private TextBox tb_num1;
        private TextBox tb_num2;
        private Label result;
        private Label num1;
        private Label num2;
        private Button btn_plus;
        private Button btn_minus;
        private Button btn_sub;
        private Button btn_divide;
        private Button btn_reset;
        private CheckedListBox checkedListBox1;
        private Button btn_add;
        private TextBox tb_add;
        private Button btn_remove;
        private Button btn_remove2;
        private ComboBox cmb_item;
        private HScrollBar hsb_test1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_start;
        private Button btn_step;
        private DomainUpDown dud_test1;
        private NumericUpDown nud_test1;
        private DateTimePicker dtpcik;
        private MaskedTextBox maskedTextBox1;
    }
}