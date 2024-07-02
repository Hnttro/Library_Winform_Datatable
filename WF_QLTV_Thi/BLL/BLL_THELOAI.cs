using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_THELOAI
	{
		DAL_THELOAI TL = new DAL_THELOAI();

		public DataTable TL_select()
		{
			return TL.TL_select();
		}

		public DataTable TL_select_DK(string MaTL)
		{
			return TL.TL_select_DK(MaTL);
		}

		public int TL_insert(string MaTL, string TenTL)
		{
			return TL.TL_insert(MaTL, TenTL);
		}

		public int TL_update(string MaTL, string TenTL)
		{
			return TL.TL_update(MaTL, TenTL);
		}

		public int TL_delete(string MaTL)
		{
			return TL.TL_delete(MaTL);
		}

	}
}
