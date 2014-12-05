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
    public partial class frmSupplyDetail : Form
    {

        private string _supplyID = "";
        public frmSupplyDetail()
        {
            InitializeComponent();
        }

        public frmSupplyDetail(string id)
        {
            InitializeComponent();
            this._supplyID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOutDetail f = new frmOutDetail();
            f.ShowDialog();
        }

        private void frmSupplyDetail_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            Supply s = new Supply(_supplyID);
            lab_Name.Text = "客户名称：" + s.AgentName;
            lab_Price.Text = "每平米价格：" + s.Price.ToString("0.00") + "元";
            lab_CreatTime.Text = "供货日期：" + s.CreateTime.ToString("yyyy-MM-dd");
            lab_Operator.Text = "操作人员：" + s.Operator;
            lab_Sum.Text = "总计金额：" + s.SumPrice.ToString("0.00") + "元";
            lab_SupplyID.Text = "(单号：" + _supplyID + ")";

            DataSet sd = new SupplyDetail().GetList(" SupplyID = '" + _supplyID + "'");

            dataGridView1.DataSource = sd.Tables[0];
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
