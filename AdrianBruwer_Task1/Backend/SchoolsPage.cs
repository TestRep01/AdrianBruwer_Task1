namespace AdrianBruwer_Task1.Backend
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class SchoolsPage
    {
        [FindsBy(How = How.CssSelector, Using = "div.wf-td.hgroup > h1")]
        private readonly IWebElement selectedSchool;

        public IWebElement SelectedSchool => selectedSchool;

        /// <summary>
        /// Go to selected webpage
        /// </summary>
        public bool IsCapeTownSchool(string school)
        {
            return this.selectedSchool.Text == school;
        }
    }
}
