using OpenQA.Selenium;
using SeleniumTests.SwagLabs;
using SeleniumTests.SwagLabs.PageObject;

namespace SwagLabs.PageObject
{
    internal class CheckoutPage : BasePage
    {
        private By CheckoutYourInfo= By.XPath("//*[contains(text(),'Your Information')]");

        private By FirstNameInput = By.XPath("//*[@data-test='firstName']");
        private By LastNameInput = By.XPath("//*[@data-test='lastName']");
        private By PostalCodeInput = By.XPath("//*[@data-test='postalCode']");

        public const string url = "https://www.saucedemo.com/checkout-step-one.html";
        public const string FIRSTNAME = "Artur";
        public const string LASTNAME = "Dent";
        public const string POSTALCODE = "420000";


        public CheckoutPage(WebDriver webDriver) : base(webDriver)
        {
            WaitHelper.WaitElement(driver, CheckoutYourInfo);
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public ConfirmPage ContinueVsCustomerData()
        {
            var customer = new CustomerModel()
            {
                FirstName = FIRSTNAME,
                LastName = LASTNAME,
                PostalCode = POSTALCODE
            };

            InputCustomerData(customer);
            
            return new ConfirmPage(driver);
        }

        private void InputCustomerData(CustomerModel customer)
        {
            driver.FindElement(FirstNameInput).SendKeys(customer.FirstName);
            driver.FindElement(LastNameInput).SendKeys(customer.LastName);
            driver.FindElement(PostalCodeInput).SendKeys(customer.PostalCode);
            driver.FindElement(By.XPath("//*[@data-test='continue']")).Click();
        }

        public void ContinueWithoutCustomerData()
        {
            driver.FindElement(By.XPath("//*[@data-test='continue']")).Click();
        }
    }
}
