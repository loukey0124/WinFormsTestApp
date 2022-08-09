namespace RadioButton
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
            this.gB1 = new System.Windows.Forms.GroupBox();
            this.gB2 = new System.Windows.Forms.GroupBox();
            this.rbAbortRetryIgnore = new System.Windows.Forms.RadioButton();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.rbOKCancel = new System.Windows.Forms.RadioButton();
            this.rbRetryCancel = new System.Windows.Forms.RadioButton();
            this.rbYesNo = new System.Windows.Forms.RadioButton();
            this.rbYesNoCancel = new System.Windows.Forms.RadioButton();
            this.rbAsterisk = new System.Windows.Forms.RadioButton();
            this.rbError = new System.Windows.Forms.RadioButton();
            this.rbExclamation = new System.Windows.Forms.RadioButton();
            this.rbHand = new System.Windows.Forms.RadioButton();
            this.rbInformation = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbQuestion = new System.Windows.Forms.RadioButton();
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbWarning = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.gB1.SuspendLayout();
            this.gB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB1
            // 
            this.gB1.Controls.Add(this.rbYesNoCancel);
            this.gB1.Controls.Add(this.rbYesNo);
            this.gB1.Controls.Add(this.rbRetryCancel);
            this.gB1.Controls.Add(this.rbOKCancel);
            this.gB1.Controls.Add(this.rbOK);
            this.gB1.Controls.Add(this.rbAbortRetryIgnore);
            this.gB1.Location = new System.Drawing.Point(12, 39);
            this.gB1.Name = "gB1";
            this.gB1.Size = new System.Drawing.Size(200, 158);
            this.gB1.TabIndex = 0;
            this.gB1.TabStop = false;
            this.gB1.Text = "groupBox1";
            // 
            // gB2
            // 
            this.gB2.Controls.Add(this.rbWarning);
            this.gB2.Controls.Add(this.rbStop);
            this.gB2.Controls.Add(this.rbQuestion);
            this.gB2.Controls.Add(this.rbNone);
            this.gB2.Controls.Add(this.rbInformation);
            this.gB2.Controls.Add(this.rbHand);
            this.gB2.Controls.Add(this.rbExclamation);
            this.gB2.Controls.Add(this.rbError);
            this.gB2.Controls.Add(this.rbAsterisk);
            this.gB2.Location = new System.Drawing.Point(230, 39);
            this.gB2.Name = "gB2";
            this.gB2.Size = new System.Drawing.Size(200, 221);
            this.gB2.TabIndex = 1;
            this.gB2.TabStop = false;
            this.gB2.Text = "groupBox2";
            // 
            // rbAbortRetryIgnore
            // 
            this.rbAbortRetryIgnore.AutoSize = true;
            this.rbAbortRetryIgnore.Location = new System.Drawing.Point(46, 20);
            this.rbAbortRetryIgnore.Name = "rbAbortRetryIgnore";
            this.rbAbortRetryIgnore.Size = new System.Drawing.Size(116, 16);
            this.rbAbortRetryIgnore.TabIndex = 0;
            this.rbAbortRetryIgnore.TabStop = true;
            this.rbAbortRetryIgnore.Text = "AbortRetryIgnore";
            this.rbAbortRetryIgnore.UseVisualStyleBackColor = true;
            // 
            // rbOK
            // 
            this.rbOK.AutoSize = true;
            this.rbOK.Location = new System.Drawing.Point(46, 42);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(38, 16);
            this.rbOK.TabIndex = 1;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "Ok";
            this.rbOK.UseVisualStyleBackColor = true;
            // 
            // rbOKCancel
            // 
            this.rbOKCancel.AutoSize = true;
            this.rbOKCancel.Location = new System.Drawing.Point(46, 64);
            this.rbOKCancel.Name = "rbOKCancel";
            this.rbOKCancel.Size = new System.Drawing.Size(80, 16);
            this.rbOKCancel.TabIndex = 2;
            this.rbOKCancel.TabStop = true;
            this.rbOKCancel.Text = "OKCancel";
            this.rbOKCancel.UseVisualStyleBackColor = true;
            // 
            // rbRetryCancel
            // 
            this.rbRetryCancel.AutoSize = true;
            this.rbRetryCancel.Location = new System.Drawing.Point(46, 86);
            this.rbRetryCancel.Name = "rbRetryCancel";
            this.rbRetryCancel.Size = new System.Drawing.Size(92, 16);
            this.rbRetryCancel.TabIndex = 3;
            this.rbRetryCancel.TabStop = true;
            this.rbRetryCancel.Text = "RetryCancel";
            this.rbRetryCancel.UseVisualStyleBackColor = true;
            // 
            // rbYesNo
            // 
            this.rbYesNo.AutoSize = true;
            this.rbYesNo.Location = new System.Drawing.Point(46, 108);
            this.rbYesNo.Name = "rbYesNo";
            this.rbYesNo.Size = new System.Drawing.Size(61, 16);
            this.rbYesNo.TabIndex = 4;
            this.rbYesNo.TabStop = true;
            this.rbYesNo.Text = "YesNo";
            this.rbYesNo.UseVisualStyleBackColor = true;
            // 
            // rbYesNoCancel
            // 
            this.rbYesNoCancel.AutoSize = true;
            this.rbYesNoCancel.Location = new System.Drawing.Point(46, 130);
            this.rbYesNoCancel.Name = "rbYesNoCancel";
            this.rbYesNoCancel.Size = new System.Drawing.Size(101, 16);
            this.rbYesNoCancel.TabIndex = 5;
            this.rbYesNoCancel.TabStop = true;
            this.rbYesNoCancel.Text = "YesNoCancel";
            this.rbYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // rbAsterisk
            // 
            this.rbAsterisk.AutoSize = true;
            this.rbAsterisk.Location = new System.Drawing.Point(51, 20);
            this.rbAsterisk.Name = "rbAsterisk";
            this.rbAsterisk.Size = new System.Drawing.Size(68, 16);
            this.rbAsterisk.TabIndex = 0;
            this.rbAsterisk.TabStop = true;
            this.rbAsterisk.Text = "Asterisk";
            this.rbAsterisk.UseVisualStyleBackColor = true;
            // 
            // rbError
            // 
            this.rbError.AutoSize = true;
            this.rbError.Location = new System.Drawing.Point(51, 42);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(50, 16);
            this.rbError.TabIndex = 1;
            this.rbError.TabStop = true;
            this.rbError.Text = "Error";
            this.rbError.UseVisualStyleBackColor = true;
            // 
            // rbExclamation
            // 
            this.rbExclamation.AutoSize = true;
            this.rbExclamation.Location = new System.Drawing.Point(51, 64);
            this.rbExclamation.Name = "rbExclamation";
            this.rbExclamation.Size = new System.Drawing.Size(93, 16);
            this.rbExclamation.TabIndex = 2;
            this.rbExclamation.TabStop = true;
            this.rbExclamation.Text = "Exclamation";
            this.rbExclamation.UseVisualStyleBackColor = true;
            // 
            // rbHand
            // 
            this.rbHand.AutoSize = true;
            this.rbHand.Location = new System.Drawing.Point(51, 86);
            this.rbHand.Name = "rbHand";
            this.rbHand.Size = new System.Drawing.Size(52, 16);
            this.rbHand.TabIndex = 3;
            this.rbHand.TabStop = true;
            this.rbHand.Text = "Hand";
            this.rbHand.UseVisualStyleBackColor = true;
            // 
            // rbInformation
            // 
            this.rbInformation.AutoSize = true;
            this.rbInformation.Location = new System.Drawing.Point(51, 108);
            this.rbInformation.Name = "rbInformation";
            this.rbInformation.Size = new System.Drawing.Size(85, 16);
            this.rbInformation.TabIndex = 4;
            this.rbInformation.TabStop = true;
            this.rbInformation.Text = "Information";
            this.rbInformation.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(51, 130);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(53, 16);
            this.rbNone.TabIndex = 5;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbQuestion
            // 
            this.rbQuestion.AutoSize = true;
            this.rbQuestion.Location = new System.Drawing.Point(51, 152);
            this.rbQuestion.Name = "rbQuestion";
            this.rbQuestion.Size = new System.Drawing.Size(73, 16);
            this.rbQuestion.TabIndex = 6;
            this.rbQuestion.TabStop = true;
            this.rbQuestion.Text = "Question";
            this.rbQuestion.UseVisualStyleBackColor = true;
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(51, 173);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(48, 16);
            this.rbStop.TabIndex = 7;
            this.rbStop.TabStop = true;
            this.rbStop.Text = "Stop";
            this.rbStop.UseVisualStyleBackColor = true;
            // 
            // rbWarning
            // 
            this.rbWarning.AutoSize = true;
            this.rbWarning.Location = new System.Drawing.Point(51, 195);
            this.rbWarning.Name = "rbWarning";
            this.rbWarning.Size = new System.Drawing.Size(68, 16);
            this.rbWarning.TabIndex = 8;
            this.rbWarning.TabStop = true;
            this.rbWarning.Text = "Warning";
            this.rbWarning.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(291, 322);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gB2);
            this.Controls.Add(this.gB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gB1.ResumeLayout(false);
            this.gB1.PerformLayout();
            this.gB2.ResumeLayout(false);
            this.gB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB1;
        private System.Windows.Forms.GroupBox gB2;
        private System.Windows.Forms.RadioButton rbYesNoCancel;
        private System.Windows.Forms.RadioButton rbYesNo;
        private System.Windows.Forms.RadioButton rbRetryCancel;
        private System.Windows.Forms.RadioButton rbOKCancel;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.RadioButton rbAbortRetryIgnore;
        private System.Windows.Forms.RadioButton rbWarning;
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbQuestion;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbInformation;
        private System.Windows.Forms.RadioButton rbHand;
        private System.Windows.Forms.RadioButton rbExclamation;
        private System.Windows.Forms.RadioButton rbError;
        private System.Windows.Forms.RadioButton rbAsterisk;
        private System.Windows.Forms.Button btnShow;
    }
}

