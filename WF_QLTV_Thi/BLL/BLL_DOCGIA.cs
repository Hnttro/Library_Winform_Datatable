using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_DOCGIA
	{
		DAL_DOCGIA DG = new DAL_DOCGIA();

		public DataTable DG_select_all()
		{
			return DG.DG_select_all();
		}

		public DataTable DG_select_DK(string MaDG)
		{
			return DG.DG_select_DK(MaDG);
		}

		public int DG_insert(string MaDG, string TenDG, DateTime ngaySinh, string gioiTinh, string loaiDG, string diaChi, string sdt)
		{
			return DG.DG_insert(MaDG, TenDG, ngaySinh, gioiTinh, loaiDG, diaChi, sdt);
		}

		public int DG_update(string MaDG, string TenDG, DateTime ngaySinh, string gioiTinh, string loaiDG, string diaChi, string sdt)
		{
			return DG.DG_update(MaDG, TenDG, ngaySinh, gioiTinh, loaiDG, diaChi, sdt);
		}

		public int DG_delete(string MaDG)
		{
			return DG.DG_delete(MaDG);
		}
	}
}
