using DTO;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public bool checkUsernameExist(string username)
        {
            var isExist = false;
            using (var db = new HyggeDbDataContext())
            {
                var acc = db.tb_TaiKhoans.Where(t => t.TenDangNhap.Equals(username)).FirstOrDefault();
                if (acc != null) isExist = true;
            }

            return isExist;
        }

        public bool checkPassword(string username, string password)
        {
            var isExist = false;
            using (var db = new HyggeDbDataContext())
            {
                var acc = db.tb_TaiKhoans.Where(t => t.TenDangNhap.Equals(username) && t.MatKhau.Equals(password))
                    .FirstOrDefault();
                if (acc != null) isExist = true;
            }

            return isExist;
        }

        public bool changePassword(string username, string passwordOld, string passwordNew)
        {
            using (var db = new HyggeDbDataContext())
            {
                var taiKhoan = db.tb_TaiKhoans
                    .Where(t => t.TenDangNhap.Equals(username) && t.MatKhau.Equals(passwordOld)).FirstOrDefault();
                if (taiKhoan != null)
                {
                    taiKhoan.MatKhau = passwordNew;
                    db.SubmitChanges();
                    return true;
                }
            }

            return false;
        }
    }
}