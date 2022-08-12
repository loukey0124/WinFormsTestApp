namespace DateCalc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_selectDay = new System.Windows.Forms.Label();
            this.lb_notice1 = new System.Windows.Forms.Label();
            this.lb_notice2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lb_selectDay
            // 
            this.lb_selectDay.AutoSize = true;
            this.lb_selectDay.Location = new System.Drawing.Point(25, 25);
            this.lb_selectDay.Name = "lb_selectDay";
            this.lb_selectDay.Size = new System.Drawing.Size(105, 12);
            this.lb_selectDay.TabIndex = 1;
            this.lb_selectDay.Text = "날짜를 선택하세요";
            // 
            // lb_notice1
            // 
            this.lb_notice1.AutoSize = true;
            this.lb_notice1.Location = new System.Drawing.Point(25, 175);
            this.lb_notice1.Name = "lb_notice1";
            this.lb_notice1.Size = new System.Drawing.Size(93, 12);
            this.lb_notice1.TabIndex = 3;
            this.lb_notice1.Text = "선택한 날짜부터";
            // 
            // lb_notice2
            // 
            this.lb_notice2.AutoSize = true;
            this.lb_notice2.Location = new System.Drawing.Point(175, 175);
            this.lb_notice2.Name = "lb_notice2";
            this.lb_notice2.Size = new System.Drawing.Size(97, 12);
            this.lb_notice2.TabIndex = 4;
            this.lb_notice2.Text = "일이 지났습니다.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 21);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lb_notice2);
            this.Controls.Add(this.lb_notice1);
            this.Controls.Add(this.lb_selectDay);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_selectDay;
        private System.Windows.Forms.Label lb_notice1;
        private System.Windows.Forms.Label lb_notice2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

