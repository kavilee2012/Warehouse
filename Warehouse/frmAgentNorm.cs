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
    public partial class frmAgentNorm : Form
    {
        public frmAgentNorm()
        {
            InitializeComponent();
        }

        private void frmAgentNorm_Load(object sender, EventArgs e)
        {
            DataTable dt = CommonService.GeneralDataTable();
            dataGridView1.DataSource = dt;
        }
    }
}
