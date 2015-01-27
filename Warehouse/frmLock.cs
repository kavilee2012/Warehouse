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
    public partial class frmLock : Form
    {
        private bool _NeedExit = true;
        public frmLock()
        {
            InitializeComponent();
        }

        private void frmLock_Load(object sender, EventArgs e)
        {
            txt_UserName.Text = Global.userName;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string _name = txt_UserName.Text.Trim();
            string _pwd = txt_UserPwd.Text.Trim();
            User user = new User();
            if (user.Login(_name, _pwd))
            {
                Owner.Show();
                _NeedExit = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败，用户名或者密码错误!");
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && _NeedExit)
            {
                Application.Exit();
            }
        }


    }
}
