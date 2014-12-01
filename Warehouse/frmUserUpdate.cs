using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frmUserUpdate : Form
    {
        User _m = new User();
        public bool _isTrue = false;

        public frmUserUpdate()
        {
            InitializeComponent();
        }

        public frmUserUpdate(User m)
        {
            InitializeComponent();
            this._m = m;
        }

        private void frmUserUpdate_Load(object sender, EventArgs e)
        {
            lab_ID.Text = _m.UserName;
            cbx_Position.SelectedText = _m.Position;

        }

        private void btn_Modity_Click(object sender, EventArgs e)
        {
            _m.Position = cbx_Position.SelectedItem.ToString();
            if (cbx_Pwd.Checked)
            {
                _m.UserPwd = "123456";
            }
            bool re = _m.Update();
            if (re)
            {
                MessageBox.Show("修改成功!");
                this._isTrue = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败!");
            }
        }
    }
}
