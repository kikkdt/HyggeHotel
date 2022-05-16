using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TangLauBLL
    {
        public static List<tb_TangLau> GetFloors()
        {
            return new TangLauDAL().GetFloors();
        }
    }
}
