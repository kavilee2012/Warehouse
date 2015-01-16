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

            LoadService();

            cbx_All.Checked = true;
        }

        private void LoadService()
        {
            InWDetail m = new InWDetail();
            DataSet ds = m.GetList(" BatchID = '" + _batchID + "'");
            dataGridView1.DataSource = ds.Tables[0];
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
            bool _isTooBig = false;
            foreach (DataGridViewRow dvgr in dataGridView1.Rows)
            {
                if (dvgr.Cells["cSel"].Value!=null && (bool)dvgr.Cells["cSel"].Value)
                {
                    list.Add(dvgr.Cells["cBarcode"].Value.ToString());
                    int _cnt = int.Parse(dvgr.Cells["cPrintCnt"].Value.ToString());
                    if (_cnt > 0)
                    {
                        _isTooBig = true;
                    }
                }
            }

            if (list.Count <= 0)
            {
                MessageBox.Show("请勾选要打印的条码！");
                return;
            }

            //如果超过1次，不是管理员就报错
            if (_isTooBig && !Global.IsAdmin)
            {

                MessageBox.Show("勾选的条码已超过打印次数，请联系管理员！");
                return;

            }

            InWDetail iw = new InWDetail();
            try
            {
                foreach (string s in list)
                {
                    BarcodeService.TSC(s);
                    iw.UpdatePrintCnt(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印失败！原因：" + ex.Message);
                MyLog.WriteLog(ex.Message);
            }
            MessageBox.Show("打印结束！");
            LoadService();
            cbx_All_CheckedChanged(null, null);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
