using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_SACH
	{
		DAL_SACH Sach = new DAL_SACH();

		public DataTable Sach_select_all()
		{
			return Sach.Sach_select_all();
		}

		public DataTable Sach_select_DK(string MaSach)
		{
			return Sach.Sach_select_DK(MaSach);
		}

		public int Sach_insert(string MaSach, string TenSach, string maTheLoai, string maTacGia, string NhaXB, string NamXB, int SL, int DonGia, string TinhTrang)
		{
			return Sach.Sach_insert(MaSach, TenSach, maTheLoai, maTacGia, NhaXB, NamXB, SL, DonGia, TinhTrang);
		}

		public int Sach_update(string MaSach, string TenSach, string maTheLoai, string maTacGia, string NhaXB, string NamXB, int SL, int DonGia, string TinhTrang)
		{
			return Sach.Sach_update(MaSach, TenSach, maTheLoai, maTacGia, NhaXB, NamXB, SL, DonGia, TinhTrang);
		}

		public int Sach_delete(string MaSach)
		{
			return Sach.Sach_delete(MaSach);
		}
	}
}
