using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbb = MessageBoxButtons.AbortRetryIgnore;
            MessageBoxIcon mbi = MessageBoxIcon.Asterisk;

            if (rbAbortRetryIgnore.Checked)
                mbb = MessageBoxButtons.AbortRetryIgnore;
            else if (rbOK.Checked)
                mbb = MessageBoxButtons.OK;
            else if (rbOKCancel.Checked)
                mbb = MessageBoxButtons.OKCancel;
            else if (rbRetryCancel.Checked)
                mbb = MessageBoxButtons.RetryCancel;
            else if (rbYesNo.Checked)
                mbb = MessageBoxButtons.YesNo;
            else
                mbb = MessageBoxButtons.YesNoCancel;

            if (rbAsterisk.Checked)
                mbi = MessageBoxIcon.Asterisk;
            else if (rbError.Checked)
                mbi = MessageBoxIcon.Error;
            else if (rbExclamation.Checked)
                mbi = MessageBoxIcon.Exclamation;
            else if (rbHand.Checked)
                mbi = MessageBoxIcon.Hand;
            else if (rbInformation.Checked)
                mbi = MessageBoxIcon.Information;
            else if (rbNone.Checked)
                mbi = MessageBoxIcon.None;
            else if (rbQuestion.Checked)
                mbi = MessageBoxIcon.None;
            else if (rbQuestion.Checked)
                mbi = MessageBoxIcon.Question;
            else if (rbStop.Checked)
                mbi = MessageBoxIcon.Stop;
            else
                mbi = MessageBoxIcon.Warning;

            MessageBox.Show("", "", mbb, mbi);
        }
    }
}
