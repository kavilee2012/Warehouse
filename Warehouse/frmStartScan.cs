using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frmStartScan : Form
    {
        frmGoodsOut frm = null;
        public frmStartScan()
        {
            InitializeComponent();
        }
        public frmStartScan(frmGoodsOut f)
        {
            InitializeComponent();
            this.frm = f;
        }

        private void frmStartScan_Load(object sender, EventArgs e)
        {
            txt_Barcode.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            string _bar = txt_Barcode.Text.Trim();
            if (_bar.Length>0 && IsBarcode(_bar))
            {
                frm.AddDGV(_bar);
                txt_Barcode.Text = "";
                txt_Barcode.Focus();
            }
        }

        private bool IsBarcode(string origin)
        {
            if (origin == "000111000111000")
                return true;
            else
                return false;
        }
    }
}
