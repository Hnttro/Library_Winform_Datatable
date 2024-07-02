using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_PHIEUMUON
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable PM_select_all()
		{
			return thaotac.SQL_LayDL("SP_PhieuMuon_Select_All");
		}

		public DataTable PM_select_DK(string MaPhieuMuon)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maPhieuMuon"; value[0] = MaPhieuMuon;
			return thaotac.SQL_LayDL_CoDK("SP_PhieuMuon_Select", name, value, 1);
		}

		public int PM_insert(string MaPhieuMuon, string MaNV, string MaDG, DateTime ngayMuon, DateTime ngayTra, string status)
		{
			name = new string[6];
			value = new object[6];
			name[0] = "@maPhieuMuon"; value[0] = MaPhieuMuon;
			name[1] = "@maNV"; value[1] = MaNV;
			name[2] = "@maDG"; value[2] = MaDG;
			name[3] = "@ngayMuon"; value[3] = ngayMuon;
			name[4] = "@ngayTra"; value[4] = ngayTra;
			name[5] = "@status"; value[5] = status;
			return thaotac.SQL_thuchien("SP_PhieuMuon_Insert", name, value, 6);
		}

		public int PM_update(string MaPhieuMuon, string MaNV, string MaDG, DateTime ngayMuon, DateTime ngayTra, string status)
		{
			name = new string[6];
			value = new object[6];
			name[0] = "@maPhieuMuon"; value[0] = MaPhieuMuon;
			name[1] = "@maNV"; value[1] = MaNV;
			name[2] = "@maDG"; value[2] = MaDG;
			name[3] = "@ngayMuon"; value[3] = ngayMuon;
			name[4] = "@ngayTra"; value[4] = ngayTra;
			name[5] = "@status"; value[5] = status;
			return thaotac.SQL_thuchien("SP_PhieuMuon_Update", name, value, 6);
		}

		public int PM_delete(string MaPhieuMuon)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maPhieuMuon"; value[0] = MaPhieuMuon;
			return thaotac.SQL_thuchien("SP_PhieuMuon_Delete", name, value, 1);
		}
	}
}
