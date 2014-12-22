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
    public partial class frmGoodsIn : Form
    {
        public frmGoodsIn()
        {
            InitializeComponent();
        }

        private void frmGoodsIn_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            //this.txt_AutoCode.Text = "自动生成";//DateTime.Now.ToString("yyyyMMdd" + "XXXX");
            //DataTable dt = GeneralDataTable();
            //dataGridView1.DataSource = dt;
            BindCbx();
            BindNorm();
            txt_Operator.Text = Global.userName;

            if (!Global.IsAdmin)
            {
                dataGridView1.Columns["cModity"].Visible=false;
                dataGridView1.Columns["cDel"].Visible = false;
            }

            pagerControl1.OnPageChanged += new EventHandler(pagerControl1_OnPageChanged);
            BindDGV();
        }

        void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            BindDGV();
        }

        public static DataTable GeneralDataTable()
        {
            DataTable tblDatas = new DataTable("Datas");
            tblDatas.Columns.Add("ID", Type.GetType("System.Int32"));
            tblDatas.Columns[0].AutoIncrement = true;
            tblDatas.Columns[0].AutoIncrementSeed = 1;
            tblDatas.Columns[0].AutoIncrementStep = 1;

            tblDatas.Columns.Add("A", Type.GetType("System.String"));
            tblDatas.Columns.Add("B", Type.GetType("System.String"));
            tblDatas.Columns.Add("C", Type.GetType("System.String"));
            tblDatas.Columns.Add("D", Type.GetType("System.String"));

            tblDatas.Rows.Add(new object[] { null, "20141114AAAA", "8G", "1000","打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114BBBB", "64G", "2000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114CCCC", "16G", "1000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114DDDD", "64G", "5000", "打印条码" });
            tblDatas.Rows.Add(new object[] { null, "20141114EEEE", "8G", "1000", "打印条码" });

            return tblDatas;

        }

        private void BindNorm()
        {
            Norm n = new Norm();
            DataSet ds = n.GetList("");
            if (ds != null)
            {
                cbx_Norm.DataSource = ds.Tables[0];
                cbx_Norm.DisplayMember = "NormName";
                cbx_Norm.ValueMember = "NormName";
            }
            else
            {
                MessageBox.Show("请先设置产品规格!");
                btn_Add.Enabled = false;
            }
        }

        private void BindCbx()
        {
            for (int i = 0; i < 100; i++)
            {
                cbx_Big.Items.Add(i);
                cbx_Cnt.Items.Add(i);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cPrint"].Index)
            {
                object v = dataGridView1.Rows[e.RowIndex].Cells["cBatch"].Value;
                if (v != null)
                {
                    frmInDetail f = new frmInDetail(v.ToString());
                    f.ShowDialog();
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                if (MessageBox.Show(this, "删除后数据不能恢复，是否继续删除?", "警告", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    object v = dataGridView1.Rows[e.RowIndex].Cells["cBatch"].Value;
                    if (v!=null)
                    {
                        InW no = new InW();
                        int re = no.Delete(v.ToString());
                        if (re>0)
                        {
                            MessageBox.Show("删除成功!");
                            BindDGV();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string bigStr = cbx_Big.Text;
            string cntStr = cbx_Cnt.Text;
            if (string.IsNullOrEmpty(cntStr)||string.IsNullOrEmpty(bigStr))
            {
                MessageBox.Show("卷数或件数格式不正确!");
                cbx_Cnt.Focus();
                return;
            }

            try
            {
                InW m = new InW();
                m.NormName = cbx_Norm.SelectedValue.ToString();
                m.BigCnt = int.Parse(bigStr);
                m.Cnt = int.Parse(cntStr);
                m.Batch = GenBatchNO();
                List<string> barList = GenBarcode(m.Cnt,m.BigCnt);
                m.Barcode = barList[0] + "~" + barList[barList.Count - 1];
                m.Operator = Global.userName;
                int re = m.Add(barList);
                if (re > 0)
                {
                    MessageBox.Show("入库成功!");
                    BindDGV();
                }
                else
                {
                    MessageBox.Show("入库失败!");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("99"))
                {
                    MessageBox.Show("每天同一规格成品入仓数量不能大于99件!");
                    //txt_Cnt.Focus();
                }
                else
                {
                    MessageBox.Show("系统异常! 详细:" + ex.Message);
                }
            }
        }

        private void BindDGV()
        {
            int _count = 0;
            DataSet ds = new InW().GetPageList(pagerControl1.PageSize, pagerControl1.PageIndex, "", out _count);
            dataGridView1.DataSource = ds.Tables[0];
            pagerControl1.DrawControl(_count);
        }

        private string GetNormFormat(string name)
        {
            string re = (float.Parse(name) * 1000).ToString("0000.00");
            return re.Substring(0, 4);
        }

        /// <summary>
        /// 生成流水位九位
        /// </summary>
        /// <returns></returns>
        private string GetTodayNO(bool isBarcode)
        {
            string batchNO = "";
            batchNO += GetNormFormat(cbx_Norm.SelectedValue.ToString());//四位
            if (isBarcode)
            {
                batchNO += CommonService.GetServerTime().ToString("yyMMdd").Substring(1);//五位
            }
            else
            {
                batchNO += CommonService.GetServerTime().ToString("yyMMdd");//六位
            }
            return batchNO;
        }

        private string GetTopBatch(string front)
        {
            string sql = "SELECT TOP 1 RIGHT(Batch,3) FROM InW WHERE LEFT(Batch,11)='"+front+"' ORDER BY RIGHT(Batch,3) DESC";
            object obj = DbHelperSQL.GetSingle(sql);
            if (obj != DBNull.Value && obj != null)
            {
                return (Convert.ToInt32(obj) + 1).ToString("000");
            }
            else
            {
                return "001";
            }
        }

        private string GetTopBarcode(string front)
        {
            string sql = "SELECT TOP 1 RIGHT(Barcode,2) FROM InWDetail WHERE LEFT(Barcode,11)='" + front + "' ORDER BY RIGHT(Barcode,2) DESC";
            object obj = DbHelperSQL.GetSingle(sql);
            if (obj != DBNull.Value && obj != null)
            {
                return (Convert.ToInt32(obj) + 1).ToString("00");
            }
            else
            {
                return "01";
            }
        }


        private string GenBatchNO()
        {
            string front = "P" + GetTodayNO(false);
            front += GetTopBatch(front);
            return front;
        }


        /// <summary>
        /// 生成条码(规格4+年月日5+大卷2+件数2)
        /// </summary>
        /// <returns></returns>
        private List<string> GenBarcode(int cnt,int bigCnt)
        {
            string _today = GetTodayNO(true);
            string _front = _today + bigCnt.ToString("00");

            int _base = int.Parse(GetTopBarcode(_front));
            if ((_base + cnt)>99)
            {
                throw new Exception("不能大于99");
            }
            List<string> list = new List<string>();
            for (int i = 0; i < cnt;i++ )
            {
                string s = _front + (_base + i).ToString("00");
                list.Add(s);
            }
            return list;
        }






        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["cPrint"].Index)
            {
                e.Value = "打印条形码";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["cDel"].Index)
            {
                e.Value = " 删除";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["cModity"].Index)
            {
                e.Value = " 修改";
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewService.VisibleRowOrder(dataGridView1, e);
        }


    }
}
