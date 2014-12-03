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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string _start = dtp_Start.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string _end = dtp_End.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            if (DateTime.Parse(_start) > DateTime.Parse(_end))
            {
                MessageBox.Show("开始时间不能大于结束时间!");
                return;
            }
            BindDGV(_start,_end);
        }

        private void BindDGV(string start, string end)
        {
            string sql = "SELECT NormName," +
               " (SELECT ISNULL(SUM(I.Cnt),0) FROM InW I WHERE NormName=N.NormName AND I.CreateTime BETWEEN '" + start + "' AND '" + end + "') AS InCnt," +
" (SELECT ISNULL(SUM(O.Cnt),0) FROM SupplyDetail O WHERE NormName=N.NormName AND O.CreateTime BETWEEN '" + start + "' AND '" + end + "') AS OutCnt," +
" GETDATE() AS NowTime FROM Norm N ORDER BY NormName ASC";
            DataSet ds = DbHelperSQL.Query(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
