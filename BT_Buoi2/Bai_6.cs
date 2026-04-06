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
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
        }
        private HoTen LayDoiTuong()
        {
            return new HoTen(txtHoTen.Text);
        }
        private bool KiemTraNhap()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }
            return true;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với chương trình xử lý họ tên của ABC");
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;

            HoTen ht = LayDoiTuong();
            lblKetQua.Text = ht.LayHoLot();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;

            HoTen ht = LayDoiTuong();
            lblKetQua.Text = ht.LayTen();
        }

        private void btnDemTu_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;

            HoTen ht = LayDoiTuong();
            lblKetQua.Text = "Số từ: " + ht.DemTu();
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;

            HoTen ht = LayDoiTuong();
            lblKetQua.Text = ht.HoaDauTu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            lblKetQua.Text = "";
            txtHoTen.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
