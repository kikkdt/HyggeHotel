using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public static bool checkUsernameExist(string username)
        {
            return new TaiKhoanDAL().checkUsernameExist(username);
        }

        public static bool checkPassword(string username, string password)
        {
            return new TaiKhoanDAL().checkPassword(username, password);
        }

        public static bool changePassword(string username, string passwordOld, string passwordNew)
        {
            return new TaiKhoanDAL().changePassword(username, passwordOld, passwordNew);
        }
    }
}