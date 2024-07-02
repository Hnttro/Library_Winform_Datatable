using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_SACH
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable Sach_select_all()
		{
			return thaotac.SQL_LayDL("SP_Sach_Select_All");
		}

		public DataTable Sach_select_DK(string MaSach)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maSach"; value[0] = MaSach;
			return thaotac.SQL_LayDL_CoDK("SP_Sach_Select", name, value, 1);
		}

		public int Sach_insert(string MaSach, string TenSach, string maTheLoai, string maTacGia, string NhaXB, string NamXB, int SL, int DonGia, string TinhTrang)
		{
			name = new string[9];
			value = new object[9];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@tenSach"; value[1] = TenSach;
			name[2] = "@maTheLoai"; value[2] = maTheLoai;
			name[3] = "@maTacGia"; value[3] = maTacGia;
			name[4] = "@nhaXB"; value[4] = NhaXB;
			name[5] = "@namXB"; value[5] = NamXB;
			name[6] = "@sl"; value[6] = SL;
			name[7] = "@donGia"; value[7] = DonGia;
			name[8] = "@tinhTrang"; value[8] = TinhTrang;
			return thaotac.SQL_thuchien("SP_Sach_Insert", name, value, 9);
		}

		public int Sach_update(string MaSach, string TenSach, string maTheLoai, string maTacGia, string NhaXB, string NamXB, int SL, int DonGia, string TinhTrang)
		{
			name = new string[9];
			value = new object[9];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@tenSach"; value[1] = TenSach;
			name[2] = "@maTheLoai"; value[2] = maTheLoai;
			name[3] = "@maTacGia"; value[3] = maTacGia;
			name[4] = "@nhaXB"; value[4] = NhaXB;
			name[5] = "@namXB"; value[5] = NamXB;
			name[6] = "@sl"; value[6] = SL;
			name[7] = "@donGia"; value[7] = DonGia;
			name[8] = "@tinhTrang"; value[8] = TinhTrang;
			return thaotac.SQL_thuchien("SP_Sach_Update", name, value, 9);
		}

		public int Sach_delete(string MaSach)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maSach"; value[0] = MaSach;
			return thaotac.SQL_thuchien("SP_Sach_Delete", name, value, 1);
		}
	}
}
