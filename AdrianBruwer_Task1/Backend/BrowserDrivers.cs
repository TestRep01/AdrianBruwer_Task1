namespace AdrianBruwer_Task1.Backend
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;

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
                    InternetExplorerOptions options = new InternetExplorerOptions();
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    options.IgnoreZoomLevel = true;
                    options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                    options.EnablePersistentHover = true;
                    options.EnableNativeEvents = false;
                    options.EnsureCleanSession = true;
                    options.RequireWindowFocus = true;
                    break;

                case "Firefox":
                    intiatedDriver = new FirefoxDriver(driverlocation);
                    FirefoxOptions option = new FirefoxOptions();


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
