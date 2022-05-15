using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();

        public tb_NhanVien GetEmployee(string tenDangNhap)
        {
            return dataContext.tb_NhanViens.Where(nv => nv.TenDangNhap.Equals(tenDangNhap)).FirstOrDefault();
        }
    }
}
