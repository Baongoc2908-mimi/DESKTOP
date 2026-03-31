namespace Buoi_2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBlack = new System.Windows.Forms.RadioButton();
            this.btBlue = new System.Windows.Forms.RadioButton();
            this.btGreen = new System.Windows.Forms.RadioButton();
            this.btRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckUnderline = new System.Windows.Forms.CheckBox();
            this.ckItalic = new System.Windows.Forms.CheckBox();
            this.ckBold = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.LbResult = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckRT = new System.Windows.Forms.CheckBox();
            this.btApply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btBlack);
            this.groupBox1.Controls.Add(this.btBlue);
            this.groupBox1.Controls.Add(this.btGreen);
            this.groupBox1.Controls.Add(this.btRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(245, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // btBlack
            // 
            this.btBlack.AutoSize = true;
            this.btBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBlack.Location = new System.Drawing.Point(14, 124);
            this.btBlack.Name = "btBlack";
            this.btBlack.Size = new System.Drawing.Size(71, 24);
            this.btBlack.TabIndex = 3;
            this.btBlack.TabStop = true;
            this.btBlack.Text = "Black";
            this.btBlack.UseVisualStyleBackColor = true;
            this.btBlack.CheckedChanged += new System.EventHandler(this.btBlack_CheckedChanged);
            // 
            // btBlue
            // 
            this.btBlue.AutoSize = true;
            this.btBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBlue.ForeColor = System.Drawing.Color.Blue;
            this.btBlue.Location = new System.Drawing.Point(14, 97);
            this.btBlue.Name = "btBlue";
            this.btBlue.Size = new System.Drawing.Size(63, 24);
            this.btBlue.TabIndex = 2;
            this.btBlue.TabStop = true;
            this.btBlue.Text = "Blue";
            this.btBlue.UseVisualStyleBackColor = true;
            this.btBlue.CheckedChanged += new System.EventHandler(this.btBlue_CheckedChanged);
            // 
            // btGreen
            // 
            this.btGreen.AutoSize = true;
            this.btGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGreen.ForeColor = System.Drawing.Color.Lime;
            this.btGreen.Location = new System.Drawing.Point(14, 67);
            this.btGreen.Name = "btGreen";
            this.btGreen.Size = new System.Drawing.Size(77, 24);
            this.btGreen.TabIndex = 1;
            this.btGreen.TabStop = true;
            this.btGreen.Text = "Green";
            this.btGreen.UseVisualStyleBackColor = true;
            this.btGreen.CheckedChanged += new System.EventHandler(this.btGreen_CheckedChanged);
            // 
            // btRed
            // 
            this.btRed.AutoSize = true;
            this.btRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRed.ForeColor = System.Drawing.Color.Red;
            this.btRed.Location = new System.Drawing.Point(14, 35);
            this.btRed.Name = "btRed";
            this.btRed.Size = new System.Drawing.Size(60, 24);
            this.btRed.TabIndex = 0;
            this.btRed.TabStop = true;
            this.btRed.Text = "Red";
            this.btRed.UseVisualStyleBackColor = true;
            this.btRed.CheckedChanged += new System.EventHandler(this.btRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.ckUnderline);
            this.groupBox2.Controls.Add(this.ckItalic);
            this.groupBox2.Controls.Add(this.ckBold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 195);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // ckUnderline
            // 
            this.ckUnderline.AutoSize = true;
            this.ckUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUnderline.Location = new System.Drawing.Point(6, 98);
            this.ckUnderline.Name = "ckUnderline";
            this.ckUnderline.Size = new System.Drawing.Size(96, 24);
            this.ckUnderline.TabIndex = 2;
            this.ckUnderline.Text = "Underline";
            this.ckUnderline.UseVisualStyleBackColor = true;
            this.ckUnderline.CheckStateChanged += new System.EventHandler(this.ckUnderline_CheckStateChanged);
            // 
            // ckItalic
            // 
            this.ckItalic.AutoSize = true;
            this.ckItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckItalic.Location = new System.Drawing.Point(6, 68);
            this.ckItalic.Name = "ckItalic";
            this.ckItalic.Size = new System.Drawing.Size(61, 24);
            this.ckItalic.TabIndex = 1;
            this.ckItalic.Text = "Italic";
            this.ckItalic.UseVisualStyleBackColor = true;
            this.ckItalic.CheckStateChanged += new System.EventHandler(this.ckItalic_CheckStateChanged);
            // 
            // ckBold
            // 
            this.ckBold.AutoSize = true;
            this.ckBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBold.Location = new System.Drawing.Point(6, 36);
            this.ckBold.Name = "ckBold";
            this.ckBold.Size = new System.Drawing.Size(64, 24);
            this.ckBold.TabIndex = 0;
            this.ckBold.Text = "Blod";
            this.ckBold.UseVisualStyleBackColor = true;
            this.ckBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.ckBold.CheckStateChanged += new System.EventHandler(this.ckBold_CheckStateChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(328, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Designed by";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(367, 335);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(0, 24);
            this.lbKQ.TabIndex = 6;
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResult.Location = new System.Drawing.Point(397, 416);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(0, 20);
            this.LbResult.TabIndex = 7;
            this.LbResult.Click += new System.EventHandler(this.LbResult_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(474, 444);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 35);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btApply);
            this.groupBox3.Controls.Add(this.ckRT);
            this.groupBox3.Location = new System.Drawing.Point(245, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // ckRT
            // 
            this.ckRT.AutoSize = true;
            this.ckRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRT.Location = new System.Drawing.Point(23, 25);
            this.ckRT.Name = "ckRT";
            this.ckRT.Size = new System.Drawing.Size(100, 21);
            this.ckRT.TabIndex = 0;
            this.ckRT.Text = "Real Time";
            this.ckRT.UseVisualStyleBackColor = true;
            // 
            // btApply
            // 
            this.btApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApply.Location = new System.Drawing.Point(212, 19);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(75, 31);
            this.btApply.TabIndex = 1;
            this.btApply.Text = "Apply All";
            this.btApply.UseVisualStyleBackColor = false;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btBlack;
        private System.Windows.Forms.RadioButton btBlue;
        private System.Windows.Forms.RadioButton btGreen;
        private System.Windows.Forms.RadioButton btRed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckBold;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox ckUnderline;
        private System.Windows.Forms.CheckBox ckItalic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.CheckBox ckRT;
    }
}

