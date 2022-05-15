using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        public static tb_NhanVien GetEmployee(string tenDangNhap)
        {
            return new NhanVienDAL().GetEmployee(tenDangNhap);
        }
    }
}
