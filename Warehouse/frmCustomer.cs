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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cbx_Level.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            BindLevel();
            BindDGV();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Agent model = new Agent();

            string _name = txt_Name.Text.Trim();
            if (string.IsNullOrEmpty(_name))
            {
                MessageBox.Show("客户名称不能为空!");
                txt_Name.Focus();
                return;
            }
            if (model.Exists(_name))
            {
                MessageBox.Show("该客户名称已存在!");
                txt_Name.Focus();
                return;
            }
            model.Name = _name;
            model.LevelName = cbx_Level.SelectedValue.ToString();
            model.Contact = txt_Contact.Text.Trim();
            model.Phone = txt_Phone.Text.Trim();
            model.Address = txt_Address.Text.Trim();
            int re = model.Add();
            if (re > 0)
            {
                MessageBox.Show("添加成功!");
                txt_Name.Text = "";
                cbx_Level.SelectedIndex = 0;
                txt_Name.Focus();
                txt_Contact.Text = "";
                txt_Phone.Text = "";
                txt_Address.Text = "";
                BindDGV();
            }
            else
            {
                MessageBox.Show("添加失败!");
            }
        }

        private void BindDGV()
        {
            DataSet ds = new Agent().GetList("");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BindLevel()
        {
            DataSet ds = new Level().GetList("");
            cbx_Level.DataSource = ds.Tables[0];
            cbx_Level.ValueMember = "LevelName";
            cbx_Level.DisplayMember = "LevelName";
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

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                if (MessageBox.Show(this, "确定要删除吗?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    object v = dataGridView1.Rows[e.RowIndex].Cells["cName"].Value;
                    if (v != null)
                    {
                        Agent no = new Agent();
                        bool re = no.Delete(v.ToString());
                        if (re)
                        {
                            MessageBox.Show("删除成功!");
                            BindDGV();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
