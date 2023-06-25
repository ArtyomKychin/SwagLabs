using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.PageObject;
using SeleniumTests.SwagLabs;

namespace SauceDemo.Test
{
    internal class LoginTest : SwagLabsBaseTest
    {

        [Test]

        public void LoginStandartUser()
        {
            
            new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser();
                        
            Assert.IsNotNull(driver.FindElement(By.ClassName("shopping_cart_link")));
            
        }

        [Test]
        public void LoginUnknownUser()
        {

            var user = new UserLoginModel()
            {
                Name = "Test",
                Password = "password"
            };

            var page = new LoginPage(driver);

            page.OpenPage().TryToLogin(user);

            page.VerifyErrorMesage();
        }

    }
}
