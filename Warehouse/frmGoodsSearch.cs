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
        string _sqlWhere = "";

        public frmGoodsSearch()
        {
            InitializeComponent();
        }

        private void frmGoodsSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BindCBX();
            //BindDGV();
            cbx_Agent.SelectedIndex = 0;

            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            BindDGV();

            //btn_Search.PerformClick();
        }

        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            BindDGV();
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
            
            //int cnt = 0;
            //foreach (DataRow w in dt.Rows)
            //{
            //    sumMoney += decimal.Parse(w["SumPrice"].ToString());
            //}
            //cnt = dt.Rows.Count;


            decimal _sumMoney = 0;
            int _count = 0;
            Supply s = new Supply();
            DataSet ds = s.GetPageList(pagerControl1.PageSize, pagerControl1.PageIndex, _sqlWhere, out _count,out _sumMoney);//s.GetFilterList(sqlWhere);
            pagerControl1.DrawControl(_count);

            lab_Cnt.Text = _count.ToString();
            lab_Sum.Text = _sumMoney.ToString("0.00") + "元";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string _id = txt_SupplyNo.Text.Trim();
            string _agent = cbx_Agent.SelectedValue.ToString().Trim();
            string _barcode = txt_Barcode.Text.Trim();

            string sqlWhere = "";
            if (!string.IsNullOrEmpty(_id))
            {
                sqlWhere += " SupplyID LIKE'%" + _id + "%' AND";
            }
            if (!string.IsNullOrEmpty(_agent))
            {
                sqlWhere += " AgentName='" + _agent + "' AND";
            }
            if (!string.IsNullOrEmpty(_barcode))
            {
                sqlWhere += " SupplyID IN(SELECT DISTINCT SupplyID FROM SupplyDetail WHERE Barcode LIKE'%" + _barcode + "%') AND";
            }
            if (sqlWhere.Contains("AND"))
            {
                sqlWhere = sqlWhere.Substring(0, sqlWhere.Length - 3);
            }
            //else
            //{
            //    sqlWhere = sqlWhere.Substring(0, sqlWhere.Length - 5);
            //}

            _sqlWhere = sqlWhere;

            pagerControl1.PageIndex = 1;
            BindDGV();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDetail"].Index)
            {
                object v = dataGridView1.Rows[e.RowIndex].Cells["cSupplyID"].Value;
                if (v != null)
                {
                    string supplyID = v.ToString();
                    frmSupplyDetail f = new frmSupplyDetail(supplyID);
                    f.ShowDialog();
                }

            }
        }

    }
}
