namespace AdrianBruwer_Task1.Backend
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class BaseSettings
    {
        /// <summary>
        /// Go to selected webpage
        /// </summary>
        public void Goto(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                Assert.Fail("The url can not be null", nameof(url));
            }

            Browser.Goto(url);
        }
    }
}
