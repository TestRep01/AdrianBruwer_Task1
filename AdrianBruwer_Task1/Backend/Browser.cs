namespace AdrianBruwer_Task1.Backend
{
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;

    public static class Browser
    {
        // Initaitated driver
        private static string dlocation = System.Configuration.ConfigurationManager.AppSettings["DriverLocation"];
        internal static IWebDriver driver = null;

        /// <summary>
        /// Gets driver for pagefactory
        /// </summary>
        public static ISearchContext Driver
        {
            get { return driver; }
        }

        /// <summary>
        /// Gets returns page title
        /// </summary>
        public static string Title
        {
            get { return driver.Title; }
        }

        /// <summary>
        /// Sends the driver to selected url.
        /// </summary>
        public static void Goto(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                Assert.Fail("The url can not be null", nameof(url));
            }

            driver.Url = url;
        }

        /// <summary>
        /// Sleep is nessaray for the page to load
        /// </summary>
        public static void ToSleep(int timeToSleep) => Thread.Sleep(timeToSleep);

        /// <summary>
        /// Changes the drive to the selected browser IE / Chrome or FireFox
        /// If the correct browser is not choisen it will default the chrome.
        /// </summary>
        /// <returns>
        ///  The driver for the choisen browser
        /// </returns>
        public static IWebDriver ChangeBrowser(string choisenBrowser)
        {
            // Check for  null or white space
            if (string.IsNullOrWhiteSpace(choisenBrowser))
            {
                Assert.Fail("The browser choice cant be null or whitespace", nameof(choisenBrowser));
            }

            driver = BrowserDrivers.InitiateDriver(choisenBrowser);
            driver.Manage().Window.Maximize();
            return driver;
        }

        /// <summary>
        /// close the instatiated driver
        /// </summary>
        public static void Close()
        {
            // Closes all browser windows and safely ends the session
            driver.Quit();
        }
    }
}
