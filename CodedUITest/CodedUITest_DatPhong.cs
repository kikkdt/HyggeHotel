using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CodedUITest
{
    /// <summary>
    /// Summary description for CodedUITest_DatPhong
    /// </summary>
    [CodedUITest]
    public class CodedUITest_DatPhong
    {
        // Get file path of GUI.exe
        private static readonly string projFolder = Directory
            .GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).FullName;

        public string filePath = Path.Combine(projFolder, @"GUI\bin\Debug\GUI.exe");

        public CodedUITest_DatPhong()
        {
        }

        [TestMethod]
        public void TestCase_KhachHangTrong()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_DatPhong_KhachHangTrong();
            UIMap.AssertMethod_DatPhong_KhachHangTrong();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_CheckInKhongHopLe()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_CheckInKhongHopLe();
            UIMap.AssertMethod_CheckInKhongHopLe();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_CheckOutKhongHopLe()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_CheckOutKhongHopLe();
            UIMap.AssertMethod_CheckOutKhongHopLe();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_TamTinh()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_TamTinh();
            UIMap.AssertMethod_TamTinh();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_TamTinhCoDungDichVu()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_TamTinhCoDungDichVu();
            UIMap.AssertMethod_TamTinhCoDungDichVu();
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_TraTruocKhongHopLe()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_TraTruocKhongHopLe();
            UIMap.AssertMethod_TraTruocKhongHopLe();
            Playback.Wait(2000);
        }

        [TestMethod]
        [TestCategory("Passed")]
        public void TestCase_TraTruocKhongHopLe_2()
        {
            ApplicationUnderTest.Launch(filePath);
            UIMap.RecordedMethod_TraTruocKhongHopLeParams.UINumerTraTruocEditValueAsString = "600000";
            UIMap.RecordedMethod_TraTruocKhongHopLe();
            UIMap.AssertMethod_TraTruocKhongHopLe();
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

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}