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
    public partial class Form_b1 : Form
    {
        public Form_b1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // txtHoTen.Text = "Vui long nhap ho ten";
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtHoTen.Text.Trim();
            //chỉ được thêm 1 tên, không duoc trung
            if (lbLisHoTen.Items.Contains(name))
            {
                MessageBox.Show("vui long chi nhap 1 ten.");
                return;
            }
            lbLisHoTen.Items.Add(name);
            txtHoTen.Clear();

        }
    }
}
