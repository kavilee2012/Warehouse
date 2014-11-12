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
    public partial class frmGoodsNorm : Form
    {
        public frmGoodsNorm()
        {
            InitializeComponent();
        }

        private void frmGoodsNorm_Load(object sender, EventArgs e)
        {
            DataTable dt = CommonService.GeneralDataTable();
            dataGridView1.DataSource = dt;
        }
    }
}
