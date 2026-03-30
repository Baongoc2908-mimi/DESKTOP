namespace BT_Buoi1
{
    partial class Bai_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btChia = new RadioButton();
            btTru = new RadioButton();
            btNhan = new RadioButton();
            btCong = new RadioButton();
            textBox5 = new TextBox();
            lbKQ = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveBorder;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox1.Location = new Point(63, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "Number 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox2.Location = new Point(63, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 24);
            textBox2.TabIndex = 1;
            textBox2.Text = "Number 2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(190, 40);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(135, 23);
            txtNum1.TabIndex = 2;
            txtNum1.KeyPress += txtNum1_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(190, 88);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(135, 23);
            txtNum2.TabIndex = 3;
            txtNum2.KeyPress += txtNum2_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 124);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btChia);
            groupBox1.Controls.Add(btTru);
            groupBox1.Controls.Add(btNhan);
            groupBox1.Controls.Add(btCong);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(36, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 171);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phép Toán";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btChia
            // 
            btChia.AutoSize = true;
            btChia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btChia.ForeColor = Color.Yellow;
            btChia.Location = new Point(224, 100);
            btChia.Name = "btChia";
            btChia.Size = new Size(57, 24);
            btChia.TabIndex = 9;
            btChia.TabStop = true;
            btChia.Text = "Chia";
            btChia.UseVisualStyleBackColor = true;
            btChia.CheckedChanged += btChia_CheckedChanged_1;
            // 
            // btTru
            // 
            btTru.AutoSize = true;
            btTru.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btTru.ForeColor = Color.Yellow;
            btTru.Location = new Point(73, 100);
            btTru.Name = "btTru";
            btTru.Size = new Size(51, 24);
            btTru.TabIndex = 8;
            btTru.TabStop = true;
            btTru.Text = "Trừ";
            btTru.UseVisualStyleBackColor = true;
            btTru.CheckedChanged += btTru_CheckedChanged;
            // 
            // btNhan
            // 
            btNhan.AutoSize = true;
            btNhan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btNhan.ForeColor = Color.Yellow;
            btNhan.Location = new Point(224, 59);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(65, 24);
            btNhan.TabIndex = 7;
            btNhan.TabStop = true;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.CheckedChanged += btNhan_CheckedChanged_1;
            // 
            // btCong
            // 
            btCong.AutoSize = true;
            btCong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btCong.ForeColor = Color.Yellow;
            btCong.Location = new Point(73, 59);
            btCong.Name = "btCong";
            btCong.Size = new Size(63, 24);
            btCong.TabIndex = 6;
            btCong.TabStop = true;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.CheckedChanged += btCong_CheckedChanged_1;
            btCong.TextChanged += btTru_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBox5.Location = new Point(36, 341);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 24);
            textBox5.TabIndex = 6;
            textBox5.Text = "Kết quả: ";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // lbKQ
            // 
            lbKQ.AutoSize = true;
            lbKQ.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbKQ.ForeColor = Color.FromArgb(192, 0, 192);
            lbKQ.Location = new Point(135, 340);
            lbKQ.Name = "lbKQ";
            lbKQ.Size = new Size(0, 25);
            lbKQ.TabIndex = 8;
            lbKQ.Click += lbKQ_Click;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(lbKQ);
            Controls.Add(textBox5);
            Controls.Add(groupBox1);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Bai_1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton btNhan;
        private RadioButton btCong;
        private RadioButton btChia;
        private RadioButton btTru;
        private TextBox textBox5;
        private Label lbKQ;
    }
}
