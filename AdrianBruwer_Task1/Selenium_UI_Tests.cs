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
        private static string logonPage = System.Configuration.ConfigurationManager.AppSettings["LogonPage"];
        private static string backLinkText = System.Configuration.ConfigurationManager.AppSettings["backLinkText"];
        private static string profilePageText = System.Configuration.ConfigurationManager.AppSettings["ProfilePageText"];
        private static int oneSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["OneSec"]);
        private static int twoSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["TwoSec"]);
        private static int threeSec = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["ThreeSec"]);

        // Test Managment

        /// <summary>
        /// Set the Browser for each test
        /// </summary>
        [TestInitialize]
        public void StartUp()
        {
            // Choise of Browsers IE / Chrome and Firefox
            Browser.ChangeBrowser("Chrome");
        }

        /// <summary>
        /// closes the Driver after each test
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
            // Navigate to the home page
            Goto(startUrl);
            Browser.ToSleep(twoSec);

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
        ///  Logon to the website using a chrome browser
        /// </remarks>
        [TestMethod]
        public void Logon_To_Website_with_Chrome_3()
        {
            // Navigate to the logon page
            Goto(logonPage);
            Browser.ToSleep(twoSec);

            // Assert you on the logon page
            Assert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText));  // "Test has not reached the login Box");

            Pages.LoginPage.Login_wordpress("seluser", "P@$$W0rd");

           // Assert you on the logon page
           Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }

        /// <summary>
        /// 04
        /// </summary>
        /// <remarks>
        ///  Logon to the website using FireFox
        /// </remarks>
        [TestMethod]
        public void Logon_To_Website_With_FireFox_4()
        {
            // Close automatic driver
            Browser.Close();

            // Change driver to FireFox
            Browser.ChangeBrowser("FireFox");

            // Navigate to the logon page
            Goto(logonPage);
            Browser.ToSleep(twoSec);

            // Assert you on the logon page
            Assert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText));  // "Test has not reached the login Box");

            Pages.LoginPage.Login_wordpress("seluser", "P@$$W0rd");

            // Assert you on the logon page
            Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }

        /// <summary>
        /// 04
        /// </summary>
        /// <remarks>
        ///  Logon to the website using IE
        /// </remarks>
        [TestMethod]
        public void Logon_To_Website_With_IE_5()
        {
            // Close automatic driver
            Browser.Close();

            // Change driver to FireFox
            Browser.ChangeBrowser("IE");

            // Navigate to the logon page
            Goto(logonPage);
            Browser.ToSleep(twoSec);

            // Assert you on the logon page
            //ssert.IsTrue(Pages.LoginPage.Has_login_Box(backLinkText));  // "Test has not reached the login Box");
            Browser.ToSleep(1000);

            Pages.LoginPage.Login_wordpress("seluser", "P@$$W0rd");
            Browser.ToSleep(twoSec);

            // Assert you on the logon page
            Assert.IsTrue(Pages.LoginPage.UserHasLoggedOn(profilePageText), "You not on the logged in profile page");
        }
    }
}
