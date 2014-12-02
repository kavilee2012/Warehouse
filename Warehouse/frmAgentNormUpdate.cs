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
    public partial class frmAgentNormUpdate : Form
    {
        Level _model = new Level();
        public bool _isTrue = false;

        public frmAgentNormUpdate()
        {
            InitializeComponent();
        }

        public frmAgentNormUpdate(Level m)
        {
            InitializeComponent();
            this._model = m;
        }

        private void frmAgentNormUpdate_Load(object sender, EventArgs e)
        {
            lab_ID.Text = _model.LevelName.ToString();
            txt_Price.Text = _model.Price.ToString("0.00");
        }

        private void btn_Modity_Click(object sender, EventArgs e)
        {
            string _price = txt_Price.Text.Trim();
            if (!ValidateService.IsNumber(_price))
            {
                MessageBox.Show("价格格式错误!");
                txt_Price.Focus();
                return;
            }
            //if (_model.Exists(_name))
            //{
            //    MessageBox.Show("该名称已存在!");
            //    txt_Price.Focus();
            //    return;
            //}
            _model.Price = decimal.Parse(_price);
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
