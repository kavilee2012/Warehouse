using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Warehouse
{
    public partial class frmSupplyReport : Form
    {
        public frmSupplyReport()
        {
            InitializeComponent();
        }

        private void frmSupplyReport_Load(object sender, EventArgs e)
        {
            //Supply s = new Supply();
            //s.AgentName = "lztest";
            DataTable ds = GetData();
            ReportDataSource rds = new ReportDataSource("DataSet1_DataTable1", ds);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("pam_Address","广州花城大道"));
            ReportParameter[] pas = new ReportParameter[]
            {
             new ReportParameter("pam_Address", "广州花城大道"),
             new ReportParameter("pam_Phone", "123456789123"),
             new ReportParameter("pam_Remark", "123456789123，123456789123，123456789123，123456789123，123456789123，123456789123"),
             new ReportParameter("pam_Date", "2014 年 11 月 11 日"),
             new ReportParameter("pam_NO", "15001412210101"),
             new ReportParameter("pam_Supply", "XX服务厂")
            };
            
            reportViewer1.LocalReport.SetParameters(pas);
            this.reportViewer1.RefreshReport();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable("dataname");
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("income", typeof(decimal)));
            dt.Columns.Add(new DataColumn("dept", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["name"] = "张三";
            dr["income"] = 3300.00m;
            dr["dept"] = "人事";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["name"] = "李四";
            dr["income"] = 3500.00m;
            dr["dept"] = "后勤";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["name"] = "XJ";
            dr["income"] = 7500.00m;
            dr["dept"] = "技术";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["name"] = "CSC";
            dr["income"] = 8500.00m;
            dr["dept"] = "技术";
            dt.Rows.Add(dr);
            return dt;
        }

    }
}
