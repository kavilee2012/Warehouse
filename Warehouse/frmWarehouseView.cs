using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SqlServerDAL;

namespace Warehouse
{
    public partial class frmWarehouseView : Form
    {
        public frmWarehouseView()
        {
            InitializeComponent();
        }

        private void frmWarehouseView_Load(object sender, EventArgs e)
        {
            BindDGV();
        }

        private void BindDGV()
        {
            string sql = "SELECT NormName,((SELECT ISNULL(SUM(I.Cnt),0) FROM InWDetail I WHERE NormName=N.NormName) - (SELECT ISNULL(SUM(O.Cnt),0) FROM SupplyDetail O WHERE NormName=N.NormName)) AS StoreCnt,GETDATE() AS NowTime FROM Norm N";
            DataSet ds = DbHelperSQL.Query(sql);
            DataTable dt = ds.Tables[0];
            int _inCnt = 0;
            foreach (DataRow r in dt.Rows)
            {
                _inCnt += int.Parse(r["StoreCnt"].ToString());
            }
            DataRow dr = dt.NewRow();
            dr["NormName"] = "总计";
            dr["StoreCnt"] = _inCnt;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
