using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.PageObject;

namespace SauceDemo.Test
{
    internal class CartProductQuantityTest : SwagLabsBaseTest
    {

        [Test]
        [Description("CartProductQuantityTest")]

        public void GoCartProductQuantityTest()
        {
            string expcetedPruductQuantity = "2";

            new LoginPage(driver)
               .OpenPage()
               .LoginAsStandartUser()
               .AddProducts();         

            Assert.That((driver.FindElement(By.ClassName("shopping_cart_link")).Text), Is.EqualTo(expcetedPruductQuantity));
        }
    }
}
