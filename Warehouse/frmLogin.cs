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
    public partial class frmLogin : Form
    {

        public static Sunisoft.IrisSkin.SkinEngine se = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinFile = Application.StartupPath + @"\Skin\MP10.ssk";
            txt_UserName.Focus();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string _name = txt_UserName.Text.Trim();
            string _pwd = txt_UserPwd.Text.Trim();
            User user = new User();
            if (user.Login(_name, _pwd))
            {
                user.GetModel(_name);
                if (user.Position == "管理员" || user.Position == "系统管理员")
                {
                    Global.IsAdmin = true;
                }
                Global.userName = _name;
                frmIndex f = new frmIndex();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("登录失败，用户名或者密码错误!");
                return;
            }
        }
    }
}
