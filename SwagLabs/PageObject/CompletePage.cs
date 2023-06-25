using OpenQA.Selenium;
using SeleniumTests.SwagLabs.PageObject;

namespace SwagLabs.PageObject
{
    internal class CompletePage : BasePage
    {
        private By BackHomeButton = By.XPath("//*[@data-test='back-to-products']");

        public const string url = "https://www.saucedemo.com/checkout-complete.html";

        public CompletePage(WebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(driver, BackHomeButton);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public InventoryPage BackHome()
        {
            driver.FindElement(BackHomeButton).Click();
            return new InventoryPage(driver);
        }
    }
}
