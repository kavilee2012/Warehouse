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
    public partial class frmGoodsOut : Form
    {
        IList<InW> allOut = new List<InW>();
        public decimal _price = 0;
        public frmGoodsOut()
        {
            InitializeComponent();
        }

        private void frmGoodsOut_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            txt_Operator.Text = Global.userName;
            BindCBX();
            cbx_Agent.SelectedIndex = -1;
        }

        private void BindCBX()
        {

            DataSet ds = new Agent().GetCbxList("");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count >0 )
            {
                //DataRow dr = dt.NewRow();
                //dr["Name"] = "请选择";
                //dt.Rows.InsertAt(dr,0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmOutDetail f = new frmOutDetail();
            f.ShowDialog();
        }

        public static DataTable GeneralDataTable()
        {
            DataTable tblDatas = new DataTable("Datas");
            tblDatas.Columns.Add("ID", Type.GetType("System.Int32"));
            tblDatas.Columns[0].AutoIncrement = true;
            tblDatas.Columns[0].AutoIncrementSeed = 1;
            tblDatas.Columns[0].AutoIncrementStep = 1;

            tblDatas.Columns.Add("A", Type.GetType("System.String"));
            tblDatas.Columns.Add("B", Type.GetType("System.String"));
            tblDatas.Columns.Add("C", Type.GetType("System.String"));
            tblDatas.Columns.Add("D", Type.GetType("System.String"));

            tblDatas.Rows.Add(new object[] { null, "20141114AAAA", "8G", "1000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114BBBB", "64G", "2000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114CCCC", "16G", "1000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114DDDD", "64G", "5000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114EEEE", "8G", "1000", "打印条码" });

            return tblDatas;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmStartScan f = new frmStartScan(this);
            //f.ShowDialog();
            //btn_GenNo.Visible = true;
            InW w = new InW().GetModelByBarcode(txt_Barcode.Text);
            if (w != null)
            {
                allOut.Add(w);
                BindDGV();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_GenNo.Visible = false;
            frmStartScan f = new frmStartScan();
            f.ShowDialog();
            btn_GenNo.Visible = true;
        }

        public void AddDGV(string barcode)
        {
            InW m = new InW().GetModelByBarcode(barcode);
            if (m != null)
            {
                allOut.Add(m);
                BindDGV();
            }
        }
        
        public void BindDGV()
        {
            foreach (InW w in allOut)
            {
                w.SumPrice =decimal.Parse(w.NormName) * 100 * _price;
            }
            dataGridView1.DataSource = allOut;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = "移除";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Agent.SelectedValue != null)
            {
                string _name = cbx_Agent.SelectedValue.ToString();
                Agent m = new Agent(_name);
                if (!string.IsNullOrEmpty(m.LevelName))
                {
                    _price = m.Price;
                    txt_Price.Text = m.Price.ToString("0.00");
                }
            }
        }
    }
}
