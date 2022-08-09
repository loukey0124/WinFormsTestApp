namespace WindowsFormsApp1
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
            this.btn_add = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_age = new System.Windows.Forms.TextBox();
            this.tB_job = new System.Windows.Forms.TextBox();
            this.L_name = new System.Windows.Forms.Label();
            this.L_age = new System.Windows.Forms.Label();
            this.L_job = new System.Windows.Forms.Label();
            this.LView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(305, 197);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(89, 197);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(150, 21);
            this.tB_name.TabIndex = 1;
            // 
            // tB_age
            // 
            this.tB_age.Location = new System.Drawing.Point(89, 227);
            this.tB_age.Name = "tB_age";
            this.tB_age.Size = new System.Drawing.Size(150, 21);
            this.tB_age.TabIndex = 2;
            // 
            // tB_job
            // 
            this.tB_job.Location = new System.Drawing.Point(89, 257);
            this.tB_job.Name = "tB_job";
            this.tB_job.Size = new System.Drawing.Size(150, 21);
            this.tB_job.TabIndex = 3;
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Location = new System.Drawing.Point(45, 200);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(29, 12);
            this.L_name.TabIndex = 4;
            this.L_name.Text = "이름";
            // 
            // L_age
            // 
            this.L_age.AutoSize = true;
            this.L_age.Location = new System.Drawing.Point(45, 230);
            this.L_age.Name = "L_age";
            this.L_age.Size = new System.Drawing.Size(29, 12);
            this.L_age.TabIndex = 5;
            this.L_age.Text = "나이";
            // 
            // L_job
            // 
            this.L_job.AutoSize = true;
            this.L_job.Location = new System.Drawing.Point(45, 260);
            this.L_job.Name = "L_job";
            this.L_job.Size = new System.Drawing.Size(29, 12);
            this.L_job.TabIndex = 6;
            this.L_job.Text = "직업";
            // 
            // LView
            // 
            this.LView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.age,
            this.job});
            this.LView.HideSelection = false;
            this.LView.Location = new System.Drawing.Point(45, 30);
            this.LView.Name = "LView";
            this.LView.Size = new System.Drawing.Size(400, 150);
            this.LView.TabIndex = 7;
            this.LView.UseCompatibleStateImageBehavior = false;
            this.LView.View = System.Windows.Forms.View.Details;
            this.LView.SelectedIndexChanged += new System.EventHandler(this.LView_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 135;
            // 
            // age
            // 
            this.age.Text = "나이";
            // 
            // job
            // 
            this.job.Text = "직업";
            this.job.Width = 200;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(305, 249);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "수정";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.LView);
            this.Controls.Add(this.L_job);
            this.Controls.Add(this.L_age);
            this.Controls.Add(this.L_name);
            this.Controls.Add(this.tB_job);
            this.Controls.Add(this.tB_age);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_age;
        private System.Windows.Forms.TextBox tB_job;
        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.Label L_age;
        private System.Windows.Forms.Label L_job;
        private System.Windows.Forms.ListView LView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader job;
        private System.Windows.Forms.Button btn_edit;
    }
}

