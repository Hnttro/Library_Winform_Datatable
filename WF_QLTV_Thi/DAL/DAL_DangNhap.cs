using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        private string connectionString = @"Data Source=LAPTOP-LC4HKGSK;Initial Catalog=QLThuVien;Integrated Security=True";

        public bool Login(string taikhoan, string matkhau, out bool isEmployee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_Login", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", taikhoan);
                    command.Parameters.AddWithValue("@Password", matkhau);

                    SqlParameter outputIsEmployee = new SqlParameter("@IsEmployee", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIsEmployee);

                    int result = (int)command.ExecuteScalar();

                    isEmployee = outputIsEmployee.Value != DBNull.Value && (bool)outputIsEmployee.Value;

                    return result == 1;
                }
            }
        }
    }
}
