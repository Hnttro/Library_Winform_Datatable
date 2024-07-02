using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_NHANVIEN
	{
		DAL_NHANVIEN NV = new DAL_NHANVIEN();

		public DataTable NV_select_all()
		{
			return NV.NV_select_all();
		}

		public DataTable NV_select_DK(string MaNV)
		{
			return NV.NV_select_DK(MaNV);
		}

		public int NV_insert(string MaNV, string TenNV, string MaCV, DateTime ngaySinh, string gioiTinh, string sdt,string tk,string mk)
		{
			return NV.NV_insert(MaNV, TenNV, MaCV, ngaySinh, gioiTinh, sdt,tk,mk);
		}

		public int NV_update(string MaNV, string TenNV, string MaCV, DateTime ngaySinh, string gioiTinh, string sdt, string tk, string mk)
		{
			return NV.NV_update(MaNV, TenNV, MaCV, ngaySinh, gioiTinh, sdt, tk, mk);
		}

		public int NV_delete(string MaNV)
		{
			return NV.NV_delete(MaNV);
		}
	}
}
