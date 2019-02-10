namespace AdrianBruwer_Task1
{
    using System;
    using AdrianBruwer_Task1.Backend;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        // WebElements on home page

        // Finds the text link for the schools link on the home page
        [FindsBy(How = How.LinkText, Using = "SCHOOLS")]
        private readonly IWebElement schoolLink;

        // CssSelector for pre-selected school on the schools page
        [FindsBy(How = How.CssSelector, Using = "div:nth-child(3) > div > div.team-media > a > i")]
        private readonly IWebElement schoolSelected;

       // Functions for the home page

        /// <summary>
        /// Confirm page title on home page
        /// </summary>
        /// <returns>
        /// Returns true if the page title is correct
        /// </returns>
        public bool IsAt(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                Assert.Fail("The title can not be null", nameof(title));
            }

            return Browser.Title == title;
        }

        /// <summary>
        /// Go to selected school from home page
        /// </summary>
        public void SelectedSchool()
        {
            this.schoolLink.Click();
            Browser.ToSleep(3000);
            this.schoolSelected.Click();
        }
    }
}