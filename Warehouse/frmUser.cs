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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            //DataTable dt = CommonService.GeneralDataTable();
            //dataGridView1.DataSource = dt;
            cbx_Position.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            BindDGV();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            User user = new User();

            string _name = txt_Name.Text.Trim();
            if (string.IsNullOrEmpty(_name))
            {
                MessageBox.Show("用户名不能为空!");
                txt_Name.Focus();
                return;
            }
            if (user.Exists(_name))
            {
                MessageBox.Show("该用户名已存在!");
                txt_Name.Focus();
                return;
            }
            user.UserName = _name;
            user.Position = cbx_Position.SelectedItem.ToString();
           int re = user.Add();
           if (re > 0)
           {
               MessageBox.Show("添加成功!");
               txt_Name.Text = "";
               cbx_Position.SelectedIndex = 0;
               txt_Name.Focus();
               BindDGV();
           }
           else
           {
               MessageBox.Show("添加失败!");
           }
        }

        private void BindDGV()
        {
            DataSet ds = new User().GetList("");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cModity"].Index)
            {
                e.Value = "修改";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = " 删除";
            }
        }
    }
}
