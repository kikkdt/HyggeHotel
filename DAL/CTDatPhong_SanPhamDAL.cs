﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CTDatPhong_SanPhamDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();
        public void Update(List<tb_CTDatPhong> ctDatPhongs)
        {
            foreach (var ct in ctDatPhongs)
            {
                var ctDatPhong = dataContext.tb_CTDatPhongs.Where(x => x.MaCTDatPhong.Equals(ct.MaCTDatPhong)).FirstOrDefault();
                dataContext.tb_CTDatPhong_SanPhams.DeleteAllOnSubmit(ctDatPhong.tb_CTDatPhong_SanPhams);

                foreach(var sanpham in ct.tb_CTDatPhong_SanPhams)
                {
                    tb_CTDatPhong_SanPham tmp = new tb_CTDatPhong_SanPham();
                    tmp.MaSanPham = sanpham.MaSanPham;
                    tmp.MaCTDatPhong = sanpham.MaCTDatPhong;
                    tmp.SoLuong = sanpham.SoLuong;
                    tmp.ThanhTien = sanpham.ThanhTien;
                    ctDatPhong.tb_CTDatPhong_SanPhams.Add(tmp);
                }
            }
            dataContext.SubmitChanges();
        }

        public tb_CTDatPhong_SanPham GetCTDatPhong_SanPham(int maCTDatPhong, string maSanPham)
        {
            return dataContext.tb_CTDatPhong_SanPhams.FirstOrDefault(x => x.MaCTDatPhong.Equals(maCTDatPhong) && x.MaSanPham.Equals(maSanPham));
        }
    }
}
