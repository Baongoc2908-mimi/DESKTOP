using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LbResult_Click(object sender, EventArgs e)
        {

        }

        private void btRed_CheckedChanged(object sender, EventArgs e)
        {
            if (btRed.Checked & ckRT.Checked)
            {
                LbResult.ForeColor = Color.Red;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            LbResult.Text = txtName.Text;
        }

        private void btGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (btGreen.Checked & ckRT.Checked)
            {
                LbResult.ForeColor = Color.Green;
            }
        }

        private void btBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (btBlue.Checked & ckRT.Checked)
            {
                LbResult.ForeColor = Color.Blue;
            }
        }

        private void btBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (btBlack.Checked & ckRT.Checked)
            {
                LbResult.ForeColor = Color.Black;
            }
        }

        private void ckBold_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckBold.Checked & ckRT.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Bold);
            }
            else
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Regular);
            }

        }

        private void ckItalic_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckItalic.Checked & ckRT.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Italic);
            }
            else
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Regular);
            }
        }

        private void ckUnderline_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckUnderline.Checked & ckRT.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Underline);
            }
            else
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Regular);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ckRT.Checked = false;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if (btRed.Checked)
            {
                LbResult.ForeColor = Color.Red;
            }
            if (btGreen.Checked)
            {
                LbResult.ForeColor = Color.Green;
            }
            if (btBlue.Checked)
            {
                LbResult.ForeColor = Color.Blue;
            }
            if (btBlack.Checked)
            {
                LbResult.ForeColor = Color.Black;
            }
            if (ckBold.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Bold);
            }
            if (ckItalic.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Italic);
            }
            if (ckUnderline.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Underline);
            }
            if (ckBold.Checked & ckItalic.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (ckBold.Checked & ckUnderline.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (ckItalic.Checked & ckUnderline.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Underline | FontStyle.Italic);
            }
            if (ckItalic.Checked & ckUnderline.Checked & ckBold.Checked)
            {
                LbResult.Font = new Font(LbResult.Font, FontStyle.Underline | FontStyle.Italic | FontStyle.Bold);
            }
        }
    }
}
