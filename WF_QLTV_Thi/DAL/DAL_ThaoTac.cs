using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThaoTac
    {
		SqlConnection cn;
		SqlDataAdapter da;
		DataTable dt;
		string constr = @"Data Source=LAPTOP-LC4HKGSK;Initial Catalog=QLThuVien;Integrated Security=True";

		private void KetNoi()
		{
			cn = new SqlConnection(constr);
			cn.Open();
		}
		private void NgatKetNoi()
		{
			cn.Close();
			cn.Dispose();
		}
		public DataTable SQL_LayDL(string TenB)
		{
			KetNoi();
			SqlCommand cmd = new SqlCommand(TenB, cn);
			cmd.CommandType = CommandType.StoredProcedure;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			NgatKetNoi();
			return dt;
		}
		public int SQL_thuchien(string TenB, string[] name, object[] value, int NPara)
		{
			//tensp: tên của store procedure sẽ gọi
			//string []name: mảng chứa tên các thuộc tính nằm trong store procedure
			//object[] value: mảng chứa các giá trị trong store procedure
			//int Npara: số tham số của Store Procedure
			KetNoi();
			SqlCommand cmd = new SqlCommand(TenB, cn);
			cmd.CommandType = CommandType.StoredProcedure;
			for (int i = 0; i < NPara; i++)
			{
				cmd.Parameters.AddWithValue(name[i], value[i]);
			}
			return cmd.ExecuteNonQuery();
		}

		public DataTable SQL_LayDL_CoDK(string TenB, string[] name, object[] value, int NPara)
		{
			KetNoi();
			SqlCommand cmd = new SqlCommand(TenB, cn);
			cmd.CommandType = CommandType.StoredProcedure;
			for (int i = 0; i < NPara; i++)
			{
				cmd.Parameters.AddWithValue(name[i], value[i]);
			}
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			NgatKetNoi();
			return dt;
		}

	}
}
