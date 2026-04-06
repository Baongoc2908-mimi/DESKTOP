using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi2
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;

            if (s1 == s2)
                lblKQ.Text = "Hai chuỗi GIỐNG nhau (có phân biệt hoa/thường)";
            else
                lblKQ.Text = "Hai chuỗi KHÁC nhau (có phân biệt hoa/thường)";
        }

        private void btnCompare2_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;

            if (string.Compare(s1, s2, true) == 0)
                lblKQ.Text = "Hai chuỗi GIỐNG nhau (không phân biệt)";
            else
                lblKQ.Text = "Hai chuỗi KHÁC nhau (không phân biệt)";
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            lblKQ.Text = txtS1.Text + " " + txtS2.Text;
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;

            int index = s1.IndexOf(s2);

            if (index != -1)
            {
                string newStr = s1.Replace(s2, "CHỖ NÀY");
                lblKQ.Text = $"Vị trí: {index} | Sau thay thế: {newStr}";
            }
            else
            {
                lblKQ.Text = "Không tìm thấy chuỗi";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string s1 = txtS1.Text;
            string s2 = txtS2.Text;

            string[] words = s1.Split(' ');

            if (words.Length < 2)
            {
                lblKQ.Text = "Chuỗi S1 phải có ít nhất 2 từ";
                return;
            }

            // sau tu dau
            words[0] = words[0] + " " + s2;

            // trc tu cuoi
            words[words.Length - 1] = s2 + " " + words[words.Length - 1];

            lblKQ.Text = string.Join(" ", words);
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string tieuDe = lblTieuDe.Text;
            string target = "TRÌNH XỬ LÝ";

            int index = tieuDe.IndexOf(target);

            if (index != -1)
            {
                string newStr = tieuDe.Remove(index, target.Length);
                lblTieuDe.Text = newStr;
                lblKQ.Text = "Đã xóa 'TRÌNH XỬ LÝ'";
            }
            else
            {
                lblKQ.Text = "Không tìm thấy 'TRÌNH XỬ LÝ'";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtS1.Clear();
            txtS2.Clear();
            lblKQ.Text = "";

            txtS1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
