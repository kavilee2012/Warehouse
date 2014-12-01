namespace Warehouse
{
    partial class frmAgentNormUpdate
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
            this.lab_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Modity = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ID.Location = new System.Drawing.Point(197, 45);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(20, 20);
            this.lab_ID.TabIndex = 20;
            this.lab_ID.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "级别编号：";
            // 
            // btn_Modity
            // 
            this.btn_Modity.Location = new System.Drawing.Point(185, 154);
            this.btn_Modity.Name = "btn_Modity";
            this.btn_Modity.Size = new System.Drawing.Size(75, 23);
            this.btn_Modity.TabIndex = 18;
            this.btn_Modity.Text = "确认修改";
            this.btn_Modity.UseVisualStyleBackColor = true;
            this.btn_Modity.Click += new System.EventHandler(this.btn_Modity_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(197, 102);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(93, 21);
            this.txt_Name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "级别名称：";
            // 
            // frmAgentNormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 255);
            this.Controls.Add(this.lab_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Modity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "frmAgentNormUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.frmAgentNormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Modity;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;

    }
}