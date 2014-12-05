namespace Warehouse
{
    partial class frmSupplyDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lab_Batch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Price = new System.Windows.Forms.Label();
            this.lab_Operator = new System.Windows.Forms.Label();
            this.lab_CreatTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_Sum = new System.Windows.Forms.Label();
            this.lab_SupplyID = new System.Windows.Forms.Label();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDel = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Batch
            // 
            this.lab_Batch.AutoSize = true;
            this.lab_Batch.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Batch.Location = new System.Drawing.Point(284, 19);
            this.lab_Batch.Name = "lab_Batch";
            this.lab_Batch.Size = new System.Drawing.Size(126, 27);
            this.lab_Batch.TabIndex = 10;
            this.lab_Batch.Text = "供 货 单";
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
            this.cBarcode,
            this.cNorm,
            this.cPrice,
            this.cSumMoney,
            this.cBatch,
            this.cInTime,
            this.cDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(2, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 367);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(45, 93);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(65, 12);
            this.lab_Name.TabIndex = 12;
            this.lab_Name.Text = "客户名称：";
            // 
            // lab_Price
            // 
            this.lab_Price.AutoSize = true;
            this.lab_Price.Location = new System.Drawing.Point(33, 119);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(77, 12);
            this.lab_Price.TabIndex = 13;
            this.lab_Price.Text = "每平米价格：";
            // 
            // lab_Operator
            // 
            this.lab_Operator.AutoSize = true;
            this.lab_Operator.Location = new System.Drawing.Point(554, 120);
            this.lab_Operator.Name = "lab_Operator";
            this.lab_Operator.Size = new System.Drawing.Size(65, 12);
            this.lab_Operator.TabIndex = 14;
            this.lab_Operator.Text = "操作人员：";
            // 
            // lab_CreatTime
            // 
            this.lab_CreatTime.AutoSize = true;
            this.lab_CreatTime.Location = new System.Drawing.Point(554, 93);
            this.lab_CreatTime.Name = "lab_CreatTime";
            this.lab_CreatTime.Size = new System.Drawing.Size(65, 12);
            this.lab_CreatTime.TabIndex = 15;
            this.lab_CreatTime.Text = "供货日期：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "打   印";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_Sum
            // 
            this.lab_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Sum.AutoSize = true;
            this.lab_Sum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Sum.Location = new System.Drawing.Point(12, 533);
            this.lab_Sum.Name = "lab_Sum";
            this.lab_Sum.Size = new System.Drawing.Size(93, 16);
            this.lab_Sum.TabIndex = 17;
            this.lab_Sum.Text = "总计金额：";
            // 
            // lab_SupplyID
            // 
            this.lab_SupplyID.AutoSize = true;
            this.lab_SupplyID.Location = new System.Drawing.Point(277, 63);
            this.lab_SupplyID.Name = "lab_SupplyID";
            this.lab_SupplyID.Size = new System.Drawing.Size(65, 12);
            this.lab_SupplyID.TabIndex = 18;
            this.lab_SupplyID.Text = "（单号：）";
            // 
            // cBarcode
            // 
            this.cBarcode.DataPropertyName = "Barcode";
            this.cBarcode.HeaderText = "条形码";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            this.cBarcode.Width = 150;
            // 
            // cNorm
            // 
            this.cNorm.DataPropertyName = "NormName";
            this.cNorm.HeaderText = "规格(单位:米)";
            this.cNorm.Name = "cNorm";
            this.cNorm.ReadOnly = true;
            this.cNorm.Width = 120;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "每平米价格";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            this.cPrice.Visible = false;
            this.cPrice.Width = 120;
            // 
            // cSumMoney
            // 
            this.cSumMoney.DataPropertyName = "SumMoney";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cSumMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.cSumMoney.HeaderText = "金额";
            this.cSumMoney.Name = "cSumMoney";
            this.cSumMoney.ReadOnly = true;
            // 
            // cBatch
            // 
            this.cBatch.DataPropertyName = "Batch";
            this.cBatch.HeaderText = "入仓批号";
            this.cBatch.Name = "cBatch";
            this.cBatch.ReadOnly = true;
            this.cBatch.Visible = false;
            this.cBatch.Width = 150;
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
            this.cDel.Visible = false;
            this.cDel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.cDel.Width = 60;
            // 
            // frmSupplyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 580);
            this.Controls.Add(this.lab_SupplyID);
            this.Controls.Add(this.lab_Sum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_CreatTime);
            this.Controls.Add(this.lab_Operator);
            this.Controls.Add(this.lab_Price);
            this.Controls.Add(this.lab_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lab_Batch);
            this.Name = "frmSupplyDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSupplyDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Batch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_Price;
        private System.Windows.Forms.Label lab_Operator;
        private System.Windows.Forms.Label lab_CreatTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lab_Sum;
        private System.Windows.Forms.Label lab_SupplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInTime;
        private System.Windows.Forms.DataGridViewLinkColumn cDel;

    }
}