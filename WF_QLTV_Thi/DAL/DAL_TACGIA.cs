using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_TACGIA
	{
		DAL_ThaoTac thaotac = new DAL_ThaoTac();
		string[] name = { };
		object[] value = { };

		public DataTable TG_select()
		{
			return thaotac.SQL_LayDL("SP_TacGia_Select_All");
		}


		public DataTable TG_select_DK(string MaTG)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maTacGia"; value[0] = MaTG;
			return thaotac.SQL_LayDL_CoDK("SP_TacGia_Select", name, value, 1);
		}


		public int TG_insert(string MaTG, string TenTG,DateTime ngaysinh,string quocgia)
		{
			name = new string[4];
			value = new object[4];
			name[0] = "@maTacGia"; value[0] = MaTG;
			name[1] = "@tenTacGia"; value[1] = TenTG;
			name[2] = "@ngaySinh"; value[2] = ngaysinh;
			name[3] = "@quocGia"; value[3] = quocgia;
			return thaotac.SQL_thuchien("SP_TacGia_Insert", name, value, 4);
		}

		public int TG_update(string MaTG, string TenTG, DateTime ngaysinh, string quocgia)
		{
			name = new string[4];
			value = new object[4];
			name[0] = "@maTacGia"; value[0] = MaTG;
			name[1] = "@tenTacGia"; value[1] = TenTG;
			name[2] = "@ngaySinh"; value[2] = ngaysinh;
			name[3] = "@quocGia"; value[3] = quocgia;
			return thaotac.SQL_thuchien("SP_TacGia_Update", name, value, 4);
		}
		public int TG_delete(string MaTG)
		{
			name = new string[1];
			value = new object[1];
			name[0] = "@maTacGia"; value[0] = MaTG;
			return thaotac.SQL_thuchien("SP_TacGia_Delete", name, value, 1);
		}
	}
}
