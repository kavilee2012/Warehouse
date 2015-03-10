using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SqlServerDAL;
using Common;

namespace Warehouse
{
    public partial class frmViewDetail : Form
    {
        string _norm = "", _model = "";
        public frmViewDetail()
        {
            InitializeComponent();
        }
        public frmViewDetail(string norm,string model)
        {
            InitializeComponent();
            this._norm = norm;
            this._model = model;
        }

        private void frmViewDetail_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Model,NormName,Barcode,Length,CreateTime FROM InWDetail WHERE Barcode NOT IN(SELECT Barcode FROM SupplyDetail) AND NormName = '" + _norm + "' AND Model = '" + _model + "'";
            DataSet ds = DbHelperSQL.Query(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
