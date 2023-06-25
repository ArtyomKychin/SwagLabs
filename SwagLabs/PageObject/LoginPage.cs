using OpenQA.Selenium;
using SeleniumTests.SwagLabs;
using SeleniumTests.SwagLabs.PageObject;
using SwagLabs.PageObject;

namespace SauceDemo.PageObject
{
    internal class LoginPage : BasePage
    {
        private By UserNameInput = By.Id("user-name");
        private By PasswordInput = By.XPath("//*[@data-test='password']");
        private By ErrorMessage = By.CssSelector(".error-message-container.error");
        private By LoginButtom = By.CssSelector(".submit-button");

        public const string url = "https://www.saucedemo.com/";

        public const string STADART_USER_NAME = "standard_user";
        public const string STADART_USER_PASSWORD = "secret_sauce";

        public LoginPage(WebDriver webDriver) : base(webDriver)
        {
        }
        
        public override LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public InventoryPage LoginAsStandartUser()
        {
            var user = new UserLoginModel()
            {
                Name = STADART_USER_NAME,
                Password = STADART_USER_PASSWORD
            };

            TryToLogin(user);
            
            return new InventoryPage(driver);
        }

        public void TryToLogin(UserLoginModel user)
        {
            driver.FindElement(UserNameInput).SendKeys(user.Name);
            driver.FindElement(PasswordInput).SendKeys(user.Password);
            driver.FindElement(LoginButtom).Click();
        }

        internal bool VerifyErrorMesage()
        {
            return false;
        }
    }
}
