namespace BT_Buoi1
{
    partial class Bai_2
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
            label1 = new Label();
            label2 = new Label();
            dtDT = new DateTimePicker();
            txtND = new TextBox();
            btAdd = new Button();
            btRemove = new Button();
            lsND = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(29, 40);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn thời gian";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(81, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Nội dung";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtDT
            // 
            dtDT.CalendarForeColor = Color.FromArgb(192, 192, 255);
            dtDT.Font = new Font("Segoe UI", 10F);
            dtDT.Location = new Point(178, 40);
            dtDT.Name = "dtDT";
            dtDT.Size = new Size(177, 25);
            dtDT.TabIndex = 2;
            // 
            // txtND
            // 
            txtND.Font = new Font("Segoe UI", 10F);
            txtND.Location = new Point(178, 75);
            txtND.Multiline = true;
            txtND.Name = "txtND";
            txtND.Size = new Size(308, 153);
            txtND.TabIndex = 3;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(0, 192, 0);
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btAdd.ForeColor = Color.FromArgb(255, 255, 192);
            btAdd.Location = new Point(178, 244);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(102, 37);
            btAdd.TabIndex = 4;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.BackColor = Color.Red;
            btRemove.FlatStyle = FlatStyle.Flat;
            btRemove.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btRemove.ForeColor = Color.White;
            btRemove.Location = new Point(384, 244);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(102, 37);
            btRemove.TabIndex = 5;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = false;
            btRemove.Click += btRemove_Click;
            // 
            // lsND
            // 
            lsND.FormattingEnabled = true;
            lsND.ItemHeight = 15;
            lsND.Location = new Point(178, 299);
            lsND.Name = "lsND";
            lsND.Size = new Size(308, 139);
            lsND.TabIndex = 6;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(559, 450);
            Controls.Add(lsND);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(txtND);
            Controls.Add(dtDT);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai_2";
            Text = "Bai_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtDT;
        private TextBox txtND;
        private Button btAdd;
        private Button btRemove;
        private ListBox lsND;
    }
}