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
    public partial class frmUpdatePwd : Form
    {
        public frmUpdatePwd()
        {
            InitializeComponent();
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            string _old = txt_Old.Text.Trim();
            string _new = txt_New.Text.Trim();

            if (_old == string.Empty || _new == string.Empty)
            {
                MessageBox.Show("不能为空!");
                return;
            }
            User user = new User();
            user.GetModel(Global.userName);
            if (user.UserPwd != _old)
            {
                MessageBox.Show("原密码错误!");
                return;
            }
            else
            {
                user.UserPwd = _new;
                bool re = user.Update();
                if (re)
                {
                    MessageBox.Show("修改成功!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败!");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
