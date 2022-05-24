using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeUnitTest
{
    [TestClass]
    public class UnitTest_ThanhToan
    {
        [TestInitialize]
        public void testInitialize() { }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC01()
        {
            string maPhieuDat = "PD00033";
            decimal giamTru = 200000;

            decimal intoMoneyActual = 100000;
            decimal intoMoneyExpected = HoaDonBLL.IntoMoney(giamTru, maPhieuDat);

            Assert.AreEqual(intoMoneyExpected, intoMoneyActual, "Lỗi xảy ra");
        }
        [TestMethod]
        [TestCategory("Failed")]
        public void TestMethod_TC02()
        {
            string maPhieuDat = "PD00033";
            decimal giamTru = 100000;

            decimal intoMoneyActual = 100000;
            decimal intoMoneyExpected = HoaDonBLL.IntoMoney(giamTru, maPhieuDat);

            Assert.AreEqual(intoMoneyExpected, intoMoneyActual, "Lỗi xảy ra");
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC03_Random()
        {
            string maPhieuDat = "PD00033";
            for (int i = 0; i <= 10; i++)
            {
                Random r = new Random();

                decimal giamTru = r.Next(-10000, 100000);

                decimal intoMoneyActual = HoaDonBLL.IntoMoney(giamTru, maPhieuDat);
                decimal intoMoneyExpected = HoaDonBLL.IntoMoney(giamTru, maPhieuDat);

                Assert.AreEqual(intoMoneyExpected, intoMoneyActual, "Lỗi xảy ra");
            }
        }

        [TestMethod()]
        [TestCategory("Passed")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Data_TestCases_ThanhToan.xml", "Addition", DataAccessMethod.Sequential)]
        public void TestMethod_TC04_XML()
        {
            string maPhieuDat = this.TestContext.DataRow["MaPhieuDat"].ToString();

            decimal giamTru = decimal.Parse(this.TestContext.DataRow["GiamTru"].ToString());

            decimal intoMoneyExpected = decimal.Parse(this.TestContext.DataRow["ThanhTien"].ToString());

            decimal intoMoneyActual = HoaDonBLL.IntoMoney(giamTru, maPhieuDat);

            Assert.AreEqual(intoMoneyExpected, intoMoneyActual, "Lỗi xảy ra");
        }
    }
}
