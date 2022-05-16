using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class IdentifyDAL
    {
        HyggeDbDataContext dataContext = new HyggeDbDataContext();

        public int GetCounter(string parameter)
        {
            tb_Identify identify = dataContext.tb_Identifies.Select(i => i).First();
            switch (parameter)
            {
                case "Phong":
                    return (int)identify.Phong;
                case "NhanVien":
                    return (int)identify.NhanVien;
                case "SanPham":
                    return (int)identify.SanPham;
                case "PhieuDatPhong":
                    return (int)identify.PhieuDatPhong;
                case "HoaDon":
                    return (int)identify.HoaDon;
                default: throw new Exception("Invalid parameter.");
            }
        }
    }
}
