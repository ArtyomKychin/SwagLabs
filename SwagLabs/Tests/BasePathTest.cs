using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class BasePathTest : SwagLabsBaseTest
    {

        [Test]
        [Description("BasePathTest")]

        public void GoBasePath()
        {
             new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .BuyProductAndGoToCart()
                .GoToChekout()
                .ContinueVsCustomerData()
                .GoToFinish()
                .BackHome();

            Assert.IsNotNull(driver.FindElement(By.ClassName("shopping_cart_link")));
        }
    }
}
