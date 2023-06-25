using OpenQA.Selenium;
using SeleniumTests.SwagLabs.PageObject;


namespace SwagLabs.PageObject
{
    internal class ConfirmPage : BasePage
    {
        private By FinishButton = By.XPath("//*[@data-test='finish']");

        public const string url = "https://www.saucedemo.com/checkout-step-two.html";
        public ConfirmPage(WebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(driver, FinishButton);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public CompletePage GoToFinish()
        {
            driver.FindElement(FinishButton).Click();
            return new CompletePage(driver);
        }
    }
}
