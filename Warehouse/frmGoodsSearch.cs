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
    public partial class frmGoodsSearch : Form
    {
        public frmGoodsSearch()
        {
            InitializeComponent();
        }

        private void frmGoodsSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BindCBX();
            BindDGV();
            cbx_Agent.SelectedIndex = 0;
        }

        private void BindCBX()
        {

            DataSet ds = new Agent().GetCbxList("");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = " ";
                dt.Rows.InsertAt(dr, 0);
                cbx_Agent.DataSource = dt;
                cbx_Agent.DisplayMember = "Name";
                cbx_Agent.ValueMember = "Name";
            }
            else
            {
                MessageBox.Show("请先添加客户资料！");
                return;
            }
        }

        public void BindDGV()
        {
            decimal sumMoney = 0;
            int cnt = 0;
            DataSet ds = new Supply().GetList("");
            DataTable dt = ds.Tables[0];

            foreach (DataRow w in dt.Rows)
            {
                //w.SumPrice = decimal.Parse(w.NormName) * 100 * _price;
                sumMoney += decimal.Parse(w["SumPrice"].ToString());
            }
            lab_Cnt.Text = cnt.ToString();
            lab_Sum.Text = sumMoney.ToString("0.00") + "元";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDetail"].Index)
            {
                e.Value = " 详细";
            }
        }

    }
}
