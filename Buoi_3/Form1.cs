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
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectString = "Data Source=B103PC34;Initial Catalog=QLBH;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            cnn.ConnectionString = connectString;
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT COUNT(*) FROM HoaDon";
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            //Đếm số hóa đơn 
            int count = (int)cmd.ExecuteScalar();
            txtKQ.Text = count.ToString();
            cnn.Close();
        }

        private void btDem_Click(object sender, EventArgs e)
        {
            /*cmd.CommandText = "INSERT INTO LoaiSanPham(MaLoai, TenLoai) " +
                                "VALUES(N'" + txtMaLoai.Text + "', N'" + txtTenLoai.Text + "')";*/
            //Add Parameters
            //cmd.Parameters.Add(@ma, SqlDbType.NVarChar);
            //cmd.Parameters.Add(@ten, SqlDbType.NVarChar);

            //cmd.Parameters[@ma] = txtMaloai.Text;
            //cmd.Parameters[@ten] = txtTenloai.Text;

            cmd.Parameters.AddWithValue("@ma", txtMaLoai.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenLoai.Text);

            cmd.CommandText = "INSERT INTO LoaiSanPham(MaLoai, TenLoai) " +
                                "VALUES(@ma, @ten)";
            cmd.CommandType = CommandType.Text;
            try
            {
                cnn.Open();
                //Thực thi câu truy vấn Insert
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            cmd.CommandText ="Select MaSP, TenSP From SanPham";
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            // Thực thi câu truy vấn Select
            SqlDataReader reader = cmd.ExecuteReader();
            //Duyệt trên kết quả reader
            while (reader.Read())
            {
                //Console.WriteLine("San pham: { 0} – { 1}",	 reader.getString(0), reader.getString(1));
                //lsvLoaiSP.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
                
            }
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = connectString;
            cmd.Connection = cnn;
        }
    }
}
