using OpenQA.Selenium;
using SeleniumTests.SwagLabs.PageObject;

namespace SwagLabs.PageObject
{
    internal class CartPage : BasePage
    {
        private By CheckoutButton = By.XPath("//*[@data-test='checkout']");

        public const string url = "https://www.saucedemo.com/cart.html";
        public CartPage(WebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(driver, CheckoutButton);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public CheckoutPage GoToChekout()
        {
            driver.FindElement(CheckoutButton).Click();
            return new CheckoutPage(driver);
        }
    }
}
