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


namespace CodedUITestNumericSequence
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ManualCodedUITest
    {
        public ManualCodedUITest()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {

            BrowserWindow browser = BrowserWindow.Launch("http://localhost:22429/");
            UITestControl uiInput = new UITestControl(browser);
            uiInput.TechnologyName = "Web";
            uiInput.SearchProperties.Add("ControlType", "Edit");
            uiInput.SearchProperties.Add("Id", "InputNumber");

            Keyboard.SendKeys(uiInput, "5");

            UITestControl showButton = new UITestControl(browser);
            showButton.TechnologyName = "Web";
            showButton.SearchProperties.Add("ControlType", "Button");
            showButton.SearchProperties.Add("Id", "show-button");

            Mouse.Click(showButton);

            
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
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
    }
}
