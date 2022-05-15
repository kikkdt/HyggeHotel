using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TangLauDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();
        public List<tb_TangLau> GetFloors()
        {
            return dataContext.tb_TangLaus.Select(tang => tang).ToList();
        }
    }
}
