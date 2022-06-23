using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeUnitTest
{
    [TestClass]
    public class UnitTest_DangNhap
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC01_UsernameNotNull()
        {
            var username = "admin";
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
            var password = "123";
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
            var username = "admin";
            Assert.IsTrue(TaiKhoanBLL.checkUsernameExist(username), "Tài khoản không tồn tại");
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestMethod_TC04_checkPassword()
        {
            var username = "admin";
            var password = "123";
            Assert.IsTrue(TaiKhoanBLL.checkPassword(username, password), "Mật khẩu không đúng");
        }

        [TestMethod]
        [TestCategory("Passed")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Data_TestCases_DangNhap.xml",
            "Addition", DataAccessMethod.Sequential)]
        public void TestMethod_TC05_XML()
        {
            var username = TestContext.DataRow["Username"].ToString();
            var password = TestContext.DataRow["Password"].ToString();

            var resultExpected = TestContext.DataRow["ResultExpected"].ToString() == "true";

            if (resultExpected)
                Assert.IsTrue(TaiKhoanBLL.checkPassword(username, password), "Lỗi xảy ra");
            else
                Assert.IsFalse(TaiKhoanBLL.checkPassword(username, password), "Lỗi xảy ra");
        }
    }
}