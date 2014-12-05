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
    public partial class frmAgentNorm : Form
    {
        public frmAgentNorm()
        {
            InitializeComponent();
        }

        private void frmAgentNorm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BindDGV();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Level user = new Level();

            string _name = txt_Name.Text.Trim();
            if (string.IsNullOrEmpty(_name))
            {
                MessageBox.Show("名称不能为空!");
                txt_Name.Focus();
                return;
            }
            if (user.Exists(_name))
            {
                MessageBox.Show("该名称已存在!");
                txt_Name.Focus();
                return;
            }
            string _price = txt_Price.Text.Trim();
            if (!ValidateService.IsNumber(_price))
            {
                MessageBox.Show("价格格式不正确!");
                txt_Price.Focus();
                return;
            }

            user.LevelName = _name;
            user.Price = decimal.Parse(_price);
            int re = user.Add();
            if (re > 0)
            {
                MessageBox.Show("添加成功!");
                txt_Name.Text = "";
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
            DataSet ds = new Level().GetList("");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cModity"].Index)
            {
                e.Value = "修改价格";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = "删除";
            }
            //else if (e.ColumnIndex == dataGridView1.Columns["cPrice"].Index)
            //{
            //    e.Value = e.Value + "元";
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                if (MessageBox.Show(this, "确定要删除吗?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    object v = dataGridView1.Rows[e.RowIndex].Cells["cName"].Value;
                    if (v!=null)
                    {
                        Level no = new Level();
                        if (no.IsRelation(v.ToString()))
                        {
                            MessageBox.Show("该记录已被使用，禁止删除！");
                            return;
                        }
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
            else if (e.ColumnIndex == dataGridView1.Columns["cModity"].Index)
            {
                object v = dataGridView1.Rows[e.RowIndex].Cells["cName"].Value;
                if (ValidateService.IsNotEmpty(v))
                {
                    Level no = new Level();
                    no.GetModel(v.ToString());
                    frmAgentNormUpdate f = new frmAgentNormUpdate(no);
                    f.ShowDialog();
                    if (f._isTrue)
                    {
                        BindDGV();
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
