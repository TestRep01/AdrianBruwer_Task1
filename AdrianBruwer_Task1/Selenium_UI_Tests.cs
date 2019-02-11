namespace AdrianBruwer_Task1
{
    using System;
    using AdrianBruwer_Task1.Backend;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Selenium_UI_Tests : BaseSettings
    {
        // Private Fields for tests
        private static string startUrl = System.Configuration.ConfigurationManager.AppSettings["StartUpURL"];
        private static string frontPageTitle = System.Configuration.ConfigurationManager.AppSettings["frontPageTitle"];
        private static string capeTownSchool = System.Configuration.ConfigurationManager.AppSettings["CapeTownSchool"];
        private static string loginPage = System.Configuration.ConfigurationManager.AppSettings["LogonPage"];
        private static string backLinkText = System.Configuration.ConfigurationManager.AppSettings["backLinkText"];
        private static string profilePageText = System.Configuration.ConfigurationManager.AppSettings["ProfilePageText"];
        private static int oneSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["OneSec"]);
        private static int twoSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["TwoSec"]);
        private static int threeSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["ThreeSec"]);
        private static string testUser = System.Configuration.ConfigurationManager.AppSettings["TestUser"];
        private static string password = System.Configuration.ConfigurationManager.AppSettings["Password"];

        private enum BrowserList
        {
            Chrome,
            FireFox,
            IE
        }

        // Test Managment

        /// <summary>
        /// Can be used to automatically set the driver
        /// </summary>
        [TestInitialize]
        public void StartUp() { }

        /// <summary>
        /// Closes the Driver after each test
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
            Browser.ToSleep(twoSec);
            Browser.Close();
        }

        /// <summary>
        /// 01
        /// </summary>
        /// <remarks>
        /// Navigate to the home page and Assert you on the correct page
        /// </remarks>
        [TestMethod]
        public void Navagate_to_the_home_page_01()
        {
            // Set Browser to Chorme
            Browser.SetBrowser(BrowserList.Chrome.ToString());

            // Navigate to the home page
            Goto(startUrl);
            Browser.ToSleep(threeSec);

            // Assert you on the home page
            Assert.IsTrue(Pages.HomePage.IsAt(frontPageTitle), "The front page title is incorrect");
        }

        /// <summary>
        /// 02
        /// </summary>
        /// <remarks>
        ///  Navigate to a selected school from the home page
        /// </remarks>
        [TestMethod]
        public void Navagate_To_Selected_school_02()
        {
            // Set Browser to Chorme
            Browser.SetBrowser(BrowserList.Chrome.ToString());

            // Navigate to the home page
            Goto(startUrl);
            Browser.ToSleep(twoSec);

            // Select a school link
            Pages.HomePage.SelectedSchool();
            Browser.ToSleep(twoSec);

            // Assert the correct school in choosen
            Assert.IsTrue(Pages.SelectedSchoolsPage.IsCapeTownSchool(capeTownSchool), "The incorrect school was chosen");
        }

        /// <summary>
        /// 03
        /// </summary>
        /// <remarks>
        ///  Login to the website using a chrome browser
        /// </remarks>
        [TestMethod]
        public void Login_To_The_Website_with_Chrome_3()
        {
            // Set Browser to Chorme
            Browser.SetBrowser(BrowserList.Chrome.ToString());

            // Navigate to the login page
            Goto(loginPage);
            Browser.ToSleep(twoSec);

            // Assert you on the login page
            Assert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText), "Test has not reached the login Box");

            Pages.LoginPage.Login_wordpress(testUser, password);

           // Assert you on the login page
           Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }

        /// <summary>
        /// 04
        /// </summary>
        /// <remarks>
        ///  Login to the website using FireFox
        /// </remarks>
        [TestMethod]
        public void Login_To_The_Website_With_FireFox_4()
        {
            // Set Browser to FireFox
            Browser.SetBrowser(BrowserList.FireFox.ToString());

            // Navigate to the login page
            Goto(loginPage);
            Browser.ToSleep(twoSec);

            // Assert you on the login page
            Assert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText), "The Test has not reached the login Box");

            Pages.LoginPage.Login_wordpress(testUser, password);

            // Assert you on the login page
            Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }

        /// <summary>
        /// 04
        /// </summary>
        /// <remarks>
        ///  Login to the website using IE
        /// </remarks>
        [TestMethod]
        public void Login_To_The_Website_With_IE_5()
        {
            // Set Browser to IE
            Browser.SetBrowser(BrowserList.IE.ToString());

            // Navigate to the login page
            Goto(loginPage);
            Browser.ToSleep(twoSec);

            // Assert you on the login page
            Assert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText), "Test has not reached the login Box");

            Pages.LoginPage.Login_wordpress(testUser, password);
            Browser.ToSleep(twoSec);

            // Assert you on the login page
            Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }
    }
}
