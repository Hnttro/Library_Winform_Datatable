using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_CHUCVU
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable CV_select_all()
		{
			return thaotac.SQL_LayDL("SP_ChucVu_Select_All");
		}

		public DataTable CV_select_DK(string MaCV)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maCV"; value[0] = MaCV;
			return thaotac.SQL_LayDL_CoDK("SP_ChucVu_Select", name, value, 1);
		}

		public int CV_insert(string MaCV, string TenCV, string GhiChu)
		{
			name = new string[3];
			value = new object[3];
			name[0] = "@maCV"; value[0] = MaCV;
			name[1] = "@tenCV"; value[1] = TenCV;
			name[2] = "@ghiChu"; value[2] = GhiChu;
			return thaotac.SQL_thuchien("SP_ChucVu_Insert", name, value, 3);
		}

		public int CV_update(string MaCV, string TenCV, string GhiChu)
		{
			name = new string[3];
			value = new object[3];
			name[0] = "@maCV"; value[0] = MaCV;
			name[1] = "@tenCV"; value[1] = TenCV;
			name[2] = "@ghiChu"; value[2] = GhiChu;
			return thaotac.SQL_thuchien("SP_ChucVu_Update", name, value, 3);
		}

		public int CV_delete(string MaCV)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maCV"; value[0] = MaCV;
			return thaotac.SQL_thuchien("SP_ChucVu_Delete", name, value, 1);
		}
	}
}
