namespace AdrianBruwer_Task1.Backend
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginPage
    {
        // WebElements on home page
        [FindsBy(How = How.CssSelector, Using = "#wp-submit")]
        private readonly IWebElement submitButton;

        [FindsBy(How = How.Id, Using = "user_pass")]
        private readonly IWebElement password;

        [FindsBy(How = How.Id, Using = "user_login")]
        private readonly IWebElement username;

        [FindsBy(How = How.XPath, Using = "//*[@id='backtoblog']/a")]
        private readonly IWebElement backLinkText;

        [FindsBy(How = How.ClassName, Using = "wp-heading-inline")]
        private readonly IWebElement confirmUserLoggedIn;
 
        /// <summary>
        /// Returns true if you on the logon page
        /// </summary>
        public bool Has_login_Box(string linkText)
        {
            if (string.IsNullOrEmpty(linkText))
            {
                Assert.Fail("Profile Text can not be null or blank", nameof(linkText));
            }

            return this.backLinkText.Text == linkText;
        }

        /// <summary>
        /// Returns true if you logged into the profile page
        /// </summary>
        public bool UserHasLoggedOn(string profilePageText)
        {
            if (string.IsNullOrEmpty(profilePageText))
            {
                Assert.Fail("Profile Text can not be null or blank", nameof(profilePageText));
            }

            return this.confirmUserLoggedIn.Text == profilePageText;
        }

        /// <summary>
        /// Logs a test user into word press
        /// </summary>
        public void Login_wordpress(string uid, string pass)
        {
            if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(pass))
            {
                Assert.Fail("Parameters cant be null or empty", nameof(uid), nameof(pass));
            }

            this.username.SendKeys(uid);
            this.password.SendKeys(pass);
            this.submitButton.Click();
        }
    }
}
