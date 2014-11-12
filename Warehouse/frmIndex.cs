using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {

        }

        private void ShowFrom(Form fm)
        {
            panel1.Controls.Clear();
            fm.MdiParent = this;
            fm.Parent = panel1;
            fm.Dock = DockStyle.Fill;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Show();
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmCustomer());
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmUser());
        }




    }
}
