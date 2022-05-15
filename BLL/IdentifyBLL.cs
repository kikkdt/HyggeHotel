using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class IdentifyBLL
    {
        public static int GetCounter(string parameter)
        {
            return new IdentifyDAL().GetCounter(parameter);
        }
    }
}
