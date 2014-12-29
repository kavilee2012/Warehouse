using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Warehouse
{
    public partial class frmBatchUpload : Form
    {
        public frmBatchUpload()
        {
            InitializeComponent();
        }

        private void frmBatchUpload_Load(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string txt = richTextBox1.Text.Trim().Replace("\n","");
            if (!ValidateService.IsAllNumber(txt))
            {
                MessageBox.Show("包含非数字字符，请认真核对！");
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = richTextBox1.Text.Trim();
            if (txt.Length % 14 == 0)
            {
                lab_Cnt.Text = "共 " + txt.Length / 14 + " 条";
            }
        }
    }
}
