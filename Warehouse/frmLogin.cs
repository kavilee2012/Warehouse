using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frmLogin : Form
    {

        public static Sunisoft.IrisSkin.SkinEngine se = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinFile = Application.StartupPath + @"\Skin\MP10.ssk";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frmIndex f = new frmIndex();
            f.ShowDialog();
            this.Hide();
        }
    }
}
