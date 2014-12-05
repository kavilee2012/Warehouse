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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            toolStatus_Time.Text = "当前用户：" + Global.userName + "    登录时间：" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        public void ShowFrom(Form fm)
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

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void 成品规格维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsNorm());
        }

        private void 代理商级别维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmAgentNorm());
        }

        private void 成品入仓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsIn());
        }

        private void 成品出仓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsOut());
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsSearch());
        }

        private void 修改个人密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmUpdatePwd f = new frmUpdatePwd();
             f.ShowDialog();
        }

        private void 库存查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmWarehouseView());
        }

        private void 统计查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmStatistics());
        }




    }
}
