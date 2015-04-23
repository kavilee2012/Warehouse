namespace Warehouse
{
    partial class frmGoodsOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_Upload = new System.Windows.Forms.Button();
            this.panel_Time = new System.Windows.Forms.Panel();
            this.lab_Error = new System.Windows.Forms.Label();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.rb_Batch = new System.Windows.Forms.RadioButton();
            this.rb_Time = new System.Windows.Forms.RadioButton();
            this.lab_Cnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Sum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_GenNo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Agent = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Level = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel_Time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.link_Upload);
            this.groupBox1.Controls.Add(this.panel_Time);
            this.groupBox1.Controls.Add(this.rb_Batch);
            this.groupBox1.Controls.Add(this.rb_Time);
            this.groupBox1.Controls.Add(this.lab_Cnt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lab_Sum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_GenNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 457);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "扫描成品信息";
            // 
            // link_Upload
            // 
            this.link_Upload.Location = new System.Drawing.Point(224, 23);
            this.link_Upload.Name = "link_Upload";
            this.link_Upload.Size = new System.Drawing.Size(51, 23);
            this.link_Upload.TabIndex = 20;
            this.link_Upload.Text = "上传";
            this.link_Upload.UseVisualStyleBackColor = true;
            this.link_Upload.Click += new System.EventHandler(this.link_Upload_Click);
            // 
            // panel_Time
            // 
            this.panel_Time.Controls.Add(this.lab_Error);
            this.panel_Time.Controls.Add(this.txt_Barcode);
            this.panel_Time.Location = new System.Drawing.Point(409, 14);
            this.panel_Time.Name = "panel_Time";
            this.panel_Time.Size = new System.Drawing.Size(367, 35);
            this.panel_Time.TabIndex = 19;
            this.panel_Time.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Time_Paint);
            // 
            // lab_Error
            // 
            this.lab_Error.AutoSize = true;
            this.lab_Error.Location = new System.Drawing.Point(148, 12);
            this.lab_Error.Name = "lab_Error";
            this.lab_Error.Size = new System.Drawing.Size(0, 12);
            this.lab_Error.TabIndex = 20;
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(4, 8);
            this.txt_Barcode.MaxLength = 15;
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(138, 21);
            this.txt_Barcode.TabIndex = 18;
            this.txt_Barcode.TextChanged += new System.EventHandler(this.txt_Barcode_TextChanged);
            // 
            // rb_Batch
            // 
            this.rb_Batch.AutoSize = true;
            this.rb_Batch.Location = new System.Drawing.Point(149, 27);
            this.rb_Batch.Name = "rb_Batch";
            this.rb_Batch.Size = new System.Drawing.Size(71, 16);
            this.rb_Batch.TabIndex = 18;
            this.rb_Batch.Text = "批量上传";
            this.rb_Batch.UseVisualStyleBackColor = true;
            this.rb_Batch.CheckedChanged += new System.EventHandler(this.rb_Batch_CheckedChanged);
            // 
            // rb_Time
            // 
            this.rb_Time.AutoSize = true;
            this.rb_Time.Checked = true;
            this.rb_Time.Location = new System.Drawing.Point(333, 26);
            this.rb_Time.Name = "rb_Time";
            this.rb_Time.Size = new System.Drawing.Size(71, 16);
            this.rb_Time.TabIndex = 17;
            this.rb_Time.TabStop = true;
            this.rb_Time.Text = "即时扫描";
            this.rb_Time.UseVisualStyleBackColor = true;
            this.rb_Time.CheckedChanged += new System.EventHandler(this.rb_Time_CheckedChanged);
            // 
            // lab_Cnt
            // 
            this.lab_Cnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Cnt.AutoSize = true;
            this.lab_Cnt.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Cnt.Location = new System.Drawing.Point(86, 411);
            this.lab_Cnt.Name = "lab_Cnt";
            this.lab_Cnt.Size = new System.Drawing.Size(27, 27);
            this.lab_Cnt.TabIndex = 15;
            this.lab_Cnt.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "数量：";
            // 
            // lab_Sum
            // 
            this.lab_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Sum.AutoSize = true;
            this.lab_Sum.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Sum.Location = new System.Drawing.Point(302, 411);
            this.lab_Sum.Name = "lab_Sum";
            this.lab_Sum.Size = new System.Drawing.Size(72, 27);
            this.lab_Sum.TabIndex = 13;
            this.lab_Sum.Text = "0.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(222, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "金额：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBarcode,
            this.cModel,
            this.cNorm,
            this.cLength,
            this.cPrice,
            this.cSumPrice,
            this.cInTime,
            this.cDel});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 326);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cBarcode
            // 
            this.cBarcode.DataPropertyName = "Barcode";
            this.cBarcode.HeaderText = "条形码";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            this.cBarcode.Width = 150;
            // 
            // cModel
            // 
            this.cModel.DataPropertyName = "Model";
            this.cModel.HeaderText = "型号";
            this.cModel.Name = "cModel";
            this.cModel.ReadOnly = true;
            this.cModel.Width = 120;
            // 
            // cNorm
            // 
            this.cNorm.DataPropertyName = "NormName";
            this.cNorm.HeaderText = "规格(单位:米)";
            this.cNorm.Name = "cNorm";
            this.cNorm.ReadOnly = true;
            this.cNorm.Width = 120;
            // 
            // cLength
            // 
            this.cLength.DataPropertyName = "Length";
            this.cLength.HeaderText = "米数";
            this.cLength.Name = "cLength";
            this.cLength.ReadOnly = true;
            this.cLength.Width = 150;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.cPrice.HeaderText = "单价";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // cSumPrice
            // 
            this.cSumPrice.DataPropertyName = "SumPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.cSumPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.cSumPrice.HeaderText = "金额";
            this.cSumPrice.Name = "cSumPrice";
            this.cSumPrice.ReadOnly = true;
            // 
            // cInTime
            // 
            this.cInTime.DataPropertyName = "InTime";
            this.cInTime.HeaderText = "入仓时间";
            this.cInTime.Name = "cInTime";
            this.cInTime.ReadOnly = true;
            this.cInTime.Visible = false;
            this.cInTime.Width = 120;
            // 
            // cDel
            // 
            this.cDel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.cDel.HeaderText = "";
            this.cDel.Name = "cDel";
            this.cDel.ReadOnly = true;
            this.cDel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.cDel.Width = 60;
            // 
            // btn_GenNo
            // 
            this.btn_GenNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GenNo.Location = new System.Drawing.Point(551, 407);
            this.btn_GenNo.Name = "btn_GenNo";
            this.btn_GenNo.Size = new System.Drawing.Size(132, 40);
            this.btn_GenNo.TabIndex = 8;
            this.btn_GenNo.Text = "生成供货单";
            this.btn_GenNo.UseVisualStyleBackColor = true;
            this.btn_GenNo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择客户：";
            // 
            // cbx_Agent
            // 
            this.cbx_Agent.FormattingEnabled = true;
            this.cbx_Agent.Location = new System.Drawing.Point(289, 41);
            this.cbx_Agent.Name = "cbx_Agent";
            this.cbx_Agent.Size = new System.Drawing.Size(369, 20);
            this.cbx_Agent.TabIndex = 3;
            this.cbx_Agent.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_Level);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Operator);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_Agent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 73);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "选择级别：";
            // 
            // cbx_Level
            // 
            this.cbx_Level.FormattingEnabled = true;
            this.cbx_Level.Location = new System.Drawing.Point(290, 10);
            this.cbx_Level.Name = "cbx_Level";
            this.cbx_Level.Size = new System.Drawing.Size(70, 20);
            this.cbx_Level.TabIndex = 21;
            this.cbx_Level.SelectedIndexChanged += new System.EventHandler(this.cbx_Level_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "元";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(485, 11);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.Size = new System.Drawing.Size(52, 21);
            this.txt_Price.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "每平米价格：";
            // 
            // txt_Operator
            // 
            this.txt_Operator.Location = new System.Drawing.Point(82, 8);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.ReadOnly = true;
            this.txt_Operator.Size = new System.Drawing.Size(100, 21);
            this.txt_Operator.TabIndex = 16;
            this.txt_Operator.Text = "自动生成";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "操作员：";
            // 
            // frmGoodsOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmGoodsOut";
            this.Text = "frmGoodsOut";
            this.Load += new System.EventHandler(this.frmGoodsOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_Time.ResumeLayout(false);
            this.panel_Time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GenNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Agent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_Sum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_Cnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Time;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.RadioButton rb_Batch;
        private System.Windows.Forms.RadioButton rb_Time;
        private System.Windows.Forms.Label lab_Error;
        private System.Windows.Forms.Button link_Upload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInTime;
        private System.Windows.Forms.DataGridViewLinkColumn cDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Level;

    }
}