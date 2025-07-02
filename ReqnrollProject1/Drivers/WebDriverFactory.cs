using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ReqnrollProject.Drivers
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Optional browser settings
            return new ChromeDriver(options);
        }
    }
}