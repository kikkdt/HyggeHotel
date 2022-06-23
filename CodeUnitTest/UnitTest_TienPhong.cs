using BLL;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeUnitTest
{
    [TestClass]
    public class UnitTest_TienPhong
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod]
        [TestCategory("Passed")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Data_TestCases_TienPhong.xml",
            "Record", DataAccessMethod.Sequential)]
        public void TestTienPhong_XML()
        {
            var loaiHinh = TestContext.DataRow["LoaiHinh"].ToString();

            var maCTDatPhong = Convert.ToInt32(TestContext.DataRow["MaCTDatPhong"]);
            var maPhong = TestContext.DataRow["MaPhong"].ToString();
            var checkIn = DateTime.Parse(TestContext.DataRow["CheckIn"].ToString());
            var checkOut = DateTime.Parse(TestContext.DataRow["CheckOut"].ToString());
            var ctDatPhong = new tb_CTDatPhong
            {
                MaCTDatPhong = maCTDatPhong,
                MaPhong = maPhong,
                CheckIn = checkIn,
                CheckOut = checkOut
            };

            var tongTienActual = DatPhongBLL.CalcSubtotal(loaiHinh, ctDatPhong);
            var tongTienExpected = Convert.ToDouble(TestContext.DataRow["TongTienExpected"]);
            Assert.AreEqual(tongTienExpected, tongTienActual, "Something went wrong.");
        }
    }
}