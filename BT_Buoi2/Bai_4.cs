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
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }
        private string ChuyenChuThuong(string text)
        {
            return text.ToLower();
        }
        private string ChuyenChuHoa(string text)
        {
            return text.ToUpper();
        }
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string input = txtHoTen.Text;

            if (rdThuong.Checked)
            {
                lblKetQua.Text = ChuyenChuThuong(input);
            }
            else if (rdHoa.Checked)
            {
                lblKetQua.Text = ChuyenChuHoa(input);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu chữ!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            lblKetQua.Text = ""; 
            rdThuong.Checked = false;
            rdHoa.Checked = false;
            txtHoTen.Focus();
        }
    }
}
