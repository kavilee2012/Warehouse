namespace Warehouse
{
    partial class frmCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Name = new System.Windows.Forms.Button();
            this.btn_Phone = new System.Windows.Forms.Button();
            this.btn_Address = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "联系地址：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 21);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Address);
            this.groupBox1.Controls.Add(this.btn_Phone);
            this.groupBox1.Controls.Add(this.btn_Name);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公司信息设置（打印送货单时显示）";
            // 
            // btn_Name
            // 
            this.btn_Name.Location = new System.Drawing.Point(387, 45);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Size = new System.Drawing.Size(52, 23);
            this.btn_Name.TabIndex = 6;
            this.btn_Name.Text = "设定";
            this.btn_Name.UseVisualStyleBackColor = true;
            this.btn_Name.Click += new System.EventHandler(this.btn_Name_Click);
            // 
            // btn_Phone
            // 
            this.btn_Phone.Location = new System.Drawing.Point(387, 128);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(52, 23);
            this.btn_Phone.TabIndex = 7;
            this.btn_Phone.Text = "设定";
            this.btn_Phone.UseVisualStyleBackColor = true;
            this.btn_Phone.Click += new System.EventHandler(this.btn_Phone_Click);
            // 
            // btn_Address
            // 
            this.btn_Address.Location = new System.Drawing.Point(387, 214);
            this.btn_Address.Name = "btn_Address";
            this.btn_Address.Size = new System.Drawing.Size(52, 23);
            this.btn_Address.TabIndex = 8;
            this.btn_Address.Text = "设定";
            this.btn_Address.UseVisualStyleBackColor = true;
            this.btn_Address.Click += new System.EventHandler(this.btn_Address_Click);
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompany";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Name;
        private System.Windows.Forms.Button btn_Address;
        private System.Windows.Forms.Button btn_Phone;
    }
}