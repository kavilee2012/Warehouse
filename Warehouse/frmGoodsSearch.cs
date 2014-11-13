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
            DataTable dt = GeneralDataTable();
            dataGridView1.DataSource = dt;
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

            tblDatas.Rows.Add(new object[] { null, "20141114AAAA", "AA", DateTime.Now.ToString("yyyy-MM-dd"), "详细" });
            tblDatas.Rows.Add(new object[] { null, "20141114BBBB", "BB", DateTime.Now.ToString("yyyy-MM-dd"), "详细" });
            tblDatas.Rows.Add(new object[] { null, "20141114CCCC", "CC", DateTime.Now.ToString("yyyy-MM-dd"), "详细" });
            tblDatas.Rows.Add(new object[] { null, "20141114DDDD", "AA", DateTime.Now.ToString("yyyy-MM-dd"), "详细" });
            tblDatas.Rows.Add(new object[] { null, "20141114EEEE", "BB", DateTime.Now.ToString("yyyy-MM-dd"), "详细" });

            return tblDatas;

        }

    }
}
