using OpenQA.Selenium;

namespace SeleniumTests.SwagLabs.PageObject
{
    public abstract class BasePage
    {
        protected WebDriver driver;

        public BasePage(WebDriver webDriver)
        {
            driver = webDriver;
        }

        public abstract BasePage OpenPage();
    }
}