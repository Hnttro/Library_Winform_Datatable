using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_CHUCVU
	{
		DAL_CHUCVU CV = new DAL_CHUCVU();

		public DataTable CV_select_all()
		{
			return CV.CV_select_all();
		}

		public DataTable CV_select_DK(string MaCV)
		{
			return CV.CV_select_DK(MaCV);
		}

		public int CV_insert(string MaCV, string TenCV, string GhiChu)
		{
			return CV.CV_insert(MaCV, TenCV, GhiChu);
		}

		public int CV_update(string MaCV, string TenCV, string GhiChu)
		{
			return CV.CV_update(MaCV, TenCV, GhiChu);
		}

		public int CV_delete(string MaCV)
		{
			return CV.CV_delete(MaCV);
		}
	}
}
