namespace AdrianBruwer_Task1.Backend
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Remote;

    public static class BrowserDrivers
    {
        // parameters
        private static IWebDriver intiatedDriver;
        private static string dlocation = System.Configuration.ConfigurationManager.AppSettings["DriverLocation"];
        private static string driverlocation = System.IO.Path.Combine(Environment.CurrentDirectory, dlocation);

        /// <summary>
        /// Select the appropriate webdriver based on browser
        /// </summary>
        /// <returns>
        /// Returns selected web driver
        /// </returns>
        public static IWebDriver InitiateDriver(string browser)
        {
            switch (browser)
            {
                case "IE":
                    intiatedDriver = new InternetExplorerDriver(driverlocation);
                     DesiredCapabilities cap = new DesiredCapabilities();
                     cap.SetCapability("ie.ensureCleanSession", true);
                     break;

                case "Firefox":
                    intiatedDriver = new FirefoxDriver(driverlocation);
                    break;

                case "Chrome":
                    intiatedDriver = new ChromeDriver(driverlocation);
                    break;
                default:
                    intiatedDriver = new ChromeDriver(driverlocation);
                    break;
            }

            return intiatedDriver;
        }
    }
}
