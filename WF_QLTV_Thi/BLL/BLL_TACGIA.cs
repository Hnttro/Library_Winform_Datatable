using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	public class BLL_TACGIA
	{
		DAL_TACGIA TG = new DAL_TACGIA();

		public DataTable TG_select()
		{
			return TG.TG_select();
		}
		public DataTable TG_select_DK(string MaTG)
		{
			return TG.TG_select_DK(MaTG);
		}
		public int TG_insert(string MaTG, string TenTG, DateTime ngaysinh, string quocgia)
		{
			return TG.TG_insert(MaTG, TenTG, ngaysinh,quocgia);
		}
		public int TG_update(string MaTG, string TenTG, DateTime ngaysinh, string quocgia)
		{
			return TG.TG_update(MaTG, TenTG, ngaysinh, quocgia);
		}
		public int TG_delete(string MaTG)
		{
			return TG.TG_delete(MaTG);
		}
	}
}
