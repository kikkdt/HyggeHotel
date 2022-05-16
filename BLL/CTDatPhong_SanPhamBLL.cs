using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CTDatPhong_SanPhamBLL
    {
        public static void Update(List<tb_CTDatPhong> ctDatPhongs)
        {
            new CTDatPhong_SanPhamDAL().Update(ctDatPhongs);
        }
    }
}
