namespace Warehouse
{
    partial class frmGoodsIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Operator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Norm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Big = new System.Windows.Forms.ComboBox();
            this.cbx_Cnt = new System.Windows.Forms.ComboBox();
            this.dtp_InTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBigCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cModity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作员：";
            // 
            // txt_Operator
            // 
            this.txt_Operator.Enabled = false;
            this.txt_Operator.Location = new System.Drawing.Point(95, 29);
            this.txt_Operator.Name = "txt_Operator";
            this.txt_Operator.Size = new System.Drawing.Size(75, 21);
            this.txt_Operator.TabIndex = 1;
            this.txt_Operator.Text = "自动生成";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "成品规格：";
            // 
            // cbx_Norm
            // 
            this.cbx_Norm.FormattingEnabled = true;
            this.cbx_Norm.Location = new System.Drawing.Point(259, 30);
            this.cbx_Norm.Name = "cbx_Norm";
            this.cbx_Norm.Size = new System.Drawing.Size(69, 20);
            this.cbx_Norm.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "件数：";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(870, 28);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "入  仓";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtp_InTime);
            this.groupBox1.Controls.Add(this.cbx_Cnt);
            this.groupBox1.Controls.Add(this.cbx_Big);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Operator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_Norm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入仓信息";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 426);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.cInTime,
            this.cBatch,
            this.cNorm,
            this.cBigCnt,
            this.cCount,
            this.cBarcode,
            this.cOperator,
            this.cPrint,
            this.cModity,
            this.cDel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(963, 420);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "大卷：";
            // 
            // cbx_Big
            // 
            this.cbx_Big.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Big.FormattingEnabled = true;
            this.cbx_Big.Location = new System.Drawing.Point(392, 31);
            this.cbx_Big.Name = "cbx_Big";
            this.cbx_Big.Size = new System.Drawing.Size(45, 20);
            this.cbx_Big.TabIndex = 10;
            // 
            // cbx_Cnt
            // 
            this.cbx_Cnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Cnt.FormattingEnabled = true;
            this.cbx_Cnt.Location = new System.Drawing.Point(506, 30);
            this.cbx_Cnt.Name = "cbx_Cnt";
            this.cbx_Cnt.Size = new System.Drawing.Size(45, 20);
            this.cbx_Cnt.TabIndex = 11;
            // 
            // dtp_InTime
            // 
            this.dtp_InTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_InTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InTime.Location = new System.Drawing.Point(654, 30);
            this.dtp_InTime.Name = "dtp_InTime";
            this.dtp_InTime.Size = new System.Drawing.Size(153, 21);
            this.dtp_InTime.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "入仓时间：";
            // 
            // cInTime
            // 
            this.cInTime.DataPropertyName = "InTime";
            this.cInTime.HeaderText = "入仓时间";
            this.cInTime.Name = "cInTime";
            this.cInTime.ReadOnly = true;
            this.cInTime.Width = 120;
            // 
            // cBatch
            // 
            this.cBatch.DataPropertyName = "Batch";
            this.cBatch.HeaderText = "入仓批号";
            this.cBatch.Name = "cBatch";
            this.cBatch.ReadOnly = true;
            this.cBatch.Width = 150;
            // 
            // cNorm
            // 
            this.cNorm.DataPropertyName = "NormName";
            this.cNorm.HeaderText = "成品规格(单位:米)";
            this.cNorm.Name = "cNorm";
            this.cNorm.ReadOnly = true;
            this.cNorm.Width = 150;
            // 
            // cBigCnt
            // 
            this.cBigCnt.DataPropertyName = "BigCnt";
            this.cBigCnt.HeaderText = "大卷";
            this.cBigCnt.Name = "cBigCnt";
            this.cBigCnt.ReadOnly = true;
            this.cBigCnt.Width = 80;
            // 
            // cCount
            // 
            this.cCount.DataPropertyName = "Cnt";
            this.cCount.HeaderText = "件数";
            this.cCount.Name = "cCount";
            this.cCount.ReadOnly = true;
            this.cCount.Width = 80;
            // 
            // cBarcode
            // 
            this.cBarcode.DataPropertyName = "Barcode";
            this.cBarcode.HeaderText = "条形码";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            this.cBarcode.Width = 200;
            // 
            // cOperator
            // 
            this.cOperator.DataPropertyName = "Operator";
            this.cOperator.HeaderText = "操作员";
            this.cOperator.Name = "cOperator";
            this.cOperator.ReadOnly = true;
            // 
            // cPrint
            // 
            this.cPrint.ActiveLinkColor = System.Drawing.Color.Blue;
            this.cPrint.DataPropertyName = "D";
            this.cPrint.HeaderText = "";
            this.cPrint.Name = "cPrint";
            this.cPrint.ReadOnly = true;
            this.cPrint.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // cModity
            // 
            this.cModity.HeaderText = "";
            this.cModity.Name = "cModity";
            this.cModity.ReadOnly = true;
            this.cModity.Width = 60;
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
            // frmGoodsIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGoodsIn";
            this.Text = "frmGoodsIn";
            this.Load += new System.EventHandler(this.frmGoodsIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Operator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Norm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Cnt;
        private System.Windows.Forms.ComboBox cbx_Big;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBigCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOperator;
        private System.Windows.Forms.DataGridViewLinkColumn cPrint;
        private System.Windows.Forms.DataGridViewLinkColumn cModity;
        private System.Windows.Forms.DataGridViewLinkColumn cDel;
    }
}