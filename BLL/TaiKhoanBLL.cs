﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public static bool checkUsernameExist(String username)
        {
            return new TaiKhoanDAL().checkUsernameExist(username);
        }
        public static bool checkPassword(String username, String password)
        {
            return new TaiKhoanDAL().checkPassword(username, password);
        }
        public static bool changePassword(String username, String passwordOld, String passwordNew)
        {
            return new TaiKhoanDAL().changePassword(username, passwordOld, passwordNew);
        }
    }
}
