namespace MysqlTest
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
            this.lv_data = new System.Windows.Forms.ListView();
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.population = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cB_select = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_modify = new System.Windows.Forms.TextBox();
            this.btnmodify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_data
            // 
            this.lv_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code,
            this.name,
            this.population});
            this.lv_data.HideSelection = false;
            this.lv_data.Location = new System.Drawing.Point(15, 100);
            this.lv_data.Name = "lv_data";
            this.lv_data.Size = new System.Drawing.Size(550, 250);
            this.lv_data.TabIndex = 0;
            this.lv_data.UseCompatibleStateImageBehavior = false;
            this.lv_data.View = System.Windows.Forms.View.Details;
            this.lv_data.SelectedIndexChanged += new System.EventHandler(this.lv_data_SelectedIndexChanged);
            // 
            // code
            // 
            this.code.Text = "코드";
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 310;
            // 
            // population
            // 
            this.population.Text = "인구";
            this.population.Width = 150;
            // 
            // cB_select
            // 
            this.cB_select.FormattingEnabled = true;
            this.cB_select.Location = new System.Drawing.Point(30, 41);
            this.cB_select.Name = "cB_select";
            this.cB_select.Size = new System.Drawing.Size(121, 20);
            this.cB_select.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(157, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 50);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "조회";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_modify
            // 
            this.tb_modify.Location = new System.Drawing.Point(318, 41);
            this.tb_modify.Name = "tb_modify";
            this.tb_modify.Size = new System.Drawing.Size(121, 21);
            this.tb_modify.TabIndex = 3;
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(445, 25);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(100, 50);
            this.btnmodify.TabIndex = 4;
            this.btnmodify.Text = "수정";
            this.btnmodify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.tb_modify);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cB_select);
            this.Controls.Add(this.lv_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_data;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader population;
        private System.Windows.Forms.ComboBox cB_select;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_modify;
        private System.Windows.Forms.Button btnmodify;
    }
}

