using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_NHANVIEN
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable NV_select_all()
		{
			return thaotac.SQL_LayDL("SP_NhanVien_Select_All");
		}

		public DataTable NV_select_DK(string MaNV)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maNV"; value[0] = MaNV;
			return thaotac.SQL_LayDL_CoDK("SP_NhanVien_Select", name, value, 1);
		}

		public int NV_insert(string MaNV, string TenNV, string MaCV, DateTime ngaySinh, string gioiTinh, string sdt,string tk,string mk)
		{
			name = new string[8];
			value = new object[8];
			name[0] = "@maNV"; value[0] = MaNV;
			name[1] = "@tenNV"; value[1] = TenNV;
			name[2] = "@maCV"; value[2] = MaCV;
			name[3] = "@ngaySinh"; value[3] = ngaySinh;
			name[4] = "@gioiTinh"; value[4] = gioiTinh;
			name[5] = "@sdt"; value[5] = sdt;
			name[6] = "@tk"; value[6] = tk;
			name[7] = "@mk"; value[7] = mk;
			return thaotac.SQL_thuchien("SP_NhanVien_Insert", name, value, 8);
		}

		public int NV_update(string MaNV, string TenNV, string MaCV, DateTime ngaySinh, string gioiTinh, string sdt, string tk, string mk)
		{
			name = new string[8];
			value = new object[8];
			name[0] = "@maNV"; value[0] = MaNV;
			name[1] = "@tenNV"; value[1] = TenNV;
			name[2] = "@maCV"; value[2] = MaCV;
			name[3] = "@ngaySinh"; value[3] = ngaySinh;
			name[4] = "@gioiTinh"; value[4] = gioiTinh;
			name[5] = "@sdt"; value[5] = sdt;
			name[6] = "@tk"; value[6] = tk;
			name[7] = "@mk"; value[7] = mk;
			return thaotac.SQL_thuchien("SP_NhanVien_Update", name, value, 8);
		}

		public int NV_delete(string MaNV)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maNV"; value[0] = MaNV;
			return thaotac.SQL_thuchien("SP_NhanVien_Delete", name, value, 1);
		}
	}
}
