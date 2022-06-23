using CodedUITest;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CodedUITestDangNhap
{
    /// <summary>
    ///     Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_DangNhap
    {
        // Get file path of GUI.exe
        private static readonly string projFolder = Directory
            .GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;

        public string filePath = Path.Combine(projFolder, @"GUI\bin\Debug\GUI.exe");

        private UIMap map;

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        public UIMap UIMap
        {
            get
            {
                if (map == null) map = new UIMap();

                return map;
            }
        }

        [TestMethod]
        public void TestDangNhap_TC01_1()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter UserName
            var userNameWindow = new WinWindow(loginWindow);
            userNameWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtUsername";
            var userNameWinEdit = new WinEdit(userNameWindow);
            Keyboard.SendKeys(userNameWinEdit, "admin");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            TestContext.WriteLine("Đăng nhập không thành công");
            TestContext.WriteLine("Chưa nhập mật khẩu");

            Playback.Wait(2000);
        }

        [TestMethod]
        public void TestDangNhap_TC01_2()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter PassWord
            var passWordWindow = new WinWindow(loginWindow);
            passWordWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtPassword";
            var passWordWinEdit = new WinEdit(passWordWindow);
            Keyboard.SendKeys(passWordWinEdit, "123");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            TestContext.WriteLine("Đăng nhập không thành công");
            TestContext.WriteLine("Chưa nhập tên đăng nhập");

            Playback.Wait(2000);
        }

        [TestMethod]
        public void TestDangNhap_TC02()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter UserName
            var userNameWindow = new WinWindow(loginWindow);
            userNameWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtUsername";
            var userNameWinEdit = new WinEdit(userNameWindow);
            Keyboard.SendKeys(userNameWinEdit, "admin");

            //Enter PassWord
            var passWordWindow = new WinWindow(loginWindow);
            passWordWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtPassword";
            var passWordWinEdit = new WinEdit(passWordWindow);
            Keyboard.SendKeys(passWordWinEdit, "123");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            // Kiểm tra đã mở ra trang chủ hay chưa
            var HomePage = new WinWindow();
            HomePage.SearchProperties[UITestControl.PropertyNames.Name] = "Quản lý khách sạn";

            var HomePageClient = new WinClient(HomePage);
            HomePageClient.SearchProperties[UITestControl.PropertyNames.Name] = "Quản lý khách sạn";

            if (HomePageClient.Exists)
                TestContext.WriteLine("Đăng nhập thành công");
            else
                TestContext.WriteLine("Đăng nhập không thành công");

            Playback.Wait(2000);
        }

        [TestMethod]
        public void TestDangNhap_TC03()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter UserName
            var userNameWindow = new WinWindow(loginWindow);
            userNameWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtUsername";
            var userNameWinEdit = new WinEdit(userNameWindow);
            Keyboard.SendKeys(userNameWinEdit, "admin");

            //Enter PassWord
            var passWordWindow = new WinWindow(loginWindow);
            passWordWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtPassword";
            var passWordWinEdit = new WinEdit(passWordWindow);
            Keyboard.SendKeys(passWordWinEdit, "abs");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            //click button ok
            var OKWindow = new WinWindow();
            OKWindow.SearchProperties[UITestControl.PropertyNames.Name] = "OK";

            var OKButton = new WinControl(OKWindow);
            OKButton.SearchProperties[UITestControl.PropertyNames.ControlType] = "Button";

            Mouse.Click(OKButton);

            TestContext.WriteLine("Đăng nhập không thành công");
            TestContext.WriteLine("Mật khẩu không đúng");

            Playback.Wait(2000);
        }

        [TestMethod]
        public void TestDangNhap_TC04()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter UserName
            var userNameWindow = new WinWindow(loginWindow);
            userNameWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtUsername";

            var userNameWinEdit = new WinEdit(userNameWindow);
            Keyboard.SendKeys(userNameWinEdit, "asd");

            //Enter PassWord
            var passWordWindow = new WinWindow(loginWindow);
            passWordWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtPassword";

            var passWordWinEdit = new WinEdit(passWordWindow);
            Keyboard.SendKeys(passWordWinEdit, "123");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            //click button ok
            var OKWindow = new WinWindow();
            OKWindow.SearchProperties[UITestControl.PropertyNames.Name] = "OK";

            var OKButton = new WinControl(OKWindow);
            OKButton.SearchProperties[UITestControl.PropertyNames.ControlType] = "Button";

            Mouse.Click(OKButton);

            TestContext.WriteLine("Đăng nhập không thành công");
            TestContext.WriteLine("Tài khoản không tồn tại");

            Playback.Wait(2000);
        }

        [TestMethod]
        public void TestDangNhap_TC05()
        {
            //this.UIMap.RecordedDangNhap();
            ApplicationUnderTest.Launch(filePath);

            var loginWindow = new WinWindow();
            loginWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            //Enter UserName
            var userNameWindow = new WinWindow(loginWindow);
            userNameWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtUsername";
            var userNameWinEdit = new WinEdit(userNameWindow);
            Keyboard.SendKeys(userNameWinEdit, "asd");

            //Enter PassWord
            var passWordWindow = new WinWindow(loginWindow);
            passWordWindow.SearchProperties[WinControl.PropertyNames.ControlName] = "txtPassword";
            var passWordWinEdit = new WinEdit(passWordWindow);
            Keyboard.SendKeys(passWordWinEdit, "asdsad");

            //click button Đăng Nhập
            var DangNhap = new WinWindow(loginWindow);
            DangNhap.SearchProperties[WinControl.PropertyNames.ControlName] = "btnDangNhap";

            var loginButton = new WinButton(DangNhap);
            loginButton.SearchProperties[UITestControl.PropertyNames.Name] = "Đăng nhập";

            Mouse.Click(loginButton);

            //click button ok
            var OKWindow = new WinWindow();
            OKWindow.SearchProperties[UITestControl.PropertyNames.Name] = "OK";

            var OKButton = new WinControl(OKWindow);
            OKButton.SearchProperties[UITestControl.PropertyNames.ControlType] = "Button";

            Mouse.Click(OKButton);

            TestContext.WriteLine("Đăng nhập không thành công");
            TestContext.WriteLine("Tài khoản không tồn tại");
            TestContext.WriteLine("Mật khẩu không đúng");

            Playback.Wait(2000);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion Additional test attributes
    }
}