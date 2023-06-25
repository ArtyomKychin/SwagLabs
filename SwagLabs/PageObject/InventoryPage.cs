using OpenQA.Selenium;
using SeleniumTests.SwagLabs.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.PageObject
{
    internal class InventoryPage : BasePage  
    {
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        private By AddBikeLight = By.XPath("//*[@data-test='add-to-cart-sauce-labs-bike-light']");

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
    }
}
