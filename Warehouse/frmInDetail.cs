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
    public partial class frmInDetail : Form
    {
        private string _batchID = "";
        public frmInDetail()
        {
            InitializeComponent();
        }
        public frmInDetail(string batch)
        {
            InitializeComponent();
            this._batchID = batch;
        }

        private void frmInDetail_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            lab_Batch.Text = "入仓批号：" + _batchID;

            InWDetail m = new InWDetail();
           DataSet ds =  m.GetList(" BatchID = '" + _batchID + "'");
           dataGridView1.DataSource = ds.Tables[0];
           cbx_All.Checked = true;
        }

        private void cbx_All_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                dvgr.Cells["cSel"].Value = cbx_All.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            List<string> list = new List<string>();
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                if ((bool)dvgr.Cells["cSel"].Value)
                {
                    list.Add(dvgr.Cells["cBarcode"].Value.ToString());
                }
            }
            //string ss = "";
            foreach (string s in list)
            {
                //ss += s + ",";
                BarcodeService.TSC(s);
            }
            MessageBox.Show("打印完成！");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
