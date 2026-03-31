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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lsBox1.Items.IndexOf(txtND.Text) < 0 && txtND.Text.Length > 0)
            {
                //lsBox1.Items.Add(txtND.Text.Trim());
                lsBox1.Items.Insert(0, txtND.Text);
                txtND.Clear();
            }
        }
        private void lsBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsBox1.SelectedIndex >= 0)
            {
                //txtND.Text = lsBox1.SelectedItem.ToString();
                txtND.Text = lsBox1.Items[lsBox1.SelectedIndex].ToString();
            }
        }
        private void btDel1_Click(object sender, EventArgs e)
        {
            if (lsBox1.SelectedIndex >= 0)
            {
                lsBox1.Items.RemoveAt(lsBox1.SelectedIndex);
            }
            else 
            {
                MessageBox.Show("Hay nhap noi dung.");

            }
        }

        private void btDel2_Click(object sender, EventArgs e)
        {
            if (lsBox2.SelectedIndex >= 0)
            {
                lsBox2.Items.RemoveAt(lsBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Hay nhap noi dung.");
            }
        }

        private void btRight1_Click(object sender, EventArgs e)
        {
            if (lsBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Hay chon noi dung.");
            }
            else
            {
                lsBox2.Items.Add(lsBox1.SelectedItem);
                lsBox1.Items.RemoveAt(lsBox1.SelectedIndex);
            }
        }
        private void XoaTrung()
        {
            //xoa thi ko di chuyen
            for (int i = 1; i < lsBox2.Items.Count; i++)
            {
                if (lsBox2.Items.IndexOf(lsBox2.Items[i]) < i
                    && lsBox2.Items.IndexOf(lsBox2.Items[i]) > -1)
                {
                    lsBox2.Items.RemoveAt(i); i--;
                }
            }
        }
        private void btRight2_Click(object sender, EventArgs e)
        {

            if (lsBox1.Items != null)
            {
                lsBox2.Items.AddRange(lsBox1.Items);
                lsBox1.Items.Clear();
                XoaTrung();
            }
            else
            {
                MessageBox.Show("Hay chon noi dung");
            }

        }
    }
}
