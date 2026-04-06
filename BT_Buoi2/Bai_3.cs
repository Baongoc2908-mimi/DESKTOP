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
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }
        //USCLN
        int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        void XuLyUSCLN(int a, int b) 
        { 
            int kq = USCLN(a, b); 
            lsResult.Items.Add("USCLN = " + kq); 
        }
        void XuLyUSC(int a, int b) 
        { 
            List<int> usc = GetUSC(a, b); 
            lsResult.Items.Add("Các USC:"); 
            foreach (int x in usc) 
            { 
                lsResult.Items.Add(x); 
            } 
        }
        List<int> GetUSC(int a, int b)
        {
            List<int> result = new List<int>();
            int min = Math.Min(a, b);

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                    result.Add(i);
            }

            return result;
        }
        private void btKetQua_Click(object sender, EventArgs e)
        {
            lsResult.Items.Clear();

            int a, b;

            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Nhập số hợp lệ!");
                return;
            }
            if (btUSCLN.Checked)
            {
                XuLyUSCLN(a, b);
            }
            else if (btUSC.Checked)
            {
                XuLyUSC(a, b);
            }
            else
            {
                MessageBox.Show("Chọn chức năng!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            lsResult.Items.Clear();

            btUSCLN.Checked = false;
            btUSC.Checked = false;
        }
    }
}
