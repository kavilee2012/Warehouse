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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }


        private void frmCompany_Load(object sender, EventArgs e)
        {
            textBox1.Text = CommonService.GetParamValue("Name");
            textBox2.Text = CommonService.GetParamValue("Phone");
            textBox3.Text = CommonService.GetParamValue("Address");
            txt_GoodsName.Text = CommonService.GetParamValue("GoodsName");
        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            bool reName = CommonService.SetParamName("Name", textBox1.Text.Trim());
            if (reName)
            {
                MessageBox.Show("设定成功!");
            }
            else
            {
                MessageBox.Show("设定失败!");
            }
        }

        private void btn_Phone_Click(object sender, EventArgs e)
        {
            bool reName = CommonService.SetParamName("Phone", textBox2.Text.Trim());
            if (reName)
            {
                MessageBox.Show("设定成功!");
            }
            else
            {
                MessageBox.Show("设定失败!");
            }
        }

        private void btn_Address_Click(object sender, EventArgs e)
        {
            bool reName = CommonService.SetParamName("Address", textBox3.Text.Trim());
            if (reName)
            {
                MessageBox.Show("设定成功!");
            }
            else
            {
                MessageBox.Show("设定失败!");
            }
        }

        private void btn_GoodsName_Click(object sender, EventArgs e)
        {
            bool reName = CommonService.SetParamName("GoodsName", txt_GoodsName.Text.Trim());
            if (reName)
            {
                MessageBox.Show("设定成功!");
            }
            else
            {
                MessageBox.Show("设定失败!");
            }
        }


    }
}
