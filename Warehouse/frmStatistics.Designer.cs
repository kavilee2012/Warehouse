namespace Warehouse
{
    partial class frmStatistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOutMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtp_End);
            this.groupBox1.Controls.Add(this.dtp_Start);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 78);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出仓查询";
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(371, 34);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(129, 21);
            this.dtp_End.TabIndex = 17;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(139, 33);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(129, 21);
            this.dtp_Start.TabIndex = 16;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(586, 32);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(59, 23);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "查 询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "开始日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束日期：";
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
            this.cNorm,
            this.cIn,
            this.cOut,
            this.cCnt,
            this.cNowTime,
            this.cOutMoney,
            this.cDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(7, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 500);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // cNorm
            // 
            this.cNorm.DataPropertyName = "NormName";
            this.cNorm.HeaderText = "成品规格(单位:米)";
            this.cNorm.Name = "cNorm";
            this.cNorm.ReadOnly = true;
            this.cNorm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNorm.Width = 200;
            // 
            // cIn
            // 
            this.cIn.DataPropertyName = "InCnt";
            this.cIn.HeaderText = "入仓数量";
            this.cIn.Name = "cIn";
            this.cIn.ReadOnly = true;
            this.cIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cOut
            // 
            this.cOut.DataPropertyName = "OutCnt";
            this.cOut.HeaderText = "出仓数量";
            this.cOut.Name = "cOut";
            this.cOut.ReadOnly = true;
            this.cOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCnt
            // 
            this.cCnt.DataPropertyName = "StoreCnt";
            this.cCnt.HeaderText = "当前库存";
            this.cCnt.Name = "cCnt";
            this.cCnt.ReadOnly = true;
            this.cCnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cCnt.Visible = false;
            this.cCnt.Width = 200;
            // 
            // cNowTime
            // 
            this.cNowTime.DataPropertyName = "NowTime";
            this.cNowTime.HeaderText = "截止时间";
            this.cNowTime.Name = "cNowTime";
            this.cNowTime.ReadOnly = true;
            this.cNowTime.Visible = false;
            this.cNowTime.Width = 150;
            // 
            // cOutMoney
            // 
            this.cOutMoney.DataPropertyName = "OutMoney";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cOutMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.cOutMoney.HeaderText = "出仓金额";
            this.cOutMoney.Name = "cOutMoney";
            this.cOutMoney.ReadOnly = true;
            this.cOutMoney.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStatistics";
            this.Text = "frmStatistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOutMoney;
        private System.Windows.Forms.DataGridViewLinkColumn cDel;
    }
}