using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi1
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtND.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập nội dung");
                return;
            }

            if (txtND.Text.Length <= 10)
            {
                lsND.Items.Add(dtDT.Value.ToString("yyyy-MM-dd") + ": " + txtND.Text);
                txtND.Clear();
            }
            else
            {
                lsND.Items.Add(dtDT.Value.ToString("yyyy-MM-dd") + ": "
                           + txtND.Text.Substring(0, 10) + "...");
                txtND.Clear();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lsND.SelectedIndex >= 0)
            {
                lsND.Items.RemoveAt(lsND.SelectedIndex);
            }
            else
            {
                for (int i = lsND.Items.Count - 1; i >= 0; i--)
                {
                    string item = lsND.Items[i].ToString();
                    if (item.StartsWith(dtDT.Value.ToString("yyyy-MM-dd")))
                    {
                        lsND.Items.RemoveAt(i);
                    }
                }
            }
        }
    }
}
/*
                           +) xóa theo giá trị object.
                        VD: lsND.Items.Remove("admin");
                        => tìm phần tử có admin để xóa nó khỏi danh sách
                           +) xóa theo vị trí (index).
                        VD: lsND.Items.RemoveAt(0);
                        => Xóa phần tử ở vị trí số 0 (dòng đầu tiên)
                       */
