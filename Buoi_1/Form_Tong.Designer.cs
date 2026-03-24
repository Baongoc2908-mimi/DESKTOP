namespace Buoi_1
{
    partial class Form_Tong
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.lbKQ = new System.Windows.Forms.Label();
            this.tong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(86, 54);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(86, 87);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(19, 87);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(61, 13);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "Number 2";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(166, 126);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(58, 30);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.BackColor = System.Drawing.SystemColors.Info;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.Color.Red;
            this.lbKQ.Location = new System.Drawing.Point(83, 177);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(67, 17);
            this.lbKQ.TabIndex = 5;
            this.lbKQ.Text = "Ket Qua";
            this.lbKQ.Click += new System.EventHandler(this.lbKQ_Click);
            // 
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(16, 174);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(64, 20);
            this.tong.TabIndex = 6;
            this.tong.Text = "Tong =";
            this.tong.Click += new System.EventHandler(this.tong_Click);
            // 
            // Form_Tong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(269, 236);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form_Tong";
            this.Text = "Form_Tong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Tong_FormClosing);
            this.Load += new System.EventHandler(this.Form_Tong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Label tong;
    }
}