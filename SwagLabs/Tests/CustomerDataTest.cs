using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.PageObject;
using SauceDemo.Test;


namespace SwagLabs.Tests
{
    internal class CustomerDataTest : SwagLabsBaseTest
    {
        [Test]
        [Description("CustomerDataTest")]

        public void GoBasePath()
        {
            new LoginPage(driver)
               .OpenPage()
               .LoginAsStandartUser()
               .BuyProductAndGoToCart()
               .GoToChekout()
               .ContinueWithoutCustomerData();

            Assert.IsNotNull(driver.FindElement(By.XPath("//*[@data-test='error']")));
        }
    }
}
