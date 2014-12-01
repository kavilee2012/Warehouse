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
        public frmGoodsOut()
        {
            InitializeComponent();
        }

        private void frmGoodsOut_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            btn_GenNo.Visible = false;
            btn_KeepScan.Visible = false;
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
            frmStartScan f = new frmStartScan(this);
            f.ShowDialog();
            btn_GenNo.Visible = true;
            btn_KeepScan.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_GenNo.Visible = false;
            btn_KeepScan.Visible = false;
            frmStartScan f = new frmStartScan();
            f.ShowDialog();
            btn_GenNo.Visible = true;
            btn_KeepScan.Visible = true;
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
            dataGridView1.DataSource = allOut;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = "移除";
            }
        }
    }
}
