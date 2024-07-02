using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_CHITIETPHIEUMUON
	{
		DAL_CHITIETPHIEUMUON CT_PM = new DAL_CHITIETPHIEUMUON();

		public DataTable CT_PM_select_all()
		{
			return CT_PM.CT_PM_select_all();
		}

		public DataTable CT_PM_select_DK(string MaSach, string MaPhieuMuon)
		{
			return CT_PM.CT_PM_select_DK(MaSach, MaPhieuMuon);
		}
        public DataTable CT_PM_select_W( string MaPhieuMuon)
        {
            return CT_PM.CT_PM_select_W( MaPhieuMuon);
        }
        public int CT_PM_insert(string MaSach, string MaPhieuMuon, string TenSach, int sl, string TinhTrang)
		{
			return CT_PM.CT_PM_insert(MaSach, MaPhieuMuon, TenSach, sl, TinhTrang);
		}

		public int CT_PM_update(string MaSach, string MaPhieuMuon, string TenSach, int sl, string TinhTrang)
		{
			return CT_PM.CT_PM_update(MaSach, MaPhieuMuon, TenSach, sl, TinhTrang);
		}

		public int CT_PM_delete(string MaSach, string MaPhieuMuon)
		{
			return CT_PM.CT_PM_delete(MaSach, MaPhieuMuon);
		}
	}
}
