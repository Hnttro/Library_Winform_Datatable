using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_CHITIETPHIEUMUON
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable CT_PM_select_all()
		{
			return thaotac.SQL_LayDL("SP_ChiTietPhieuMuon_Select_All");
		}

		public DataTable CT_PM_select_DK(string MaSach, string MaPhieuMuon)
		{
			name = new string[2];
			value = new object[2];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@maPhieuMuon"; value[1] = MaPhieuMuon;
			return thaotac.SQL_LayDL_CoDK("SP_ChiTietPhieuMuon_Select", name, value, 2);
		}
        public DataTable CT_PM_select_W( string MaPhieuMuon)
        {
            name = new string[1];
            value = new object[1];
      
            name[0] = "@maPhieuMuon"; value[0] = MaPhieuMuon;
            return thaotac.SQL_LayDL_CoDK("SP_ChiTietPhieuMuon_Select_W", name, value, 1);
        }

        public int CT_PM_insert(string MaSach, string MaPhieuMuon, string TenSach, int sl, string TinhTrang)
		{
			name = new string[5];
			value = new object[5];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@maPhieuMuon"; value[1] = MaPhieuMuon;
			name[2] = "@tenSach"; value[2] = TenSach;
			name[3] = "@sl"; value[3] = sl;
			name[4] = "@tinhTrang"; value[4] = TinhTrang;
			return thaotac.SQL_thuchien("SP_ChiTietPhieuMuon_Insert", name, value, 5);
		}

		public int CT_PM_update(string MaSach, string MaPhieuMuon, string TenSach, int sl, string TinhTrang)
		{
			name = new string[5];
			value = new object[5];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@maPhieuMuon"; value[1] = MaPhieuMuon;
			name[2] = "@tenSach"; value[2] = TenSach;
			name[3] = "@sl"; value[3] = sl;
			name[4] = "@tinhTrang"; value[4] = TinhTrang;
			return thaotac.SQL_thuchien("SP_ChiTietPhieuMuon_Update", name, value, 5);
		}

		public int CT_PM_delete(string MaSach, string MaPhieuMuon)
		{
			name = new string[2];
			value = new object[2];
			name[0] = "@maSach"; value[0] = MaSach;
			name[1] = "@maPhieuMuon"; value[1] = MaPhieuMuon;
			return thaotac.SQL_thuchien("SP_ChiTietPhieuMuon_Delete", name, value, 2);
		}
	}
}
