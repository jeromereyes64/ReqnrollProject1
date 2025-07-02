using OpenQA.Selenium;
using Reqnroll;
using Reqnroll.BoDi;
using ReqnrollProject.Drivers;
using ReqnrollProject.Pages;

namespace ReqnrollProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IObjectContainer _container;

        public Hooks(ScenarioContext scenarioContext, IObjectContainer container)
        {
            _scenarioContext = scenarioContext;
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver driver = WebDriverFactory.CreateDriver();

            // Register the WebDriver and Page Object so DI works in step definitions
            _container.RegisterInstanceAs(driver);
            _container.RegisterTypeAs<LoginPage, LoginPage>();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}
