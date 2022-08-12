namespace WinFormsTestApp0811
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
            this.cLB1 = new System.Windows.Forms.CheckedListBox();
            this.btn_moveRight = new System.Windows.Forms.Button();
            this.btn_moveAllRight = new System.Windows.Forms.Button();
            this.btn_moveLeft = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cLB1
            // 
            this.cLB1.CheckOnClick = true;
            this.cLB1.FormattingEnabled = true;
            this.cLB1.Location = new System.Drawing.Point(12, 32);
            this.cLB1.Name = "cLB1";
            this.cLB1.Size = new System.Drawing.Size(200, 340);
            this.cLB1.TabIndex = 0;
            // 
            // btn_moveRight
            // 
            this.btn_moveRight.Location = new System.Drawing.Point(259, 84);
            this.btn_moveRight.Name = "btn_moveRight";
            this.btn_moveRight.Size = new System.Drawing.Size(80, 40);
            this.btn_moveRight.TabIndex = 2;
            this.btn_moveRight.Text = ">";
            this.btn_moveRight.UseVisualStyleBackColor = true;
            this.btn_moveRight.Click += new System.EventHandler(this.btn_moveRight_Click);
            // 
            // btn_moveAllRight
            // 
            this.btn_moveAllRight.Location = new System.Drawing.Point(259, 130);
            this.btn_moveAllRight.Name = "btn_moveAllRight";
            this.btn_moveAllRight.Size = new System.Drawing.Size(80, 40);
            this.btn_moveAllRight.TabIndex = 4;
            this.btn_moveAllRight.Text = ">>>";
            this.btn_moveAllRight.UseVisualStyleBackColor = true;
            this.btn_moveAllRight.Click += new System.EventHandler(this.btn_moveAllRight_Click);
            // 
            // btn_moveLeft
            // 
            this.btn_moveLeft.Location = new System.Drawing.Point(259, 176);
            this.btn_moveLeft.Name = "btn_moveLeft";
            this.btn_moveLeft.Size = new System.Drawing.Size(80, 40);
            this.btn_moveLeft.TabIndex = 5;
            this.btn_moveLeft.Text = "<";
            this.btn_moveLeft.UseVisualStyleBackColor = true;
            this.btn_moveLeft.Click += new System.EventHandler(this.btn_moveLeft_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(259, 285);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(80, 40);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "모두 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(382, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 340);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_moveLeft);
            this.Controls.Add(this.btn_moveAllRight);
            this.Controls.Add(this.btn_moveRight);
            this.Controls.Add(this.cLB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLB1;
        private System.Windows.Forms.Button btn_moveRight;
        private System.Windows.Forms.Button btn_moveAllRight;
        private System.Windows.Forms.Button btn_moveLeft;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox listBox1;
    }
}

