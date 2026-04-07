using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_3
{
    public partial class Form3 : Form
    {
        DataSet ds = new DataSet();
        string cnnString = "Data Source=B103PC34;Initial Catalog=QLBH;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        public Form3()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = cnnString; // de ow formload
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from SanPham", cnn);
            da = new SqlDataAdapter(); // formload
            da.SelectCommand = cmd;
            da.Fill(ds, "SP");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SP";

        }
    }
}
