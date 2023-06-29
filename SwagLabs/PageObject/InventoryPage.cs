using OpenQA.Selenium;
using SauceDemo.PageObject;
using SeleniumTests.SwagLabs.PageObject;

namespace SwagLabs.PageObject
{
    internal class InventoryPage : BasePage
    {
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By AddBikeLight = By.XPath("//*[@data-test='add-to-cart-sauce-labs-bike-light']");
        private By BmMenuButton = By.ClassName("bm-burger-button");
        private By LogoutButton = By.Id("logout_sidebar_link");      
        
        public const string url = "https://www.saucedemo.com/inventory.html";

        public InventoryPage(WebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(driver, ShoppingCartLink);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public CartPage BuyProductAndGoToCart()
        {
            driver.FindElement(AddBikeLight).Click();
            driver.FindElement(ShoppingCartLink).Click();
            return new CartPage(driver);
        }

        public InventoryPage GoToBmMenu()
        {
            driver.FindElement(BmMenuButton).Click();
            return new InventoryPage(driver);
        }

        public void GoToLogout()
        {
            driver.FindElement(LogoutButton).Click();
        }        
    }
}
