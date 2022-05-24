using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeUnitTest
{
    [TestClass]
    public class UnitTest_DangNhap
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
        public void TestMethod_TC01_UsernameNotNull()
        {
            string username = "admin";
            Assert.IsNotNull(username, "Tên đăng nhập trống");
        }
        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC01_UsernameNull()
        {
            string username = null;
            Assert.IsNull(username, "Tên đăng nhập không trống");
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC02_PasswordNotNull()
        {
            string password = "123";
            Assert.IsNotNull(password, "Mật khẩu trống");
        }
        [TestMethod]
        [TestCategory("Failed")]
        public void TestMethod_TC02_PasswordNull()
        {
            string password = null;
            Assert.IsNull(password, "Mật khẩu không trống");
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC03_CheckUsername()
        {
            string username = "admin";
            Assert.IsTrue(TaiKhoanBLL.checkUsernameExist(username), "Tài khoản không tồn tại");
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC04_checkPassword()
        {
            string username = "admin";
            string password = "123";
            Assert.IsTrue(TaiKhoanBLL.checkPassword(username, password), "Mật khẩu không đúng");
        }

        [TestMethod()]
        [TestCategory("Passed")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Data_TestCases_DangNhap.xml", "Addition", DataAccessMethod.Sequential)]
        public void TestMethod_TC05_XML()
        {
            string username = this.TestContext.DataRow["Username"].ToString();
            string password = this.TestContext.DataRow["Password"].ToString();

            Assert.IsTrue(TaiKhoanBLL.checkPassword(username, password), "Lỗi xảy ra");
        }
    }
}
