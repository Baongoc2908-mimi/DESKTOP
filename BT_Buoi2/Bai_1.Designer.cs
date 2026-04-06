namespace BT_Buoi2
{
    partial class Bai_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btCE = new System.Windows.Forms.Button();
            this.btAC = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btBang = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.lsLichSu = new System.Windows.Forms.ListBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btDelAll = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKQ);
            this.groupBox1.Controls.Add(this.txtHienThi);
            this.groupBox1.Controls.Add(this.btCE);
            this.groupBox1.Controls.Add(this.btAC);
            this.groupBox1.Controls.Add(this.btChia);
            this.groupBox1.Controls.Add(this.btNhan);
            this.groupBox1.Controls.Add(this.btTru);
            this.groupBox1.Controls.Add(this.btCong);
            this.groupBox1.Controls.Add(this.btBang);
            this.groupBox1.Controls.Add(this.Dot);
            this.groupBox1.Controls.Add(this.bt3);
            this.groupBox1.Controls.Add(this.bt1);
            this.groupBox1.Controls.Add(this.bt2);
            this.groupBox1.Controls.Add(this.bt6);
            this.groupBox1.Controls.Add(this.bt5);
            this.groupBox1.Controls.Add(this.bt4);
            this.groupBox1.Controls.Add(this.bt7);
            this.groupBox1.Controls.Add(this.bt9);
            this.groupBox1.Controls.Add(this.bt8);
            this.groupBox1.Controls.Add(this.bt0);
            this.groupBox1.Location = new System.Drawing.Point(188, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(22, 16);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(122, 75);
            this.txtHienThi.TabIndex = 19;
            // 
            // btCE
            // 
            this.btCE.Location = new System.Drawing.Point(217, 63);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(60, 28);
            this.btCE.TabIndex = 17;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btAC
            // 
            this.btAC.Location = new System.Drawing.Point(151, 63);
            this.btAC.Name = "btAC";
            this.btAC.Size = new System.Drawing.Size(60, 28);
            this.btAC.TabIndex = 16;
            this.btAC.Text = "AC";
            this.btAC.UseVisualStyleBackColor = true;
            this.btAC.Click += new System.EventHandler(this.btAC_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(217, 97);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(60, 41);
            this.btChia.TabIndex = 15;
            this.btChia.Text = "÷";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(217, 144);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(60, 41);
            this.btNhan.TabIndex = 14;
            this.btNhan.Text = "×";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(217, 191);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(60, 41);
            this.btTru.TabIndex = 13;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(217, 238);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(60, 41);
            this.btCong.TabIndex = 12;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btBang
            // 
            this.btBang.Location = new System.Drawing.Point(151, 238);
            this.btBang.Name = "btBang";
            this.btBang.Size = new System.Drawing.Size(60, 41);
            this.btBang.TabIndex = 11;
            this.btBang.Text = "=";
            this.btBang.UseVisualStyleBackColor = true;
            this.btBang.Click += new System.EventHandler(this.btBang_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(85, 238);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(60, 41);
            this.Dot.TabIndex = 10;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(151, 191);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 41);
            this.bt3.TabIndex = 9;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(19, 191);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 41);
            this.bt1.TabIndex = 8;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(85, 191);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 41);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(151, 144);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(60, 41);
            this.bt6.TabIndex = 6;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(85, 144);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(60, 41);
            this.bt5.TabIndex = 5;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(19, 144);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(60, 41);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(19, 97);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(60, 41);
            this.bt7.TabIndex = 3;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(151, 97);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(60, 41);
            this.bt9.TabIndex = 2;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(85, 97);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(60, 41);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(19, 238);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(60, 41);
            this.bt0.TabIndex = 0;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // lsLichSu
            // 
            this.lsLichSu.FormattingEnabled = true;
            this.lsLichSu.Location = new System.Drawing.Point(491, 62);
            this.lsLichSu.Name = "lsLichSu";
            this.lsLichSu.Size = new System.Drawing.Size(166, 264);
            this.lsLichSu.TabIndex = 2;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(603, 32);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(54, 24);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btDelAll
            // 
            this.btDelAll.Location = new System.Drawing.Point(491, 32);
            this.btDelAll.Name = "btDelAll";
            this.btDelAll.Size = new System.Drawing.Size(61, 24);
            this.btDelAll.TabIndex = 4;
            this.btDelAll.Text = "Del All";
            this.btDelAll.UseVisualStyleBackColor = true;
            this.btDelAll.Click += new System.EventHandler(this.btDelAll_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(150, 16);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(127, 44);
            this.txtKQ.TabIndex = 20;
            // 
            // Bai_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDelAll);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.lsLichSu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai_1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btBang;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btAC;
        private System.Windows.Forms.ListBox lsLichSu;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btDelAll;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

