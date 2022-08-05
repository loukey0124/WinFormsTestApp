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
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
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
    }
}