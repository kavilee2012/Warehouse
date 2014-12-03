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
            dataGridView1.AutoGenerateColumns = false;
            txt_Operator.Text = Global.userName;
            BindCBX();
            cbx_Agent.SelectedIndex = -1;
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

            Supply m = new Supply();
            m.SupplyID = GenSupplyID();
            m.AgentName = cbx_Agent.SelectedValue.ToString();
            m.Price = _price;
            m.Operator = Global.userName;
            m.SumPrice = decimal.Parse(lab_Sum.Text.Replace("元","").Trim());
            int re = m.Add();
            if (re > 0)
            {
                MessageBox.Show("生成供应单成功！");
                cbx_Agent.SelectedIndex = -1;
                txt_Price.Text = "";
                txt_Barcode.Text = "";
                allOut=new List<InW>();
                BindDGV();
            }
            else
            {
                MessageBox.Show("生成供应单失败！");
            }
        }

        private string GenSupplyID()
        {
            return DateTime.Now.ToString("yyyyMMddhhmmss");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (cbx_Agent.SelectedValue == null)
            {
                MessageBox.Show("请先选择客户！");
                cbx_Agent.Focus();
                return;
            }
            InW w = new InW().GetModelByBarcode(txt_Barcode.Text);
            if (w != null)
            {
                allOut.Add(w);
                BindDGV();
            }
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
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }
    }
}
