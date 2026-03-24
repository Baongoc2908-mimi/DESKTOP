using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_1
{
    public partial class Form_Tong : Form
    {
        public Form_Tong()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbKQ_Click(object sender, EventArgs e)
        {

        }

        private void tong_Click(object sender, EventArgs e)
        {
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            lbKQ.Text = (int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text)).ToString();
        }

        private void Form_Tong_Load(object sender, EventArgs e)
        {
            //lbKQ.Text = " ";
            //lbKQ.Visible = false;
        }

        private void Form_Tong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show ("Ban muon dong cua so?", "Demo Form", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1);
            if(r == DialogResult.No) 
                e.Cancel = true;
        }
    }
}
