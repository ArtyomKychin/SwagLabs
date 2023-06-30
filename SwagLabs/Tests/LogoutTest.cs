using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemo.PageObject;
using SauceDemo.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs.Tests
{
    internal class LogoutTest : SwagLabsBaseTest
    {
        [Test]
        [Description("LogoutTest")]

        public void GoBmMenuPageAndLogot()
        {
            new LoginPage(driver)
                .OpenPage()
                .LoginAsStandartUser()
                .GoToBmMenu()
                .GoToLogout();

            Assert.IsNotNull(driver.FindElement(By.XPath("//*[@data-test='login-button']")));

        }


    }
}
