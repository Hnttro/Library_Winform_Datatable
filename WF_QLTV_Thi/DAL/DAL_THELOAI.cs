using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_THELOAI
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable TL_select()
		{
			return thaotac.SQL_LayDL("SP_TheLoai_Select_All");
		}

		public DataTable TL_select_DK(string MaTL)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maTheLoai"; value[0] = MaTL;
			return thaotac.SQL_LayDL_CoDK("SP_TheLoai_Select", name, value, 1);
		}

		public int TL_insert(string MaTL, string TenTL)
		{
			name = new string[2];
			value = new object[2];
			name[0] = "@maTheLoai"; value[0] = MaTL;
			name[1] = "@tenTheLoai"; value[1] = TenTL;
			return thaotac.SQL_thuchien("SP_TheLoai_Insert", name, value, 2);
		}

		public int TL_update(string MaTL, string TenTL)
		{
			name = new string[2];
			value = new object[2];
			name[0] = "@maTheLoai"; value[0] = MaTL;
			name[1] = "@tenTheLoai"; value[1] = TenTL;
			return thaotac.SQL_thuchien("SP_TheLoai_Update", name, value, 2);
		}

		public int TL_delete(string MaTL)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maTheLoai"; value[0] = MaTL;
			return thaotac.SQL_thuchien("SP_TheLoai_Delete", name, value, 1);
		}
	}
}
