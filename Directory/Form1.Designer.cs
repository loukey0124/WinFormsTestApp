namespace dir
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
            this.btn_Dir = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.LB_Dir = new System.Windows.Forms.ListBox();
            this.LB_File = new System.Windows.Forms.ListBox();
            this.LV_Info = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_Dir
            // 
            this.btn_Dir.Location = new System.Drawing.Point(340, 12);
            this.btn_Dir.Name = "btn_Dir";
            this.btn_Dir.Size = new System.Drawing.Size(125, 50);
            this.btn_Dir.TabIndex = 0;
            this.btn_Dir.Text = "디렉터리 목록";
            this.btn_Dir.UseVisualStyleBackColor = true;
            this.btn_Dir.Click += new System.EventHandler(this.btn_Dir_Click);
            // 
            // btn_File
            // 
            this.btn_File.Location = new System.Drawing.Point(340, 214);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(125, 50);
            this.btn_File.TabIndex = 1;
            this.btn_File.Text = "파일 목록";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // LB_Dir
            // 
            this.LB_Dir.FormattingEnabled = true;
            this.LB_Dir.ItemHeight = 12;
            this.LB_Dir.Location = new System.Drawing.Point(12, 12);
            this.LB_Dir.Name = "LB_Dir";
            this.LB_Dir.Size = new System.Drawing.Size(300, 196);
            this.LB_Dir.TabIndex = 2;
            // 
            // LB_File
            // 
            this.LB_File.FormattingEnabled = true;
            this.LB_File.ItemHeight = 12;
            this.LB_File.Location = new System.Drawing.Point(12, 214);
            this.LB_File.Name = "LB_File";
            this.LB_File.Size = new System.Drawing.Size(300, 196);
            this.LB_File.TabIndex = 3;
            // 
            // LV_Info
            // 
            this.LV_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chExt,
            this.chCreate});
            this.LV_Info.HideSelection = false;
            this.LV_Info.Location = new System.Drawing.Point(12, 416);
            this.LV_Info.Name = "LV_Info";
            this.LV_Info.Size = new System.Drawing.Size(300, 197);
            this.LV_Info.TabIndex = 4;
            this.LV_Info.UseCompatibleStateImageBehavior = false;
            this.LV_Info.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "파일명";
            this.chName.Width = 150;
            // 
            // chExt
            // 
            this.chExt.Text = "확장자";
            // 
            // chCreate
            // 
            this.chCreate.Text = "생성일자";
            this.chCreate.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 625);
            this.Controls.Add(this.LV_Info);
            this.Controls.Add(this.LB_File);
            this.Controls.Add(this.LB_Dir);
            this.Controls.Add(this.btn_File);
            this.Controls.Add(this.btn_Dir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Dir;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.ListBox LB_Dir;
        private System.Windows.Forms.ListBox LB_File;
        private System.Windows.Forms.ListView LV_Info;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chExt;
        private System.Windows.Forms.ColumnHeader chCreate;
    }
}

