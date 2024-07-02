using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_PHIEUMUON
	{
		DAL_PHIEUMUON PM = new DAL_PHIEUMUON();

		public DataTable PM_select_all()
		{
			return PM.PM_select_all();
		}

		public DataTable PM_select_DK(string MaPhieuMuon)
		{
			return PM.PM_select_DK(MaPhieuMuon);
		}

		public int PM_insert(string MaPhieuMuon, string MaNV, string MaDG, DateTime ngayMuon, DateTime ngayTra, string status)
		{
			return PM.PM_insert(MaPhieuMuon, MaNV, MaDG, ngayMuon, ngayTra, status);
		}

		public int PM_update(string MaPhieuMuon, string MaNV, string MaDG, DateTime ngayMuon, DateTime ngayTra, string status)
		{
			return PM.PM_update(MaPhieuMuon, MaNV, MaDG, ngayMuon, ngayTra, status);
		}

		public int PM_delete(string MaPhieuMuon)
		{
			return PM.PM_delete(MaPhieuMuon);
		}
	}
}
