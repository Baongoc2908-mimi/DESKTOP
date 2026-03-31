namespace Buoi_2
{
    partial class Form2
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
            this.txtND = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lsBox1 = new System.Windows.Forms.ListBox();
            this.lsBox2 = new System.Windows.Forms.ListBox();
            this.btDel1 = new System.Windows.Forms.Button();
            this.btDel2 = new System.Windows.Forms.Button();
            this.btRight1 = new System.Windows.Forms.Button();
            this.btLeft1 = new System.Windows.Forms.Button();
            this.btRight2 = new System.Windows.Forms.Button();
            this.btLeft2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtND
            // 
            this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(66, 32);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(223, 42);
            this.txtND.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(309, 32);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(107, 42);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lsBox1
            // 
            this.lsBox1.FormattingEnabled = true;
            this.lsBox1.Location = new System.Drawing.Point(66, 150);
            this.lsBox1.Name = "lsBox1";
            this.lsBox1.Size = new System.Drawing.Size(223, 212);
            this.lsBox1.TabIndex = 2;
            this.lsBox1.SelectedIndexChanged += new System.EventHandler(this.lsBox1_SelectedIndexChanged);
            // 
            // lsBox2
            // 
            this.lsBox2.FormattingEnabled = true;
            this.lsBox2.Location = new System.Drawing.Point(383, 150);
            this.lsBox2.Name = "lsBox2";
            this.lsBox2.Size = new System.Drawing.Size(223, 212);
            this.lsBox2.TabIndex = 3;
            // 
            // btDel1
            // 
            this.btDel1.BackColor = System.Drawing.Color.Red;
            this.btDel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel1.ForeColor = System.Drawing.Color.White;
            this.btDel1.Location = new System.Drawing.Point(66, 110);
            this.btDel1.Name = "btDel1";
            this.btDel1.Size = new System.Drawing.Size(107, 34);
            this.btDel1.TabIndex = 4;
            this.btDel1.Text = "Delete";
            this.btDel1.UseVisualStyleBackColor = false;
            this.btDel1.Click += new System.EventHandler(this.btDel1_Click);
            // 
            // btDel2
            // 
            this.btDel2.BackColor = System.Drawing.Color.Red;
            this.btDel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel2.ForeColor = System.Drawing.Color.White;
            this.btDel2.Location = new System.Drawing.Point(383, 110);
            this.btDel2.Name = "btDel2";
            this.btDel2.Size = new System.Drawing.Size(107, 34);
            this.btDel2.TabIndex = 5;
            this.btDel2.Text = "Delete";
            this.btDel2.UseVisualStyleBackColor = false;
            this.btDel2.Click += new System.EventHandler(this.btDel2_Click);
            // 
            // btRight1
            // 
            this.btRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight1.Location = new System.Drawing.Point(309, 178);
            this.btRight1.Name = "btRight1";
            this.btRight1.Size = new System.Drawing.Size(39, 23);
            this.btRight1.TabIndex = 6;
            this.btRight1.Text = ">";
            this.btRight1.UseVisualStyleBackColor = false;
            this.btRight1.Click += new System.EventHandler(this.btRight1_Click);
            // 
            // btLeft1
            // 
            this.btLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft1.Location = new System.Drawing.Point(309, 227);
            this.btLeft1.Name = "btLeft1";
            this.btLeft1.Size = new System.Drawing.Size(39, 23);
            this.btLeft1.TabIndex = 7;
            this.btLeft1.Text = "<";
            this.btLeft1.UseVisualStyleBackColor = false;
            // 
            // btRight2
            // 
            this.btRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight2.Location = new System.Drawing.Point(309, 272);
            this.btRight2.Name = "btRight2";
            this.btRight2.Size = new System.Drawing.Size(39, 23);
            this.btRight2.TabIndex = 8;
            this.btRight2.Text = ">>";
            this.btRight2.UseVisualStyleBackColor = false;
            this.btRight2.Click += new System.EventHandler(this.btRight2_Click);
            // 
            // btLeft2
            // 
            this.btLeft2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft2.Location = new System.Drawing.Point(309, 317);
            this.btLeft2.Name = "btLeft2";
            this.btLeft2.Size = new System.Drawing.Size(39, 23);
            this.btLeft2.TabIndex = 9;
            this.btLeft2.Text = "<<";
            this.btLeft2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLeft2);
            this.Controls.Add(this.btRight2);
            this.Controls.Add(this.btLeft1);
            this.Controls.Add(this.btRight1);
            this.Controls.Add(this.btDel2);
            this.Controls.Add(this.btDel1);
            this.Controls.Add(this.lsBox2);
            this.Controls.Add(this.lsBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtND);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListBox lsBox1;
        private System.Windows.Forms.ListBox lsBox2;
        private System.Windows.Forms.Button btDel1;
        private System.Windows.Forms.Button btDel2;
        private System.Windows.Forms.Button btRight1;
        private System.Windows.Forms.Button btLeft1;
        private System.Windows.Forms.Button btRight2;
        private System.Windows.Forms.Button btLeft2;
    }
}