using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Common;
using SqlServer;

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
            Supply s = new Supply();
            s.GetModel(_supplyID);
            if (string.IsNullOrEmpty(s.SupplyID))
            {
                MessageBox.Show("该供货单不存在!");
                return;
            }

            decimal _sum = 0;
            DataTable ds = GetGroupSupply(out _sum);
            ReportDataSource rds = new ReportDataSource("DataSet1_DataTable1", ds);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            string _barStr = "";
            string sql="SELECT Barcode FROM SupplyDetail WHERE SupplyID='"+_supplyID+"'";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            if (dt != null&& dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _barStr += dr["Barcode"].ToString()+"、";
                }
            }

            ReportParameter[] pas = new ReportParameter[]
            {
             new ReportParameter("pam_Company", CommonService.GetParamValue("Name")),
             new ReportParameter("pam_Address", CommonService.GetParamValue("Address")),
             new ReportParameter("pam_Phone", CommonService.GetParamValue("Phone")),
             new ReportParameter("pam_Remark", _barStr),
             new ReportParameter("pam_Date",s.CreateTime.ToString("yyyy年MM月dd日")),
             new ReportParameter("pam_NO", s.SupplyID),
             new ReportParameter("pam_SumSmall", _sum.ToString("0.00")),
             new ReportParameter("pam_SumAmount", CommonService.MoneyToChinese(_sum.ToString("0.00"))),
             new ReportParameter("pam_Supply", s.AgentName)
            };
            reportViewer1.LocalReport.SetParameters(pas);

            this.reportViewer1.RefreshReport();
        }

        //private DataTable GetData()
        //{


        //    DataTable dt = new DataTable("dataname");
        //    dt.Columns.Add(new DataColumn("name", typeof(string)));
        //    dt.Columns.Add(new DataColumn("income", typeof(decimal)));
        //    dt.Columns.Add(new DataColumn("dept", typeof(string)));

        //    DataRow dr = dt.NewRow();
        //    dr["name"] = "张三";
        //    dr["income"] = 3300.00m;
        //    dr["dept"] = "人事";
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["name"] = "李四";
        //    dr["income"] = 3500.00m;
        //    dr["dept"] = "后勤";
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["name"] = "XJ";
        //    dr["income"] = 7500.00m;
        //    dr["dept"] = "技术";
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["name"] = "CSC";
        //    dr["income"] = 8500.00m;
        //    dr["dept"] = "技术";
        //    dt.Rows.Add(dr);
        //    return dt;
        //}

        private DataTable GetGroupSupply(out decimal sum)
        {
            decimal _s = 0;
            string sql = "SELECT LEFT(Barcode,4)as 规格,COUNT(Barcode) as 数量,Sum(SumMoney) as 金额,MAX(Price) as 单价,'件' as 单位 FROM SupplyDetail WHERE SupplyID='" + _supplyID + "' GROUP BY LEFT(Barcode,4)";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            if (dt != null && dt.Rows.Count>0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    float tem = float.Parse(dr["规格"].ToString()) / 1000;
                    dr["规格"] = tem.ToString("0.0") + "米";
                    _s += decimal.Parse(dr["金额"].ToString());
                    dr["单价"] = decimal.Parse(dr["单价"].ToString()).ToString("0.00");
                    dr["金额"] = decimal.Parse(dr["金额"].ToString()).ToString("0.00");
                }
            }
            sum = _s;
            return dt;
        }

    }
}
