using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frmGoodsNormUpdate : Form
    {
        Norm _model = new Norm();
        public bool _isTrue = false;

        public frmGoodsNormUpdate()
        {
            InitializeComponent();
        }

        public frmGoodsNormUpdate(Norm m)
        {
            InitializeComponent();
            this._model = m;
        }

        private void frmGoodsNormUpdate_Load(object sender, EventArgs e)
        {
            lab_ID.Text = _model.NormID.ToString();
            txt_Name.Text = _model.NormName;
        }

        private void btn_Modity_Click(object sender, EventArgs e)
        {
            string _name = txt_Name.Text.Trim();
            if (string.IsNullOrEmpty(_name))
            {
                MessageBox.Show("名称不能为空!");
                txt_Name.Focus();
                return;
            }
            if (_model.Exists(_name))
            {
                MessageBox.Show("该名称已存在!");
                txt_Name.Focus();
                return;
            }
            _model.NormName = _name;
            bool re = _model.Update();
            if (re)
            {
                MessageBox.Show("修改成功!");
                this._isTrue = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败!");
            }
        }
    }
}
