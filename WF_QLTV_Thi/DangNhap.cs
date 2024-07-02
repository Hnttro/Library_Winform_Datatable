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

namespace WF_QLTV_Thi
{
    public partial class DangNhap : Form
    {
        private string connectionString = @"Data Source=LAPTOP-LC4HKGSK;Initial Catalog=QLThuVien;Integrated Security=True";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_tk.Text;
            string matKhau = txt_mk.Text;

            // Kiểm tra nếu tài khoản hoặc mật khẩu chưa được nhập
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra trong bảng nhân viên
                string queryNv = "SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoanNV = @username AND MatKhauNV = @password";
                SqlCommand cmdNv = new SqlCommand(queryNv, connection);
                cmdNv.Parameters.AddWithValue("@username", taiKhoan);
                cmdNv.Parameters.AddWithValue("@password", matKhau);

                int countNv = (int)cmdNv.ExecuteScalar();

                if (countNv > 0)
                {
                    // Lấy tên nhân viên
                    string tenNhanVien = GetTenNhanVien(taiKhoan);
                    // Đăng nhập thành công, mở form nhân viên và thông báo
                    MessageBox.Show("Đăng nhập thành công với tài khoản nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 trangChu = new Form1(tenNhanVien); // Truyền tên nhân viên vào form trang chủ
                    trangChu.ShowDialog();
                    this.Close();
                    return;
                }

                // Kiểm tra trong bảng độc giả
                string queryDg = "SELECT COUNT(*) FROM DOCGIA WHERE TaiKhoanDG = @username AND MatKhauDG = @password";
                SqlCommand cmdDg = new SqlCommand(queryDg, connection);
                cmdDg.Parameters.AddWithValue("@username", taiKhoan);
                cmdDg.Parameters.AddWithValue("@password", matKhau);

                int countDg = (int)cmdDg.ExecuteScalar();

                if (countDg > 0)
                {
                    // Đăng nhập thành công, mở form độc giả và thông báo
                    MessageBox.Show("Đăng nhập thành công với tài khoản độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DOCGIA fDocGia = new DOCGIA();
                    fDocGia.ShowDialog();
                    this.Close();
                    return;
                }

                // Nếu không đăng nhập được
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetTenNhanVien(string taiKhoan)
        {
            string tenNhanVien = "";
            string query = "SELECT TenNV FROM NHANVIEN WHERE TaiKhoanNV = @taiKhoan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        tenNhanVien = result.ToString();
                    }
                }
            }

            return tenNhanVien;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

        }
    }
}
