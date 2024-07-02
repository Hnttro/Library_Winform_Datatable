using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DangNhap
    {
        private DAL.DAL_DangNhap dalDangNhap = new DAL.DAL_DangNhap();

        public bool Login(string taikhoan, string matkhau, out bool isEmployee)
        {
            return dalDangNhap.Login(taikhoan, matkhau, out isEmployee);
        }
    }
}
