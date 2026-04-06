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
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }
        private void bt0_Click(object sender, EventArgs e) { txtHienThi.Text += "0"; }
        private void bt1_Click(object sender, EventArgs e) { txtHienThi.Text += "1"; }
        private void bt2_Click(object sender, EventArgs e) { txtHienThi.Text += "2"; }
        private void bt3_Click(object sender, EventArgs e) { txtHienThi.Text += "3"; }
        private void bt4_Click(object sender, EventArgs e) { txtHienThi.Text += "4"; }
        private void bt5_Click(object sender, EventArgs e) { txtHienThi.Text += "5"; }
        private void bt6_Click(object sender, EventArgs e) { txtHienThi.Text += "6"; }
        private void bt7_Click(object sender, EventArgs e) { txtHienThi.Text += "7"; }
        private void bt8_Click(object sender, EventArgs e) { txtHienThi.Text += "8"; }
        private void bt9_Click(object sender, EventArgs e) { txtHienThi.Text += "9"; }
        private void btCong_Click(object sender, EventArgs e) {txtHienThi.Text += " + ";}
        private void btTru_Click(object sender, EventArgs e) {txtHienThi.Text += " - ";}
        private void btNhan_Click(object sender, EventArgs e) {txtHienThi.Text += " * ";}

        private void btChia_Click(object sender, EventArgs e) {txtHienThi.Text += " / "; }

        private void Dot_Click(object sender, EventArgs e) {txtHienThi.Text += " . ";}

        private void btAC_Click(object sender, EventArgs e)
        {
            txtHienThi.Clear();
            txtKQ.Clear();
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            if (txtHienThi.Text.EndsWith(" + ") ||
                txtHienThi.Text.EndsWith(" - ") ||
                txtHienThi.Text.EndsWith(" * ") ||
                txtHienThi.Text.EndsWith(" / "))
            {
                txtHienThi.Text = txtHienThi.Text.Substring(0, txtHienThi.Text.Length - 3);
            }
            else if (txtHienThi.Text.Length > 0)
            {
                txtHienThi.Text = txtHienThi.Text.Substring(0, txtHienThi.Text.Length - 1);
            }
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            string input = txtHienThi.Text;
            List<string> PhanTu = input.Split(' ').ToList();

            //xử lý * và /
            for (int i = 0; i < PhanTu.Count; i++)
            {
                if (PhanTu[i] == "*" || PhanTu[i] == "/")
                {
                    double a = double.Parse(PhanTu[i - 1]);
                    double b = double.Parse(PhanTu[i + 1]);
                    double temp = 0;

                    if (PhanTu[i] == "*")
                        temp = a * b;
                    else
                    {
                        if (b == 0)
                        {
                            MessageBox.Show("Không chia được cho 0!");
                            return;
                        }
                        temp = a / b;
                    }

                    PhanTu[i - 1] = temp.ToString();
                    PhanTu.RemoveAt(i);
                    PhanTu.RemoveAt(i);
                    i--;
                }
            }

            //xử lý + và -
            double result = double.Parse(PhanTu[0]);

            for (int i = 1; i < PhanTu.Count; i += 2)
            {
                string op = PhanTu[i];
                double num = double.Parse(PhanTu[i + 1]);

                if (op == "+") result += num;
                else if (op == "-") result -= num;
            }

            txtKQ.Text = "= " + result.ToString();

            // lưu lịch sử
            lsLichSu.Items.Add(input + " = " + result);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lsLichSu.SelectedIndex >= 0)
            {
                lsLichSu.Items.RemoveAt(lsLichSu.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Hãy chọn nội dung.");

            }
        }

        private void btDelAll_Click(object sender, EventArgs e)
        {
            lsLichSu.Items.Clear();
        }
    }
    
}
