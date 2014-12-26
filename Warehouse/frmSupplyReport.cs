using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Common;

namespace Warehouse
{
    public partial class frmSupplyReport : Form
    {
        string _supplyID = "";
        public frmSupplyReport()
        {
            InitializeComponent();
        }

        public frmSupplyReport(string id)
        {
            InitializeComponent();
            this._supplyID = id;
        }

        private void frmSupplyReport_Load(object sender, EventArgs e)
        {
            DataTable ds = GetData();
            ReportDataSource rds = new ReportDataSource("DataSet1_DataTable1", ds);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);


            Supply s = new Supply(_supplyID);
            if(string.IsNullOrEmpty(s.SupplyID))
            {
                MessageBox.Show("该供货单不存在!");
                return;
            }
            ReportParameter[] pas = new ReportParameter[]
            {
             new ReportParameter("pam_Company", CommonService.GetParamValue("Name")),
             new ReportParameter("pam_Address", CommonService.GetParamValue("Address")),
             new ReportParameter("pam_Phone", CommonService.GetParamValue("Phone")),
             new ReportParameter("pam_Remark", "123456789123，123456789123，123456789123，123456789123，123456789123，123456789123"),
             new ReportParameter("pam_Date",s.InTime.ToString("yyyy年MM月dd日")),
             new ReportParameter("pam_NO", s.SupplyID),
             new ReportParameter("pam_Supply", s.AgentName)
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

        private DataTable GetGroupSupply()
        {
            SupplyDetail sd = new SupplyDetail();
            DataSet ds = sd.GetList(" SupplyID='" + _supplyID + "'");
            if (ds.Tables[0] != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string _barcode = dr["Barcode"].ToString();

                }
            }
            return null;
        }

    }
}
