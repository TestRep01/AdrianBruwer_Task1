namespace AdrianBruwer_Task1.Backend
{
    using OpenQA.Selenium.Support.PageObjects;

    public class Pages
    {
     public static HomePage HomePage
        {
            get
            {
                HomePage homePage = new HomePage();
                #pragma warning disable CS0618
                PageFactory.InitElements(Browser.Driver, homePage);

                return homePage;
            }
        }

        public static LoginPage LoginPage
        {
            get
            {
                LoginPage logonPage = new LoginPage();
                PageFactory.InitElements(Browser.Driver, logonPage);

                return logonPage;
            }
        }

        public static SchoolsPage SelectedSchoolsPage
        {
            get
            {
                SchoolsPage schoolsPage = new SchoolsPage();
                PageFactory.InitElements(Browser.Driver, schoolsPage);

                return schoolsPage;
            }
        }
    }
}
