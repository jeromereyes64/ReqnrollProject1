using OpenQA.Selenium;
using ReqnrollProject.Utils;

namespace ReqnrollProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        // Constructor receives the shared WebDriver
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Element locators using ID (could also use XPath/CSS if needed)
        private IWebElement userNameField => _driver.FindElement(By.XPath("//input[@id='user-name']"));
        private IWebElement passwordField => _driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement loginButton => _driver.FindElement(By.XPath("//input[@id='login-button']"));
        public IWebElement headerText => _driver.FindElement(By.XPath("//div[text()='Swag Labs']"));

        // Navigate to the login page URL
        public void GoToLoginPage()
        {
            _driver.Navigate().GoToUrl(TestData.Users.URL);
        }

        public void EnterUsername(string username)
        {
            Common.Clear(userNameField);
            Common.SendKeys(userNameField, username);
        }

        public void EnterPassword(string password)
        {
            Common.Clear(passwordField);
            Common.SendKeys(passwordField, password);
        }

        public void ClickLogin()
        {
            Common.Click(loginButton);
        }

        public void PerformLogin(string username = "", string password = "")
        {
            GoToLoginPage();
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
            AssertHelper.ShouldBeVisible(headerText);
        }

    }
}
