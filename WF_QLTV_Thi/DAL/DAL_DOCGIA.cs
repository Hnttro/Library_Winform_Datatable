using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_DOCGIA
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable DG_select_all()
		{
			return thaotac.SQL_LayDL("SP_DocGia_Select_All");
		}

		public DataTable DG_select_DK(string MaDG)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maDG"; value[0] = MaDG;
			return thaotac.SQL_LayDL_CoDK("SP_DocGia_Select", name, value, 1);
		}

		public int DG_insert(string MaDG, string TenDG, DateTime ngaySinh, string gioiTinh, string loaiDG, string diaChi, string sdt)
		{
			name = new string[7];
			value = new object[7];
			name[0] = "@maDG"; value[0] = MaDG;
			name[1] = "@tenDG"; value[1] = TenDG;
			name[2] = "@ngaySinh"; value[2] = ngaySinh;
			name[3] = "@gioiTinh"; value[3] = gioiTinh;
			name[4] = "@loaiDG"; value[4] = loaiDG;
			name[5] = "@diaChi"; value[5] = diaChi;
			name[6] = "@sdt"; value[6] = sdt;
			return thaotac.SQL_thuchien("SP_DocGia_Insert", name, value, 7);
		}

		public int DG_update(string MaDG, string TenDG, DateTime ngaySinh, string gioiTinh, string loaiDG, string diaChi, string sdt)
		{
			name = new string[7];
			value = new object[7];
			name[0] = "@maDG"; value[0] = MaDG;
			name[1] = "@tenDG"; value[1] = TenDG;
			name[2] = "@ngaySinh"; value[2] = ngaySinh;
			name[3] = "@gioiTinh"; value[3] = gioiTinh;
			name[4] = "@loaiDG"; value[4] = loaiDG;
			name[5] = "@diaChi"; value[5] = diaChi;
			name[6] = "@sdt"; value[6] = sdt;
			return thaotac.SQL_thuchien("SP_DocGia_Update", name, value, 7);
		}

		public int DG_delete(string MaDG)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maDG"; value[0] = MaDG;
			return thaotac.SQL_thuchien("SP_DocGia_Delete", name, value, 1);
		}

	}
}
