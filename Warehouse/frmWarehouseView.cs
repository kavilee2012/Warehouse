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
            string sql = "SELECT NormName,((SELECT ISNULL(SUM(I.Cnt),0) FROM InW I WHERE NormName=N.NormName) - (SELECT ISNULL(SUM(O.Cnt),0) FROM SupplyDetail O WHERE NormName=N.NormName)) AS StoreCnt,GETDATE() AS NowTime FROM Norm N";
            DataSet ds = DbHelperSQL.Query(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
