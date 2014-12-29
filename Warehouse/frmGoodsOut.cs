using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using SqlServerDAL;

namespace Warehouse
{
    public partial class frmGoodsOut : Form
    {
        IList<InW> allOut = new List<InW>();
        public decimal _price = 0;
        public frmGoodsOut()
        {
            InitializeComponent();
        }

        private void frmGoodsOut_Load(object sender, EventArgs e)
        {
            lab_Error.Tag = "9999";
            lab_Error.ForeColor = Color.Red;

            dataGridView1.AutoGenerateColumns = false;
            txt_Operator.Text = Global.userName;
            BindCBX();
            cbx_Agent.SelectedIndex = -1;
            panel_Time.Visible = true;
            rb_Time.Checked = true;
            link_Upload.Visible = false;
            rb_Batch.Checked = false;
        }

        private void BindCBX()
        {

            DataSet ds = new Agent().GetCbxList("");
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count >0 )
            {
                //DataRow dr = dt.NewRow();
                //dr["Name"] = "请选择";
                //dt.Rows.InsertAt(dr,0);
                cbx_Agent.DataSource = dt;
                cbx_Agent.DisplayMember = "Name";
                cbx_Agent.ValueMember = "Name";
            }
            else
            {
                MessageBox.Show("请先添加客户资料！");
                
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbx_Agent.SelectedValue == null)
            {
                MessageBox.Show("请先选择客户！");
                cbx_Agent.Focus();
                return;
            }

            if (allOut.Count <= 0)
            {
                MessageBox.Show("没有要出货的成品！");
                return;
            }

            if (MessageBox.Show("确定要生成供货单吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            List<SupplyDetail> list = new List<SupplyDetail>();
            foreach (InW i in allOut)
            {
                SupplyDetail s = new SupplyDetail();
                s.Barcode = i.Barcode;
                s.NormName = i.NormName;
                s.SumMoney = i.SumPrice;
                list.Add(s);
            }

            Supply m = new Supply();
            m.SupplyID = GenSupplyID();
            m.AgentName = cbx_Agent.SelectedValue.ToString();
            m.Price = _price;
            m.Operator = Global.userName;
            m.SumPrice = decimal.Parse(lab_Sum.Text.Replace("元","").Trim());

            int re = m.Add(list);
            if (re > 0)
            {
                MessageBox.Show("生成供应单成功！");
                cbx_Agent.SelectedIndex = -1;
                txt_Price.Text = "";
                txt_Barcode.Text = "";
                allOut=new List<InW>();
                BindDGV();

                frmSupplyReport ff = new frmSupplyReport(m.SupplyID);
                ff.ShowDialog();
            }
            else
            {
                MessageBox.Show("生成供应单失败！");
            }
        }

        private string GetTopSupplyID(string front)
        {
            string sql = "SELECT TOP 1 RIGHT(SupplyID,4) FROM Supply WHERE LEFT(SupplyID,6)='" + front + "' ORDER BY RIGHT(SupplyID,4) DESC";
            object obj = DbHelperSQL.GetSingle(sql);
            if (obj != DBNull.Value && obj != null)
            {
                return (Convert.ToInt32(obj) + 1).ToString("0000");
            }
            else
            {
                return "0001";
            }
        }
        private string GenSupplyID()
        {
            string supplyID = CommonService.GetServerTime().ToString("yyyyMM");
            supplyID += GetTopSupplyID(supplyID);
            return supplyID;
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_GenNo.Visible = false;
            frmStartScan f = new frmStartScan();
            f.ShowDialog();
            btn_GenNo.Visible = true;
        }

        public void AddDGV(string barcode)
        {
            InW m = new InW().GetModelByBarcode(barcode);
            if (m != null)
            {
                allOut.Add(m);
                BindDGV();
            }
        }
        
        public void BindDGV()
        {
            decimal sumMoney = 0;
            foreach (InW w in allOut)
            {
                w.SumPrice =decimal.Parse(w.NormName) * 100 * _price;
                sumMoney += w.SumPrice;
            }
            lab_Cnt.Text = allOut.Count.ToString();
            lab_Sum.Text = sumMoney.ToString("0.00")+"元";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = allOut;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = "移除";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Agent.SelectedValue != null)
            {
                string _name = cbx_Agent.SelectedValue.ToString();
                Agent m = new Agent(_name);
                if (!string.IsNullOrEmpty(m.LevelName))
                {
                    _price = m.Price;
                    txt_Price.Text = m.Price.ToString("0.00");
                    BindDGV();
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            //if (cbx_Agent.SelectedValue == null)
            //{
            //    MessageBox.Show("请先选择客户！");
            //    cbx_Agent.Focus();
            //    return;
            //}

            if (txt_Barcode.Text.Trim().Length >= 14)
            {
                string _barcode = txt_Barcode.Text.Trim();
                if (!InWDetail.Exists(_barcode))
                {
                    //MessageBox.Show("该条码不存在！");
                    lab_Error.Text = "该条码不存在!";
                    return;
                }
                if (SupplyDetail.Exists(_barcode))
                {
                    //MessageBox.Show("该条码已出仓,不能重复出仓！");
                    lab_Error.Text = "该条码已出仓,不能重复出仓!";
                    return;
                }
                InW w = new InW().GetModelByBarcode(_barcode);
                allOut.Add(w);
                BindDGV();
                txt_Barcode.Text = "";
                lab_Error.Text = "";
            }
            else
            {
                lab_Error.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["cDel"].Index == e.ColumnIndex)
            { 
                string v = dataGridView1.Rows[e.RowIndex].Cells["cBarcode"].Value.ToString();
                InW _w = null;
                foreach (InW i in allOut)
                {
                    if (i.Barcode == v)
                    {
                        _w = i;
                        break;
                    }
                }
                if (_w != null)
                {
                    allOut.Remove(_w);
                    BindDGV();
                }
            }
        }

        private void txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Barcode_TextChanged(null, null);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_Batch_CheckedChanged(object sender, EventArgs e)
        {
            link_Upload.Visible = rb_Batch.Checked;
        }

        private void rb_Time_CheckedChanged(object sender, EventArgs e)
        {
            panel_Time.Visible = rb_Time.Checked;
        }

        private void panel_Time_Paint(object sender, PaintEventArgs e)
        {

        }

        private void link_Upload_Click(object sender, EventArgs e)
        {
            frmBatchUpload f = new frmBatchUpload();
            f.ShowDialog();
        }
    }
}
