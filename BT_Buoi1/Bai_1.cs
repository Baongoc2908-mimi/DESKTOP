using System.Globalization;
using System.Text;

namespace BT_Buoi1
{

    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbKQ_Click(object sender, EventArgs e)
        {

        }

        private void btTru_CheckedChanged(object sender, EventArgs e)
        {
            lbKQ.Text = (txtNum1.Text + " - " + txtNum2.Text + " = " +
                      (double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text)).ToString());
        }

        private void btCong_CheckedChanged_1(object sender, EventArgs e)
        {

            lbKQ.Text = (txtNum1.Text + " + " + txtNum2.Text + " = " +
                     (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString());
        }

        private void btNhan_CheckedChanged_1(object sender, EventArgs e)
        {
            lbKQ.Text = (txtNum1.Text + " * " + txtNum2.Text + " = " +
                      (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text)).ToString());
        }

        private void btChia_CheckedChanged_1(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = int.Parse(txtNum2.Text);
            if (a == 0)
            {
                MessageBox.Show("Không chia được cho 0.");
                return;
            }
            else
            {
                lbKQ.Text = (txtNum1.Text + " / " + txtNum2.Text + " = " +
                      (double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text)).ToString());
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //chan ky tu
            }
        }


        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
