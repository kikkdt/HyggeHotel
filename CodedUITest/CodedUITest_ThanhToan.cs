using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest_ThanhToan
    {
        public CodedUITest_ThanhToan()
        {
        }

        [TestMethod]
        public void CodedUITestMethod_TC01()
        {
            string giamTru = "{Back}24000";
            string txtResult = "Thanh toán thành công.";

            this.UIMap.RecordedMethod_ThanhToanParams.UIGiảmtrừEditSendKeys = giamTru;
            this.UIMap.AssertMethod_ThanhToanExpectedValues.UIThanhtoánthànhcôngTextControlType = txtResult;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_ThanhToan();
            this.UIMap.AssertMethod_ThanhToan();
        }


        [TestMethod]
        public void CodedUITestMethod_TC02_Random()
        {
            Random r = new Random();
            int r_result = r.Next(0, 100000);

            string giamTru = "{Back}"+ r_result;
            string txtResult = "Thanh toán thành công.";

            this.UIMap.RecordedMethod_ThanhToanParams.UIGiảmtrừEditSendKeys = giamTru;
            this.UIMap.AssertMethod_ThanhToanExpectedValues.UIThanhtoánthànhcôngTextControlType = txtResult;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_ThanhToan();
            this.UIMap.AssertMethod_ThanhToan();
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData_ThanhToan_UI.xml", "Addition", DataAccessMethod.Sequential)]
        public void CodedUITestMethod_TC03_XML()
        {
            int r_result = int.Parse(this.TestContext.DataRow["GiamTru"].ToString()); ;

            string giamTru = "{Back}" + r_result;
            string txtResult = this.TestContext.DataRow["Result"].ToString();

            this.UIMap.RecordedMethod_ThanhToanParams.UIGiảmtrừEditSendKeys = giamTru;
            this.UIMap.AssertMethod_ThanhToanExpectedValues.UIThanhtoánthànhcôngTextControlType = txtResult;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_ThanhToan();
            this.UIMap.AssertMethod_ThanhToan();
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

        #endregion

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
