namespace Warehouse
{
    partial class frmGoodsSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagerControl1 = new WinFormPager.PagerControl();
            this.lab_Cnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Sum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cSupplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Barcode = new System.Windows.Forms.TextBox();
            this.cbx_Agent = new System.Windows.Forms.ComboBox();
            this.txt_SupplyNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pagerControl1);
            this.panel1.Controls.Add(this.lab_Cnt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lab_Sum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 478);
            this.panel1.TabIndex = 12;
            // 
            // pagerControl1
            // 
            this.pagerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pagerControl1.JumpText = "Go";
            this.pagerControl1.Location = new System.Drawing.Point(2, 357);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 10;
            this.pagerControl1.RecordSize = 0;
            this.pagerControl1.Size = new System.Drawing.Size(888, 29);
            this.pagerControl1.TabIndex = 20;
            // 
            // lab_Cnt
            // 
            this.lab_Cnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Cnt.AutoSize = true;
            this.lab_Cnt.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Cnt.Location = new System.Drawing.Point(92, 430);
            this.lab_Cnt.Name = "lab_Cnt";
            this.lab_Cnt.Size = new System.Drawing.Size(27, 27);
            this.lab_Cnt.TabIndex = 19;
            this.lab_Cnt.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "数量：";
            // 
            // lab_Sum
            // 
            this.lab_Sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Sum.AutoSize = true;
            this.lab_Sum.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Sum.Location = new System.Drawing.Point(308, 430);
            this.lab_Sum.Name = "lab_Sum";
            this.lab_Sum.Size = new System.Drawing.Size(72, 27);
            this.lab_Sum.TabIndex = 17;
            this.lab_Sum.Text = "0.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(228, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 16;
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
            this.cSupplyID,
            this.cAgent,
            this.cPrice,
            this.cSum,
            this.cOperator,
            this.cOutTime,
            this.cDetail,
            this.cDel});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 349);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cSupplyID
            // 
            this.cSupplyID.DataPropertyName = "SupplyID";
            this.cSupplyID.HeaderText = "供货单号";
            this.cSupplyID.Name = "cSupplyID";
            this.cSupplyID.ReadOnly = true;
            this.cSupplyID.Width = 150;
            // 
            // cAgent
            // 
            this.cAgent.DataPropertyName = "AgentName";
            this.cAgent.HeaderText = "客户名称";
            this.cAgent.Name = "cAgent";
            this.cAgent.ReadOnly = true;
            this.cAgent.Width = 80;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.cPrice.HeaderText = "每平米价格";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // cSum
            // 
            this.cSum.DataPropertyName = "SumPrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.cSum.DefaultCellStyle = dataGridViewCellStyle3;
            this.cSum.HeaderText = "金额";
            this.cSum.Name = "cSum";
            this.cSum.ReadOnly = true;
            this.cSum.Width = 80;
            // 
            // cOperator
            // 
            this.cOperator.DataPropertyName = "Operator";
            this.cOperator.HeaderText = "操作员";
            this.cOperator.Name = "cOperator";
            this.cOperator.ReadOnly = true;
            // 
            // cOutTime
            // 
            this.cOutTime.DataPropertyName = "CreateTime";
            this.cOutTime.HeaderText = "出单时间";
            this.cOutTime.Name = "cOutTime";
            this.cOutTime.ReadOnly = true;
            // 
            // cDetail
            // 
            this.cDetail.ActiveLinkColor = System.Drawing.Color.Blue;
            this.cDetail.HeaderText = "";
            this.cDetail.Name = "cDetail";
            this.cDetail.ReadOnly = true;
            this.cDetail.VisitedLinkColor = System.Drawing.Color.Blue;
            this.cDetail.Width = 60;
            // 
            // cDel
            // 
            this.cDel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.cDel.HeaderText = "";
            this.cDel.Name = "cDel";
            this.cDel.ReadOnly = true;
            this.cDel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.cDel.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Barcode);
            this.groupBox1.Controls.Add(this.cbx_Agent);
            this.groupBox1.Controls.Add(this.txt_SupplyNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 78);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出仓查询";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(787, 31);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(59, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "查 询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Barcode
            // 
            this.txt_Barcode.Location = new System.Drawing.Point(266, 33);
            this.txt_Barcode.Name = "txt_Barcode";
            this.txt_Barcode.Size = new System.Drawing.Size(112, 21);
            this.txt_Barcode.TabIndex = 3;
            // 
            // cbx_Agent
            // 
            this.cbx_Agent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Agent.FormattingEnabled = true;
            this.cbx_Agent.Items.AddRange(new object[] {
            "AA",
            "BB",
            "CC"});
            this.cbx_Agent.Location = new System.Drawing.Point(457, 32);
            this.cbx_Agent.Name = "cbx_Agent";
            this.cbx_Agent.Size = new System.Drawing.Size(278, 20);
            this.cbx_Agent.TabIndex = 2;
            // 
            // txt_SupplyNo
            // 
            this.txt_SupplyNo.Location = new System.Drawing.Point(80, 32);
            this.txt_SupplyNo.Name = "txt_SupplyNo";
            this.txt_SupplyNo.Size = new System.Drawing.Size(102, 21);
            this.txt_SupplyNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "供货单号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "条形码：";
            // 
            // frmGoodsSearch
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGoodsSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmGoodsSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Barcode;
        private System.Windows.Forms.ComboBox cbx_Agent;
        private System.Windows.Forms.TextBox txt_SupplyNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_Cnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_Sum;
        private System.Windows.Forms.Label label7;
        private WinFormPager.PagerControl pagerControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSupplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOutTime;
        private System.Windows.Forms.DataGridViewLinkColumn cDetail;
        private System.Windows.Forms.DataGridViewLinkColumn cDel;
    }
}